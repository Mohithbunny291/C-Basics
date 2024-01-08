using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class ConvertClass
    {
        public ConvertClass()
        {
            byte[] B = { 2, 4, 6, 8, 249 };
            Console.WriteLine("BArray is :{0}", BitConverter.ToString(B));
            
            


            Console.WriteLine(B.GetType());

            Console.WriteLine();
            String str = Convert.ToBase64String(B);
            Console.WriteLine("Base 64 string is :{0}", str);
        }
    }
}
