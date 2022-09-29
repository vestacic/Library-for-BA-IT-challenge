using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Library
{
    internal class list: IEnumerable
    {
        node start;
        node end;
        node suplementary;
        node connection;
        public list()
        {
            end = new node(null, null);
            start = new node(null, end);
            suplementary = start;
            connection = new node(null, null);

        }
        public IEnumerator GetEnumerator()
        {
            for(node d=start.next_one; d.next_one!=null; d=d.next_one)
            {
                yield return d.information;
            }
        }
        public void add_new(Book b)
        {
            suplementary.next_one = new node(b, end);
            suplementary = suplementary.next_one;

        }
        public void get_to_start()
        {
            connection = start.next_one;
        }
        public bool not_end()
        {
            return connection.next_one != null;
        }
        public void go_to_next_one()
        {
            connection = connection.next_one;
        }
        public Book get_information()
        {
            return connection.information;
        }
    }
}
