using System;

namespace testing_two
{
    public class Student
    {
        // Constructor, by placing parameters you ensure values wont be null
        public Student(string FirstName, string LastName, int Age)
        {
            IsEnrolled = true;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public bool IsEnrolled { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student()
            {
                FirstName = "Garrett",
                LastName = "Southerland",
                Age = 14,
                IsEnrolled = true
            };
            Console.WriteLine($"{s.FirstName}\n{s.LastName}\n{s.Age}\n{s.IsEnrolled}");
        }
    }
}