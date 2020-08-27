using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL
    {
        public List<Student_tbl> getStudent()
        {
            List<Student_tbl> lst = new List<Student_tbl>();
            using (var db = new Students_Marks_SQLEntities())
            {
                lst = db.Student_tbl.ToList();
            }
            return lst;
        }
        public string getName(string user)
        {
            using (var DB = new Students_Marks_SQLEntities())
            {

                var res = DB.Student_tbl.Where(s => s.StudName == user).First().StudName;
                return res;
            }
         
        }



    }
}
