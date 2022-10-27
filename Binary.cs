using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
   public class Binary<T> where T : IComparable<T>
    {
        public T Nodedata { get; set; } 
        public Binary<T> Lefttree { get; set; }
        public Binary<T> Righttree { get; set; }
        public Binary(T Nodedata)
        {
            this.Nodedata = Nodedata;
            this.Lefttree = null;
            this.Righttree = null;
        }
        int leftcount=0, rightcount=0;
        bool result =false;
        public void add(T items)
        {
            T currentnodevalue = this.Nodedata;
            if ((currentnodevalue.CompareTo(items)) > 0)
            {
                if (this.Lefttree == null)
                    this.Lefttree=new Binary<T>(items);
                else 
                    this.Lefttree.add(items);
               
            }
            else
            {
                if(this.Righttree == null)
                    this.Righttree=new Binary<T>(items);
                else
                    this.Righttree.add(items);
            }

        }
        public void Display()
        {
            if (this.Lefttree != null)
            {
                this.leftcount++;
                this.Lefttree.Display();
            }
            Console.WriteLine(this.Nodedata.ToString());
            if(this.Righttree != null)
            {
                this.rightcount++;
                this.Righttree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size Of the BST is :"+(1+this.leftcount+this.rightcount));
        }


    }

}
