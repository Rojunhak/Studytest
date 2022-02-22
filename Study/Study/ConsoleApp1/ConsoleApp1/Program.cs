using System;

namespace ConsoleApp1
{
    class Program
    {
        static Birth birth;
        static void Main(string[] args)
        {
            birth = new Birth();
            birth.Name = "나";
            birth.BrithDate = new DateTime(1994, 02, 15);


            Console.WriteLine($"{birth.Name} 나이 : {birth.Age}");
        }
    }

    class Birth
    {
        public string Name { get; set; }
        public DateTime BrithDate { get; set; }
        public int Age
        {
            get => (DateTime.Now - BrithDate).Days / 365+1;
        }

        
    }
}
