using System;

namespace ConsoleEnviroment
{
    class Program
    {
        //    static void Main(string[] args)
        //    {
        //        var stuName = "John";
        //        var stuList = new List<string>() {"Lily", "Kimy", "Geogre"};
        //        for (var i = 0; i < 5; i++)
        //        {

        //        }
        //        foreach (var item in stuList)
        //        {

        //        }
        //        using (SqlConnection conn = new SqlConnection())
        //        {

        //        }

        //        Console.ReadKey();


        //        var student = new {stuId = 1001, stuName = "John", Age = 20};
        //        string info = string.Format("Student No:{0},Name:{1},Age:{2}", student.stuId, student.stuName, student.Age);
        //        Console.WriteLine(info);


        //        Console.ReadKey();

        //        OptionalParameter.OptionalParameter op = new OptionalParameter.OptionalParameter();
        //        op.QueryStudent("John");
        //        op.QueryStudent("John", "Design B");
        //        op.QueryStudent(age:22, className: "Design C", stuName:"John" );


        //    }
        //}



        static void Main(string[] args)
        {
            dynamic person1 = new Student {StudentId = 10001, StudentName = "John"};
            person1.GetInfo();

            dynamic person2 = new Teacher {TeacherId = 20000, TeacherName = "Katy"};
            person2.GetInfo();
        }


        class Student
        {
            public int StudentId { get; set; }

            public string StudentName { get; set; }

            public void GetInfo()
            {
                Console.WriteLine("Name:{0} Student No:{1} ");
            }
        }

        class Teacher
        {
            public int TeacherId { get; set; }

            public string TeacherName { get; set; }

        }

    }
}
