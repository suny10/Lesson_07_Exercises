using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson_07_Exercises.App
{
    public class Printer
    {
        public void PrintNumbers(string caption, IEnumerable<int> numbers)
        {
            Console.WriteLine(caption);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);               
            }
            Console.WriteLine("___________");
        }
    }
}
