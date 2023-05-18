namespace Exam
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Workers = new ComboBox();
            Description = new RichTextBox();
            label3 = new Label();
            DT_FullData = new DateTimePicker();
            DT_Time = new DateTimePicker();
            Done = new Button();
            groupBox1 = new GroupBox();
            Hight = new RadioButton();
            Middle = new RadioButton();
            Low = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Работники";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // Workers
            // 
            Workers.FormattingEnabled = true;
            Workers.Location = new Point(106, 27);
            Workers.Margin = new Padding(3, 2, 3, 2);
            Workers.Name = "Workers";
            Workers.Size = new Size(133, 23);
            Workers.TabIndex = 2;
            // 
            // Description
            // 
            Description.Location = new Point(106, 59);
            Description.Margin = new Padding(3, 2, 3, 2);
            Description.Name = "Description";
            Description.Size = new Size(537, 24);
            Description.TabIndex = 3;
            Description.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 27);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Начало работы";
            // 
            // DT_FullData
            // 
            DT_FullData.CustomFormat = "yyy.MM.dd";
            DT_FullData.Format = DateTimePickerFormat.Custom;
            DT_FullData.Location = new Point(460, 27);
            DT_FullData.Margin = new Padding(3, 2, 3, 2);
            DT_FullData.Name = "DT_FullData";
            DT_FullData.Size = new Size(93, 23);
            DT_FullData.TabIndex = 5;
            // 
            // DT_Time
            // 
            DT_Time.CustomFormat = "HH:mm";
            DT_Time.Format = DateTimePickerFormat.Custom;
            DT_Time.Location = new Point(567, 28);
            DT_Time.Margin = new Padding(3, 2, 3, 2);
            DT_Time.Name = "DT_Time";
            DT_Time.Size = new Size(76, 23);
            DT_Time.TabIndex = 6;
            // 
            // Done
            // 
            Done.DialogResult = DialogResult.OK;
            Done.Location = new Point(182, 133);
            Done.Margin = new Padding(3, 2, 3, 2);
            Done.Name = "Done";
            Done.Size = new Size(82, 22);
            Done.TabIndex = 7;
            Done.Text = "Готово";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Hight);
            groupBox1.Controls.Add(Middle);
            groupBox1.Controls.Add(Low);
            groupBox1.Location = new Point(10, 84);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(276, 44);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Приоритет";
            // 
            // Hight
            // 
            Hight.AutoSize = true;
            Hight.Location = new Point(172, 20);
            Hight.Margin = new Padding(3, 2, 3, 2);
            Hight.Name = "Hight";
            Hight.Size = new Size(74, 19);
            Hight.TabIndex = 2;
            Hight.TabStop = true;
            Hight.Text = "Высокий";
            Hight.UseVisualStyleBackColor = true;
            Hight.CheckedChanged += Hight_CheckedChanged;
            // 
            // Middle
            // 
            Middle.AutoSize = true;
            Middle.Location = new Point(86, 20);
            Middle.Margin = new Padding(3, 2, 3, 2);
            Middle.Name = "Middle";
            Middle.Size = new Size(73, 19);
            Middle.TabIndex = 1;
            Middle.TabStop = true;
            Middle.Text = "Средний";
            Middle.UseVisualStyleBackColor = true;
            Middle.CheckedChanged += Middle_CheckedChanged;
            // 
            // Low
            // 
            Low.AutoSize = true;
            Low.Location = new Point(9, 20);
            Low.Margin = new Padding(3, 2, 3, 2);
            Low.Name = "Low";
            Low.Size = new Size(66, 19);
            Low.TabIndex = 0;
            Low.TabStop = true;
            Low.Text = "Низкий";
            Low.UseVisualStyleBackColor = true;
            Low.CheckedChanged += Low_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(245, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 187);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(Done);
            Controls.Add(DT_Time);
            Controls.Add(DT_FullData);
            Controls.Add(label3);
            Controls.Add(Description);
            Controls.Add(Workers);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewTask";
            Text = "NewTask";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox Workers;
        private RichTextBox Description;
        private Label label3;
        private DateTimePicker DT_FullData;
        private DateTimePicker DT_Time;
        private Button Done;
        private GroupBox groupBox1;
        private RadioButton Hight;
        private RadioButton Middle;
        private RadioButton Low;
        private Button button1;
    }
}