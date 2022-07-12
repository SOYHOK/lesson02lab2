using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson02lab2
{
    class Phone
    {
        public string strModel;
        private float fltScreenSize;

        public float ScreenSize
        {
            get { return fltScreenSize; }
            set { if (value > 0) fltScreenSize = value; }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Phone pObj = new Phone();
                Console.WriteLine("Enter the type:");
                pObj.strModel = Console.ReadLine();
                Console.WriteLine("Enter the screen size:");
                pObj.ScreenSize = float.Parse(Console.ReadLine());
                Console.WriteLine("Type: {0} ScreenSize: {1}", pObj.strModel, pObj.ScreenSize);

            }
        }
}

