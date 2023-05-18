using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System.Reflection.Metadata;
using com.itextpdf.text.pdf;
using System.Drawing;
using Color = System.Drawing.Color;
using iTextSharp.text.pdf.parser;
using System.Text;
using Aspose.Pdf.Operators;
using Document = iTextSharp.text.Document;
using PdfSharp.Drawing.Layout;
using PdfSharp.Drawing;
using System.Xml.Linq;

namespace Exam
{
    public partial class Form1 : Form
    {
        #region other
        private bool isDarkTheme = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void ApplyDark()
        {
            if (isDarkTheme)
            {
                BackColor = Color.DarkGray;
                ForeColor = Color.DarkOrange;

                listView1.BackColor = Color.Gray;
                listView1.ForeColor = Color.DarkOrange;

                Dark.BackColor = Color.Gray;
                Dark.ForeColor = Color.DarkOrange;

                New.BackColor = Color.Gray;
                New.ForeColor = Color.DarkOrange;
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;

                listView1.BackColor = Color.White;
                listView1.ForeColor = Color.Black;

                Dark.BackColor = Color.White;
                Dark.ForeColor = Color.Black;

                New.BackColor = Color.White;
                New.ForeColor = Color.Black;
            }
        }

        #endregion

        #region Button
        private void New_Click(object sender, EventArgs e)
        {
            Add newTask = new Add();


            if (newTask.ShowDialog() == DialogResult.OK)
            {
                string Description = $"{Data.Workers + " " + Data.Descrioton + " " + Data.dateTime + " " + Data.Time + " " + Data.Priority + "\n"}";
                listView1.Items.Insert(0, Description);

            }
            newTask.Dispose();
        }
        private void Dark_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            ApplyDark();

        }
        private void LV_ToDo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        #endregion

        #region SeveLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            Listload();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Вы действительно хотите выйти из программы?",
                "Завершение программы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Listsave();

                    MessageBox.Show("PDF сохранен успешно!", "Сохранение PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Listload()
        {
            string fileName = "Output.pdf";

            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);
                listView1.Items.Clear();

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));

                    ListViewItem item = new ListViewItem(currentText);
                    listView1.Items.Add(item);
                }

                pdfReader.Close();
            }
        }
        private void Listsave()
        {
            string FileName = "Output.pdf";
            Document document = new Document();

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(FileName, FileMode.Create));
            document.Open();

            foreach (ListViewItem item in listView1.Items)
            {
                document.NewPage();
                Paragraph paragraph = new Paragraph(item.Text);
                document.Add(paragraph);
            }
            document.Close();

        }
        #endregion

        #region Drag
        private void List_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            ListView targetListView = (ListView)sender;

            targetListView.Items.Add((ListViewItem)draggedItem.Clone());

            ListView sourceListView = (ListView)draggedItem.ListView;
            sourceListView.Items.Remove(draggedItem);
        }

        private void List_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void List_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListView listView = (ListView)sender;
            listView.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        #endregion

    }
}