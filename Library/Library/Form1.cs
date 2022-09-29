using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Form1 : Form
    {
        list all_books;
        public Form1()
        {
            InitializeComponent();
            create_drop_down_menu();
            all_books = new list();

        }
        private void create_drop_down_menu()
        {
            charasteristic.Items.Add("Title");
            charasteristic.Items.Add("Author");
            charasteristic.Items.Add("Publisher");
            charasteristic.Items.Add("Publishing year");
            charasteristic.Items.Add("Genre");
            charasteristic.Items.Add("ISBN code");
            charasteristic.Items.Add("Status");
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Library simulation programme for BA IT challenge");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = charasteristic.SelectedItem.ToString();
            string value = specific.Text;
            list by_specific=new list();
            if (c == "Title")
                by_specific = new_list_by_name(value);
            else if (c == "Author")
                by_specific = new_list_by_author(value);
            else if (c == "Publisher")
                by_specific = new_list_by_publisher(value);
            else if (c == "Publishing year")
            {
                int year = int.Parse(value);
                by_specific = new_list_by_year(year);
            }
            else if (c == "ISBN")
                by_specific = new_list_by_isbn(value);
            else if (c == "Genre")
                by_specific = new_list_by_genre(value);
            print_list(by_specific);
            list_name.Text = String.Format("List by your chosen charasteristic {0}: {1}", c, value);
        }
        private list new_list_by_name(string title)
        {
            list l = new list();
            foreach(Book b in all_books)
            {
                if(b.title==title)
                {
                    l.add_new(b);
                }
            }
            return l;
        }
        private list new_list_by_author(string author)
        {
            list l = new list();
            foreach(Book b in all_books)
            {
                if(b.author==author)
                {
                    l.add_new(b);
                }
            }
            return l;
        }
        private list new_list_by_publisher(string publisher)
        {
            list l = new list();
            foreach (Book b in all_books)
            {
                if(b.publisher==publisher)
                {
                    l.add_new(b);
                }
            }
            return l;
        }
        private list new_list_by_year(int year)
        {
            list l = new list();
            foreach(Book b in all_books)
            {
                if(b.date==year)
                {
                    l.add_new(b);
                }
            }
            return l;
        }
        private list new_list_by_isbn(string isbn)
        {
            list l = new list();
            foreach(Book b in all_books)
            {
                if(b.isbn==isbn)
                {
                    l.add_new(b);
                }
            }
            return l;
        }
        private list new_list_by_genre(string genre)
        {
            list l = new list();
            foreach(Book b in all_books)
            {
                if (b.genre==genre)
                {
                    l.add_new(b);
                }
            }
            return l;
        }
        private list new_list_by_status(string status)
        {
            list l = new list();
            foreach(Book b in all_books)
            {
                if(b.status==status)
                {
                    l.add_new(b);
                }
            }
            return l;
        }
        private void print_list(list l)
        {
            string text = "---------------------------------------------------------------------------\n";
            text+= string.Format("|{0, -15}|{1, -15}|{2, -10}|{3, -5}|{4,-7}|{5,-8}|{6,-7}|\n", "Title", "Author", "Publisher", "Date", "Genre", "ISBN", "Status");
            text+= "---------------------------------------------------------------------------\n";
            int n = 0;
            foreach(Book b in l)
            {
                text += b.ToString();
                text += "\n";
                text+= "---------------------------------------------------------------------------\n";
                ++n;
            }
            if (n != 0) list_display.Text = text;
            else list_display.Text = "There are no books with your given charasteristics";
        }

        private void forLibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        public void add_book(Book b)
        {
            all_books.add_new(b);
            list_name.Text = "New book has been added. All the books:";
            print_list(all_books);
        }

        private void reserveborrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        public bool find_book(Book b,string status)
        {
            foreach(Book bb in all_books)
            {
                if(bb.title==b.title && bb.author==b.author && bb.isbn==b.isbn && bb.publisher==b.publisher && bb.date==b.date && bb.status=="free")
                {
                    bb.status = status;
                    print_list(all_books);
                    list_name.Text = "List with updated status of the books";
                    return true;
                }
                    
            }
            return false;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To see the filtered booklist - choose the filtering criteria and enter the specific requirement");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            print_list(all_books);
            list_name.Text = "Full booklist";
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
        public bool returnbook(Book b)
        {
            bool returned = false;
            foreach(Book bb in all_books)
            {
                if (bb.title == b.title && bb.author == b.author && bb.isbn == b.isbn && bb.publisher == b.publisher && bb.date == b.date && bb.status != "free")
                {
                    bb.status = "free";
                    returned = true;
                    break;
                }
            }
            if (returned == false) add_book(b);
            return returned;
        }
    }
}
