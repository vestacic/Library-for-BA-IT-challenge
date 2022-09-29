using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            string t = title.Text;
            string a = author.Text;
            string p = publisher.Text;
            int y = int.Parse(year.Text);
            string i = isbn.Text;
            string g = genre.Text;
            Book b = new Book(t, a, p, y, g, i);
            mainForm.add_book(b);
            Close();
        }
    }
}
