using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Information n1 = new Note();
            Information n2 = new Data();

            n1.InformationAdded();
            n1.InformationDeleted();

            n2.InformationAdded();
            n2.InformationDeleted();
        }
    }
    abstract class Information
    {
        public void InformationAdded()
        {
            Console.WriteLine("Succesful");
        }
        public abstract void InformationDeleted();
    }
    class Note : Information
    {
        public override void InformationDeleted()
        {
            Console.WriteLine("Note is Deleted");
        }
    }
    class Data : Information
    {
        public override void InformationDeleted()
        {
            Console.WriteLine("Data is Deleted");
        }
    }
}