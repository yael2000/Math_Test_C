using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class QuesAnsDAL
    {
        public List<Questions> getQues()
        {
            List<Questions> lst = new List<Questions>();
            using (var db = new Students_Marks_SQLEntities())
            {
                lst = db.Questions.ToList();
            }
            return lst;
        }
        public List<Answers> getAns()
        {
            List<Answers> lst = new List<Answers>();
            using (var db = new Students_Marks_SQLEntities())
            {
                lst = db.Answers.ToList();
            }
            return lst;
        }

        public void AddTest(Marks_tbl mark)
        {
            using (var db = new Students_Marks_SQLEntities())
            {
                db.Marks_tbl.Add(mark);
                db.SaveChanges();
            }
        }

        public List<Marks_tbl> GetMarks()
        {
            List<Marks_tbl> lst = new List<Marks_tbl>();
            using (var db = new Students_Marks_SQLEntities())
                lst = db.Marks_tbl.ToList();
            return (lst);

            
        }
    }
}
