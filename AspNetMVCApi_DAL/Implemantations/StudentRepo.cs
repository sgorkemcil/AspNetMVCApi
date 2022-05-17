using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AspNetMVCApi_DAL.Contracts;
using AspNetMVCApi_EL.Models;

namespace AspNetMVCApi_DAL.Implemantations
{
    public class StudentRepo:RepositoryBase<Student,int>,IStudentRepo
    
    {
       
        public StudentRepo(MyContext myContext) : base(myContext)
        {

        }
    }
}
