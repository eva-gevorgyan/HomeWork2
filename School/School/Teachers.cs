using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Teachers : S
    {
        //public string name;
        //public Teachers(string name)
        //{
        //    this.name = name;
        //}
        public Teachers()
        {
            
        }
        //public override void who(string b) {
        //    switch (b)
        //    {
        //        case "English":
        //            Console.WriteLine(((Which_Teacher)0));
        //            break;
        //        case "Russian":
        //            Console.WriteLine(((Which_Teacher)1));
        //            break;
        //        case "Maths":
        //            Console.WriteLine(((Which_Teacher)2));
        //            break;
        //        case "Programming":
        //            Console.WriteLine(((Which_Teacher)3));
        //            break;
        //        default:
        //            Console.WriteLine("Not found");
        //            break;
        //    }
        //}
        public override void subject(string a)
        {
            switch(a)
            {
                case "English":
                    Console.WriteLine("Subject - " + ((Teachers_List)0) + ", Teacher - " + ((Which_Teacher)0));
                    break;
                case "Russian":
                    Console.WriteLine("Subject - " + ((Teachers_List)1) + ", Teacher - " + ((Which_Teacher)1));
                    break;
                case "Maths":
                    Console.WriteLine("Subject - " + ((Teachers_List)2) + ", Teacher - " + ((Which_Teacher)2));
                    break;
                case "Programming":
                    Console.WriteLine("Subject - " + ((Teachers_List)3) + ", Teacher - " + ((Which_Teacher)3));
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
            }
        }
    }
    enum Which_Teacher
    {
        Sargsyan,
        Hakobyan,
        Margaryan,
        Mesropyan
    }
    enum Teachers_List
    {
        English,
        Russian,
        Maths,
        Programming
    }
}
