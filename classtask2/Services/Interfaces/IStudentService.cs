using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask2.Services.Interfaces
{
    internal interface IStudentService
    {
        public void Create(string name, string surname,int avarage);
        public void Edit(int id,string name,string surname,int avarage);
        public void Delete(int id);
        public Student GetById(int id);
        public Student[] GetAll();
    }
}
