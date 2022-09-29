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
    public partial class Form3 : Form
    {
        public Form3()
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
            if (mainForm.find_book(b, "reserved") == true) MessageBox.Show("The book has been successfully reserved!");
            else MessageBox.Show("The book does not exist or is already taken!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            string t = title.Text;
            string a = author.Text;
            string p = publisher.Text;
            int y = int.Parse(year.Text);
            string i = isbn.Text;
            string g = genre.Text;
            Book b = new Book(t, a, p, y, g, i);
            if (mainForm.find_book(b, "borrowed") == true) MessageBox.Show("The book has been successfully borrowed!");
            else MessageBox.Show("The book does not exist or is already taken!");
        }
    }
}
