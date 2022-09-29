using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public sealed class node
    {
        public Book information { get; set; }
        public node next_one { get; set; }
        node()
        {
            ;
        }
        public node (Book information, node next_one)
        {
            this.information = information;
            this.next_one = next_one;
        }

    }
}
