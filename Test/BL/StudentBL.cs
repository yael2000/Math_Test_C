using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class StudentBL
    {
        public int StudentId;
        public bool setStudent(string name,string password)
        {
            StudentDAL dal = new StudentDAL();
            List<DAL.Student_tbl> lst = dal.getStudent();
            foreach (DAL.Student_tbl s in lst)
            {
                if (s.StudName == name && s.StudPassword == password)
                {
                    StudentId = s.StudID;
                    return true;
                }
               
            }return false;
        }
        public string ReturnName(string user)
        {
            StudentDAL dal = new StudentDAL();
            return dal.getName(user);
           
        }

    }
}
