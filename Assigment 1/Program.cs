namespace Assigment_1
{
    #region Q1
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    #endregion
    #region Q3
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    #endregion
    #region Q5
    [Flags]
    enum premission
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1
    }

    #endregion
    #region Q5
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Q2
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Omar", 20);
            //persons[1] = new Person("Ahmed", 25);
            //persons[2] = new Person("Eslam", 21);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(persons[i]);
            //}
            #endregion
            #region Q3
            //Console.Write("Enter the name of a season: ");
            //Season S01;
            //Enum.TryParse(typeof(Season), Console.ReadLine(), true, out object s1);
            //S01 = (Season)s1;


            //switch (S01)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid season.");
            //        break;
            //}


            #endregion
            #region Q4
            //premission per01 = premission.Read;
            //per01 ^= premission.Delete; // Toggle 

            ////per01 |= premission.Delete; // Add permession

            ////Console.WriteLine(per01); // Read , Delete 
            ////per01 ^= premission.Delete; // Toggle 
            ////Console.WriteLine(per01); // Read 

            //Console.WriteLine(per01); // Read , Delete 
            ////per01 &= ~(premission.Delete); //  ~Not Bitwise 
            //// & -> check permissions
            //if ((per01 & premission.Delete) == premission.Delete)
            //{

            //    Console.WriteLine("Esixts");
            //}
            //else
            //{
            //    Console.WriteLine("Not Esits ");
            //}
            #endregion
            #region Q5
            ////Console.Write("Enter a color name: ");
            ////string inputColor = Console.ReadLine();
            ////if (Enum.TryParse(inputColor, true, out Colors color))
            ////{
            ////    Console.WriteLine($"{color} is a primary color.");
            ////}
            ////else
            ////{
            ////    Console.WriteLine($"{inputColor} is not a primary color.");
            ////}
            #endregion
            #region Q6
            //Console.Write("Enter X1 : ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter Y1 : ");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter X2 : ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter Y2 : ");
            //double y2 = double.Parse(Console.ReadLine());
            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);
            //double distance = Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2));
            //Console.WriteLine($"The the distance between Point1 And Ponit2 is :{distance}");
            #endregion
            #region Q7
            //    Person oldestPerson = new Person("", 0);

            //    for (int i = 1; i <= 3; i++)
            //    {
            //        Console.Write($"Enter the name of person {i}: ");
            //        string name = Console.ReadLine();

            //        Console.Write($"Enter the age of person {i}: ");
            //        int age;
            //        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            //        {
            //            Console.Write("Please enter a valid non-negative age: ");
            //        }

            //        Person person = new Person(name, age);

            //        if (person.Age > oldestPerson.Age)
            //        {
            //            oldestPerson = person;
            //        }
            //    }

            //    Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with {oldestPerson.Age} years.");

            #endregion

        }
    }
    }
