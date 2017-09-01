


using CSharpTraining;
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



        //static void Main(string[] args)
        //{
        //    dynamic person1 = new Student {StudentId = 10001, StudentName = "John"};
        //    person1.GetInfo();

        //    dynamic person2 = new Teacher {TeacherId = 20000, TeacherName = "Katy"};
        //    person2.GetInfo();
        //}


        //class Student
        //{
        //    public int StudentId { get; set; }

        //    public string StudentName { get; set; }

        //    public void GetInfo()
        //    {
        //        Console.WriteLine("Name:{0} Student No:{1} ");
        //    }
        //}

        //class Teacher
        //{
        //    public int TeacherId { get; set; }

        //    public string TeacherName { get; set; }

        //}



        //static void Main(string[] args)
        //{
        //    Random rd = new Random();
        //    int next = rd.Next()%5999;

        //    string x = next.ToString("0000");
        //    string y = Console.ReadLine();

        //    char[] pindigits = x.ToCharArray();

        //    char[] guessdigits = y.ToCharArray();

        //    bool[] pos = new bool[4];

        //    int rightcounter = 0, wrongcounter = 0;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (pindigits[i] == guessdigits[i])
        //        {
        //            pos[i] = true;
        //            rightcounter++;

        //        }
        //        else
        //        {
        //            pos[i] = false;
        //            wrongcounter++;
        //        }


        //    }
        //    Console.WriteLine("The number of correct digits is {0} and the number of incorrect place is {1}", rightcounter, wrongcounter);
        //    Console.WriteLine("x is "+x.ToString());
        //    Console.WriteLine("y is "+ y.ToString());

        //    Console.ReadKey();


        //}
        public static int Solution(int N)
        {
            char[] binary = Convert.ToString(N, 2).ToCharArray();
            bool flg = false;
            int maxCounter = 0;
            int crtCounter = 0;
            foreach (char crtChar in binary)
            {
                if (crtChar == '1')
                {
                    flg = true;
                    if (crtCounter > maxCounter)
                    {
                        maxCounter = crtCounter;
                        
                    }
                    crtCounter = 0;
                    continue;
                }
                
                if(crtChar == '0' && flg)
                {
                    crtCounter++;
                }
            }

            return maxCounter;
        }

        static void Main(string[] args)
        {

            Car birthdayPresent = new Car(500, 5000.546, true);
            Console.WriteLine("Birthday Car v1");
            birthdayPresent.printVariables();
            birthdayPresent.getIn();
            birthdayPresent.getIn();
            birthdayPresent.getIn();
            Console.WriteLine("Miles Left:" + birthdayPresent.howManyMilesTillOutOfGas());
            Console.WriteLine("Max Miles:" + birthdayPresent.maxMilesPerFillUp());

            Console.WriteLine("Birthday Car v2");
            birthdayPresent.printVariables();
            birthdayPresent.getOut();

            Console.WriteLine("Birthday Car v3");
            birthdayPresent.printVariables();

















            //Car carry = new Car();
            //carry.printVariables();

            //Convert.ToDouble(Console.ReadLine());

            //Car familyCar = new Car();
            //Console.WriteLine("Family's Car:");
            //familyCar.printVariables();

            //Car aliceCar = familyCar;
            //familyCar.wreckCar();
            //Console.WriteLine("Alice's Car:");
            //aliceCar.printVariables();

            //familyCar.upgradeMinSpeed();
            //familyCar.printVariables();


            Console.ReadKey();

            //int N = 1376796946;
            //int a = Solution(N);
            //Console.WriteLine(a);
            //Console.ReadKey();
        }

       



    }
}
