using System;
using System.Collections.Generic;
using System.Text;

namespace list_basic_operations
{
    public class StudentList
    {
        public StudentNode Head; //Declarando una variable publica de tipo StudntNode (clase), el head debe llevar studnet y next
        public StudentNode objStudentNode;

        public void Add(Students studentToAdd, int insert, int after) //studentToAdd almacena la info escrita en Program, los datos, after e insert recibe como parametro de program
        {
            StudentNode newStudentNode = new StudentNode();//instancia de StudentNode, o herendando todos los atributos
            newStudentNode.Student = studentToAdd; //insercion de Student

            if (insert < after)
            { 
                if (studentToAdd.Code == insert || studentToAdd.Code == after) //si ese es igual a inert O es igual a after
                {
                    if (studentToAdd.Code == insert)
                    {
                        objStudentNode = newStudentNode; //la variable que se tiene arriba va a contener al nodo, se captura
                    }
                    else
                    {
                        if (Head == null)  //Lista vacia, nodo padre Head 
                        {
                            Head = newStudentNode;    //significa que se ha creado el primer nodo pero no tiene next 
                            StudentNode Last = Head;
                            Last = Last.Next;
                            Last.Next = objStudentNode;

                        }
                        else
                        {
                            StudentNode Last = Head;  //last va a contener un next y studentNode
                            while (Last.Next != null) // si es diferentede null inserta un nuevo nodo
                            {
                                Last = Last.Next;  //va pasando el next y si no es null pasa y pasa
                            }
                            Last.Next = newStudentNode; //inserta el sgte nodo 
                            Last = Last.Next;
                            Last.Next = objStudentNode;
                        }
                    }
                }
                else
                {
                    if (Head==null)
                    {
                        Head = newStudentNode;
                    }
                    else
                    {
                        StudentNode Last = Head;
                        while (Last.Next != null)
                        {
                            Last = Last.Next;
                        }
                        Last.Next = newStudentNode;
                    }
                }
            }
            else
            {
                if (studentToAdd.Code == insert)
                {
                    StudentNode Last = Head;

                    for (int i = 202101; i < after; i++)
                    {
                        
                        Last = Last.Next;
                        
                    }
                    StudentNode Next = Last.Next;
                    Last.Next = newStudentNode;
                    Last.Next.Next = Next;
                }
                else
                {
                    if (Head == null)
                    {
                        Head = newStudentNode;
                    }
                    else
                    {
                        StudentNode Last = Head;
                        while (Last.Next != null)
                        {
                            Last = Last.Next;
                        }
                        Last.Next = newStudentNode;

                    }
                }
            }
        }
        public void Print()
        {
            StudentNode tmp = Head; 
            while(tmp != null)
            {
                Console.WriteLine($"Name of the student: {tmp.Student.Name} - Age of the student: {tmp.Student.Age} - Code of the Student: {tmp.Student.Code}");
                tmp = tmp.Next;
            }
        }
    }
}
