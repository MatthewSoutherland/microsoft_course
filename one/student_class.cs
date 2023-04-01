using System;

namespace testing_two
{
    class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            IsEnrolled = true;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsEnrolled { get; set; }

    }
}