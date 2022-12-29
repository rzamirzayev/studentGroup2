using classtask2.Models;
using classtask2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace classtask2.Services.Implementations
{
    internal class StudentService : IStudentService
    {
        Group group=new Group();
        public void Create(string name, string surname, int avarage)
        {
            Student student = new Student
            {
                Name = name,
                SurName = surname,
                Avarage = avarage
            };
            Array.Resize(ref group.Students, group.Students.Length + 1);

            group.Students[group.Students.Length - 1] = student;


            
        }

        public void Delete(int id)
        {

            //int index=Array.IndexOf(group.Students, id);
            //if (index == -1)
            //{
            //    Console.WriteLine("bu id-de telebe yoxdur");
            //}
            //else
            //{
            //    group.Students[index] = group.Students[group.Students.Length - 1];
            //    Array.Resize(ref group.Students, group.Students.Length - 1);
            //}
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    group.Students[i] = group.Students[group.Students.Length - 1];
                    Array.Resize(ref group.Students, group.Students.Length - 1);
                    return;
                }
            }
            Console.WriteLine("bu id student yoxdur.");
        }

        public void Edit(int id, string name, string surname, int avarage)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    group.Students[i].Name = name;
                    group.Students[i].SurName= surname;
                    group.Students[i].Avarage= avarage;
                    return;
                }
            }
            Console.WriteLine("bu id student yoxdur.");
        }

        public Student[] GetAll()
        {
           return group.Students;
        }

       
    }
}
