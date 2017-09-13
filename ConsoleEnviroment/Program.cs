


using System;
using System.Collections.Generic;

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
       static int compare(int a, int b)
        {
            return b.CompareTo(a);
        }

        public static void checkdata(string s)
        {
            string[] a_temp = s.Split(',');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            List<int> lst = new List<int>();
            foreach (int i in a)
            {
                if (!lst.Contains(i))
                {
                    lst.Add(i);
                    
                }

            }

            lst.Sort(compare);
            foreach (int i in lst)
            {
                Console.Write(i + ",");
            }
        }

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

        public static int factorial(int n)
        {
            if (n>1)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return 1;
            }
        }
        static int birthdayCakeCandles(int n, int[] ar)
        {
            // Complete this function
            int max = 0;
            int count = 0;
            foreach (int k in ar)
            {
                if (k == max)
                    count++;
                else if (k > max)
                {
                    max = k;
                    count = 1;
                }

            }
            return count;
        }

        static string timeConversion(string s) {
            // Complete this function
            string s_time = null;

            if (s.EndsWith("PM"))
            {
                s = s.Remove(s.Length - 2, 2);
                string[] s_temp = s.Split(':');
                int[] time = Array.ConvertAll(s_temp, Int32.Parse);
                if (time[0] > 12)
                    time[0] = time[0] - 12;
                else if (time[0] < 12)
                    time[0] = time[0] + 12;

                s_temp[0] = time[0].ToString("00");
                if (time[0] == 24)
                {
                    s_temp[0] = "00";
                }
                s_time = string.Format("{0}:{1}:{2}", s_temp[0], s_temp[1], s_temp[2]);
            }
            else if (s.EndsWith("AM"))
            {
                s = s.Remove(s.Length - 2, 2);
                string[] s_temp = s.Split(':');

                int[] time = Array.ConvertAll(s_temp, Int32.Parse);
                if (time[0] == 12)
                {
                    s_temp[0] = "00";
                }
                s_time = string.Format("{0}:{1}:{2}", s_temp[0], s_temp[1], s_temp[2]);
            }
            return s_time;
        }

        static void Main(string[] args)
        {
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            Console.WriteLine("Dog: "+ sparky.tryToFly());

            Console.WriteLine("Bird: "+ tweety.tryToFly());

            //This allows dynamic changes for flyingType
            sparky.setFlyingAbility(new ItFlys());
            Console.WriteLine("Dog: " + sparky.tryToFly());

            //string s = Console.ReadLine();
            //string result = timeConversion(s);
            //Console.WriteLine(result);




            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ar_temp = Console.ReadLine().Split(' ');
            //int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            //int result = birthdayCakeCandles(n, ar);
            //Console.WriteLine(result);


            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //List<long> list = new List<long>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    long sum = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (i != j)
            //            sum += arr[j];

            //    }
            //    list.Add(sum);
            //}

            //list.Sort();
            //Console.WriteLine("{0} {1}", list[0], list[list.Count - 1]);

            //string s = Console.ReadLine();
            //string database = "abcdefghijklmnopqrstuvwxyz";
            //char[] charbase = database.ToCharArray();
            //List<char> lst = new List<char>();
            //lst.AddRange(charbase);

            //foreach (char c in s.ToLower())
            //{
            //    if (lst.Contains(c))
            //    {
            //        lst.Remove(c);
            //    }
            //}

            //if(lst.Count != 0)
            //{
            //    Console.WriteLine("not pangram");
            //}
            //else
            //{
            //    Console.WriteLine("pangram");
            //}



            //int i = 1;
            //while (true)
            //{
            //    int crtNum = i * i;
            //    if (crtNum <= 1000 && crtNum>=100) 
            //    {
            //        Console.Write(crtNum + ",");
            //    }
            //    else if (crtNum>1000)
            //    {
            //        break;
            //    }
            //    i++;
            //}


            //checkdata("1,3,2,1,4,5,7,6,9,5,6,7");


            //String title = Console.ReadLine();
            //String author = Console.ReadLine();
            //int price = Int32.Parse(Console.ReadLine());
            //Book new_novel = new MyBook(title, author, price);
            //new_novel.display();


            //int[][] arr = new int[6][];
            //for (int arr_i = 0; arr_i < 6; arr_i++)
            //{
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            //}
            //int maxSum = 0;
            //int currentSum = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        currentSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
            //            arr[i + 1][j + 1] +
            //            arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
            //        if (currentSum > maxSum)
            //        {
            //            maxSum = currentSum;
            //        }
            //    }

            //}

            //Console.WriteLine(maxSum);




            //int recursiveValue = Convert.ToInt32(Console.ReadLine());
            //int result = factorial(recursiveValue);
            //Console.WriteLine(result);


            //int decimalValue = Convert.ToInt32(Console.ReadLine());
            //int maxCount = 0, consecutiveCount = 0;
            //int remainder = 0;
            //while (true)
            //{
            //    remainder = decimalValue % 2;
            //    decimalValue = decimalValue / 2;
            //    if (remainder == 1)
            //    {
            //        consecutiveCount++;
            //        if (consecutiveCount>maxCount)
            //        {
            //            maxCount = consecutiveCount;
            //        }
                    
            //    }
            //    else
            //    {
            //        consecutiveCount = 0;
            //    }
            //    if (decimalValue == 0)
            //    {
            //        break;
            //    }

            //}

            //Console.WriteLine(maxCount);




            //int n = Convert.ToInt32(Console.ReadLine());
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            //for (int i = 0; i < n; i++)
            //{
            //    string[] s= Console.ReadLine().Split(' ');
            //    string name = s[0];
            //    string phoneNumber = s[1];
            //    phoneBook.Add(name, phoneNumber);

            //}

            //while (true)
            //{
            //    string nameToLookUp = Console.ReadLine();
            //    if (phoneBook.ContainsKey(nameToLookUp))
            //    {
            //        string phoneNumber = phoneBook[nameToLookUp];
            //        Console.WriteLine("{0}={1}", nameToLookUp, phoneNumber);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not found");
            //    }
            //}



            //Car birthdayPresent = new Car(500, 5000.546, true);
            //Console.WriteLine("Birthday Car v1");
            //birthdayPresent.printVariables();
            //birthdayPresent.getIn();
            //birthdayPresent.getIn();
            //birthdayPresent.getIn();
            //Console.WriteLine("Miles Left:" + birthdayPresent.howManyMilesTillOutOfGas());
            //Console.WriteLine("Max Miles:" + birthdayPresent.maxMilesPerFillUp());

            //Console.WriteLine("Birthday Car v2");
            //birthdayPresent.printVariables();
            //birthdayPresent.getOut();

            //Console.WriteLine("Birthday Car v3");
            //birthdayPresent.printVariables();

















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
