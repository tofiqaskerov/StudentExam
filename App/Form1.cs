using Business;
using Entities;

namespace App
{
    public partial class Form1 : Form
    {
        ExamManager _examManager = new();
        public Form1()
        {
            InitializeComponent();
        }
        
        int currentQuestion = 0;
        int cVa = 0;
        int GroupId = 1;
        public void CheckQuestion(string choose)
        {
            var correct = _examManager.GetGroupQuestion(currentQuestion, GroupId).Question.CorrectVariant;
            if(correct == choose)
            {
                cVa++;
            }
            VariantA.Checked = true;
        }
        public void RenderQuestion(int nextQuestion = 0)
        {
            if(_examManager.GetGroupQuestion(nextQuestion, GroupId ) == null)
            {
                LblCorrect.Text = $"{nextQuestion}/{cVa.ToString()} Ugurlar";
                PnlExam.Visible = false;

            }
            else
            {
                lblQuestion.Text = _examManager.GetGroupQuestion(nextQuestion, GroupId).Question.QuestionText;
                VariantA.Text = _examManager.GetGroupQuestion(nextQuestion, GroupId).Question.VariantA;
                VariantB.Text = _examManager.GetGroupQuestion(nextQuestion, GroupId).Question.VariantB;
                VariantC.Text = _examManager.GetGroupQuestion(nextQuestion, GroupId).Question.VariantC;
                VariantD.Text = _examManager.GetGroupQuestion(nextQuestion, GroupId).Question.VariantD;
                LblCorrect.Text = cVa.ToString();
            }
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1030;
            this.Height = 652;
            this.Location = new Point(
                this.ClientSize.Width / 2,
                this.ClientSize.Height / 2
                );
            RenderQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

            var vA = VariantA;
            var vB = VariantB;
            var vC = VariantC;
            var vD = VariantD;

            if( vA.Checked ==true)
            {
                CheckQuestion(vA.Text);
            }
            if (vB.Checked == true)
            {
                CheckQuestion(vB.Text);
            }
            if (vC.Checked == true)
            {
                CheckQuestion(vC.Text);
            }
            if (vD.Checked == true)
            {
                CheckQuestion(vD.Text);
            }
            currentQuestion += 1;
            RenderQuestion(currentQuestion);
        }

        private void BtnStartQuize_Click(object sender, EventArgs e)
        {
            PnlExam.Visible = true;
            PnlStartQuiz.Visible = false;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            PnlStartQuiz.Location = new Point(
                this.ClientSize.Width / 2 - PnlStartQuiz.Width / 2,
                this.ClientSize.Height / 2 - PnlStartQuiz.Height / 2
                );
            PnlExam.Location = new Point(
                this.ClientSize.Width / 2 - PnlExam.Width / 2,
                this.ClientSize.Height / 2 - PnlExam.Height / 2
                );
            panel1.Visible = false;
        }
    }
}