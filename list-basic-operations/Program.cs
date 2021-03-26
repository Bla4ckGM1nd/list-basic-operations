using System;

namespace list_basic_operations
{
    public class Program
    {
        static void Main(string[] args)

        {
            StudentList studentList = new StudentList();

            Console.WriteLine("What code do you want to insert?");
            int insert = int.Parse(Console.ReadLine()); //crear objetio tipo entero a la cual se le entrega un WriteLine y tiene que ser de tipo entero

            Console.WriteLine("After which code do you want to put it?");
            int after = int.Parse(Console.ReadLine());

            Students s1 = new Students(); //herencia - instancia de clase
            s1.Name = "Maria";
            s1.Age = 17;
            s1.Code = 202101; 
            studentList.Add(s1, insert, after); // .Add llamar una funcion dentro de StudentList  que se llama Add y se envia el objeto S1

            Students s2 = new Students();   
            s2.Name = "Carlos";
            s2.Age = 20;
            s2.Code = 202102;
            studentList.Add(s2, insert, after);

            Students s3 = new Students();
            s3.Name = "Diana";
            s3.Age = 19;
            s3.Code = 202103;
            studentList.Add(s3, insert, after);

            Students s4 = new Students();
            s4.Name = "Kayn";
            s4.Age = 18;
            s4.Code = 202104;
            studentList.Add(s4, insert, after);

            Students s5 = new Students();
            s5.Name = "Irelia";
            s5.Age = 18;
            s5.Code = 202105;
            studentList.Add(s5, insert, after);

            Students s6 = new Students();
            s6.Name = "Darius";
            s6.Age = 18;
            s6.Code = 202106;
            studentList.Add(s6, insert, after);

            Students s7 = new Students();
            s7.Name = "Jhin";
            s7.Age = 18;
            s7.Code = 202107;
            studentList.Add(s7, insert, after);

            Students s8 = new Students();
            s8.Name = "Mordekaiser";
            s8.Age = 18;
            s8.Code = 202108;
            studentList.Add(s8, insert, after);


            studentList.Print();
        }
    }
}
