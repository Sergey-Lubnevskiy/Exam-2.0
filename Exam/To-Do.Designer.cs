namespace Exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            New = new Button();
            listView1 = new ListView();
            Dark = new Button();
            SuspendLayout();
            // 
            // New
            // 
            New.FlatStyle = FlatStyle.Flat;
            New.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            New.Location = new Point(12, 11);
            New.Margin = new Padding(3, 2, 3, 2);
            New.Name = "New";
            New.Size = new Size(189, 49);
            New.TabIndex = 0;
            New.Text = "Новая задача";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // listView1
            // 
            listView1.AllowDrop = true;
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(1, 64);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(308, 406);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.ItemDrag += List_ItemDrag;
            listView1.DragDrop += List_DragDrop;
            listView1.DragEnter += List_DragEnter;
            listView1.KeyDown += LV_ToDo_KeyDown;
            // 
            // Dark
            // 
            Dark.FlatStyle = FlatStyle.Flat;
            Dark.Location = new Point(207, 11);
            Dark.Name = "Dark";
            Dark.Size = new Size(88, 23);
            Dark.TabIndex = 12;
            Dark.Text = "Темная тема";
            Dark.UseVisualStyleBackColor = true;
            Dark.Click += Dark_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 488);
            Controls.Add(Dark);
            Controls.Add(listView1);
            Controls.Add(New);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "ToDo";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button New;
        private ListView listView1;
        private Button Dark;
    }
}