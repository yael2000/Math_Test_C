using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class QuesAnsBL
    {
        QuesAnsDAL DAL = new QuesAnsDAL();
        public List<Questions> partA = new List<Questions>();
        public List<Questions> partB = new List<Questions>();
        public List<Questions> American = new List<Questions>();
        public List<Questions> getQuestion()
        { 
            List<Questions> lst = DAL.getQues();
            partA = lst.Take(5)
               .Select(x => new Questions { ID = x.ID, QuestionText = x.QuestionText, QuestionAnswer = x.QuestionAnswer, Percent = x.Percent })
               .OrderBy(x => Guid.NewGuid())
               .Where(x => x.Percent == 6).ToList();
            partB = lst
                .Select(x => new Questions { ID = x.ID, QuestionText = x.QuestionText, QuestionAnswer = x.QuestionAnswer, Percent = x.Percent })
          .Where(x => x.Percent == 10).Take(4).
          OrderBy(x => Guid.NewGuid())
          .ToList();

            partA.AddRange(partB);
            return partA;
        }

        public List<Questions> getAmericanQuestion()
        {
            List<Questions> lst = DAL.getQues();
            American = lst
                .Select(x => new Questions { ID = x.ID, QuestionText = x.QuestionText, QuestionAnswer = x.QuestionAnswer, Percent = x.Percent })
          .Where(x => x.Percent == 5).Take(6).
          OrderBy(x => Guid.NewGuid())
          .ToList();
            return American;
        }

        public List<Answers> GetAnswers(int id)
        {
            List<Answers> AnswersList = DAL.getAns();
            List<Answers>option= AnswersList.Where(item => item.QuestionID ==id ).OrderBy(item => Guid.NewGuid()).ToList();
            return option;
        }
        public void EndTest(int points)
        { StudentBL st = new StudentBL();
            Marks_tbl addMark = new Marks_tbl();
            addMark.Mark = points;
            addMark.StudID = st.StudentId;
            addMark.TestDate = DateTime.Now;

            DAL.AddTest(addMark);



        }
        public List<Marks_tbl> getmarks()
        {
            List<Marks_tbl> marks = DAL.GetMarks();
            return marks;
        }


    }
}
