﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        // Сохраняет в Date название пользователя
        private void button1_Click(object sender, EventArgs e)
        {
            Data.Workers = textBox1.Text.ToString();
        }
    }
}
