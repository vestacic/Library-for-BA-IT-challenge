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
    public partial class Form4 : Form
    {
        public Form4()
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
            bool returned=mainForm.returnbook(b);
            if (returned == true) MessageBox.Show("The book has been returned!");
            else MessageBox.Show("The book you are trying to return has not been found. New book has been added instead");
        }
    }
}
