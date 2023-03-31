using System;

namespace testing_two
{
    public class Student
    {
        // Constructor, by placing parameters you ensure values wont be null
        public Student(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
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
            var s = new Student("Garrett", "Southerland", 13);
            Console.WriteLine($"{s.FirstName}\n{s.LastName}\n{s.Age}\n{s.IsEnrolled}");
        }
    }
}