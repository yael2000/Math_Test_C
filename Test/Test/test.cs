using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class test : Form
    {

        QuesAnsBL BL = new QuesAnsBL();
        List<Questions> Question;
        List<Questions> AmericanQuestion;
        int i_American = 0;
        int i_Simple = 0;
        Questions q;
        List<Answers> AnswersList;
        int err = 0;
        public static int points = 0;
        public test()
        {
            InitializeComponent();
            Question = BL.getQuestion();
           AmericanQuestion = BL.getAmericanQuestion();
            showAmericanQuestion();
        }
        private void showSimpleQuestion()
        {
            AnswersgroupBox.Hide();
             q = Question[i_Simple];
            labelQues.Text = q.QuestionText;
            i_Simple++;
        }

        private void showAmericanQuestion()
        {
            textBoxAnsw.Hide();
             q = AmericanQuestion[i_American];
            var y = 0;
            labelQues.Text = q.QuestionText.ToString();
           AnswersList = BL.GetAnswers(q.ID);
            AnswersgroupBox.Show();
            AnswersgroupBox.Controls.Clear();
           
            foreach (var answer in AnswersList)
            {
                RadioButton newRadio = new RadioButton();
                newRadio.Text = answer.AnswerValue.ToString();
                newRadio.Font = new Font("Microsoft YaHei UI", 18);
                newRadio.Location = new Point(0, y);
                AnswersgroupBox.Controls.Add(newRadio);
                y += 30;
            }
            i_American++;
         

        }

        private void CheckAns()
        {
            if (AmericanQuestion.Count() >=i_American && i_Simple==0)
            {
                foreach (var option in AnswersgroupBox.Controls)
                {
                    if (option is RadioButton)
                    {
                        if ((option as RadioButton).Checked == true)
                        {
                            foreach (var answer in AnswersList)
                            {
                                if ((option as RadioButton).Text == answer.AnswerValue.ToString())
                                {
                                    if(answer.ID==q.QuestionAnswer)
                                    points += q.Percent.Value;

                                }
                            }
                          
                        }
                    }
                }

            }
            else
            {
                int ans;
                if (int.TryParse(textBoxAnsw.Text, out ans))
                {
                    if (q.QuestionAnswer.ToString() == textBoxAnsw.Text)
                        points += q.Percent.Value;

                }
                else err = 1;
              
               

            }
            mark.Text = points.ToString();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {

            CheckAns();
            if (err == 1)
            { 
                error.Text = "עליך להקיש ספרות";
                AnswersgroupBox.Hide();
                q = Question[i_Simple-1];
                labelQues.Text = q.QuestionText;
                err = 0;
                return;
            }
            error.Text = "";
            if (AmericanQuestion.Count() > i_American)
            {
                textBoxAnsw.Hide();
                showAmericanQuestion();
            }
            else
            {
                textBoxAnsw.Show();
                textBoxAnsw.Text = "";

                if (Question.Count() > i_Simple)
                    showSimpleQuestion();
                else
                {
                   
                    BL.EndTest(points);
                    End end = new End();
                    this.Hide();
                    end.Show();
                }
                return;
            }
        }

    }
}
