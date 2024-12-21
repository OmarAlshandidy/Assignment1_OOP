using System.Drawing;
using Session6;

namespace Common
{
    enum Grades
    {
        A, B, C, D, F
    }
    enum Gander
    {
        Male, Famale
    }
    [Flags]
    enum premission{
        Read = 8 ,
        Write = 4 , 
        Execute = 2,
        Delete  = 1
        }

    internal class Program
    {

        static void Main(string[] args)
        {
            #region What is Access Mosifiers 
            // TypeA obj = new TypeA();
            // obj.x =10; invalid 
            // obj.y =20 invalid 



            #endregion
            #region Enum 
            //Grades G = Grades.A;
            //if (G == Grades.A)
            //{
            //    Console.WriteLine("A++");
            //}
           // premission per01 = premission.Read;
           // per01 ^= premission.Delete; // Toggle 

            //per01 |= premission.Delete; // Add permession

            //Console.WriteLine(per01); // Read , Delete 
            //per01 ^= premission.Delete; // Toggle 
            //Console.WriteLine(per01); // Read 

           // Console.WriteLine(per01); // Read , Delete 
            //per01 &= ~(premission.Delete); //  ~Not Bitwise 
            // & -> check permissions
                    //if ((per01 & premission.Delete) == premission.Delete)
                    //{

                    //    Console.WriteLine("Esixts");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Not Esits ");
                    //}
            



            #endregion
            #region Struct 
            //  Point p1 = new Point(2,4);
            // Dclrae for Object from  Point 
            // clr  will allocate 8 Byte from Type " Point"
            //   Console.WriteLine(p1.X);
            // Console.WriteLine(p1.Y);

            #endregion
            #region What is OOP 

            #endregion
            #region Encapsulation 
            //Employee Emp = new Employee(93, "omar ", 2000   );
            //Console.WriteLine(Emp);
            #endregion
        }
    }
}
