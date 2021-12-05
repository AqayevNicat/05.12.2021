using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Study();
            student1.SetAge(12);
            Teacher teacher1 = new Teacher();
            teacher1.Explain();
            student1.ShowAge();
        }
    }
}
