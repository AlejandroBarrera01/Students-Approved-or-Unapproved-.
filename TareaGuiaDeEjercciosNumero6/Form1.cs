using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//b. arreglo bidimencional de estudiantes y asignaturas
//   1,1+ 1,2+ 1,3+ 1,4 = res / total asig = promedio por estudiante
//c. guardar estudent_average[] unidimecional, funcion mayor = 1 valor compararlo con el resto 

namespace TareaGuiaDeEjercciosNumero6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        int N;

        public struct Register
        {
            public string Name;
            public int OOP;
            public int MATH;
            public int Sociology;
            public int Science;
            public double Average;

        }
         

        Register[] Class;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                textNStudiantes.Focus();


                N = int.Parse(textNStudiantes.Text);

                Class = new Register[N];

                i = 0;

                while (i < N)
                {
                    Class[i].Name = Microsoft.VisualBasic.Interaction.InputBox("Student Name");
                    Class[i].OOP = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("What Grade # Student Got On OOP"));
                    Class[i].MATH = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("What Grade # Student Got On MATH"));
                    Class[i].Sociology = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("What Grade # Student Got On Sociology"));
                    Class[i].Science = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("What Grade # Student Got On Science "));
                    i++;
                }


                textNStudiantes.Enabled = false;
                button1.Enabled = false;
            }
            catch {};
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int Sum2 = 0;
            int Sum3 = 0;
            int Sum4 = 0;
            int Sum5 = 0;
            int Average2;
            int Average3;
            int Average4;
            int Average5;

            i = 0;
            while (i < N)
            {

                Sum2 = Sum2 + Class[i].OOP;
                Sum3 = Sum3 + Class[i].MATH;
                Sum4 = Sum4 + Class[i].Sociology;
                Sum5 = Sum5 + Class[i].Science;
                i++;

            }
            Average2 = Sum2 / N;
            Average3 = Sum3 / N;
            Average4 = Sum4 / N;
            Average5 = Sum5 / N;

            textOOP.Text = Average2.ToString();
            textMatematicaII.Text = Average3.ToString();
            textSociology.Text = Average4.ToString();
            textScience.Text = Average5.ToString();

            textOOP.Enabled = false;
            textMatematicaII.Enabled = false;
            textSociology.Enabled = false;
            textScience.Enabled = false;

        }

         

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            int CountA = 0;
            int CountA1 = 0;
            int CountA2 = 0;
            int CountA3 = 0;
            int CountR = 0;
            int CountR1 = 0;
            int CountR2 = 0;
            int CountR3 = 0;
            int AvgoopA=0;
            int avgmathA=0;
            int avegsocioA=0;
            int AveScienceA=0;
            int AvegoopR=0;
            int AvemathR=0;
            int AvesocioR=0;
            int AveScienceR=0;



            while (i<N)
            {
                if (Class[i].OOP >= 60)
                {
                    CountA = CountA + 1;
                }
                else
                {
                    CountR = CountR + 1;

                }

                if(Class[i].MATH>=60)
                {
                    CountA1 = CountA1 + 1;
                }
                else
                {
                    CountR1 = CountR1 + 1;
                }
                if(Class[i].Sociology>=60)
                {
                    CountA2 = CountA2 + 1;
                }
                else
                {
                    CountR2 = CountR2 + 1;
                }
                if(Class[i].Science>=60)
                {
                    CountA3 = CountA3 + 1;
                }
                else
                {
                    CountR3 = CountR3 + 1;
                }
                i++;


              }
            AvgoopA = CountA * 100 / N; ;
            avgmathA = CountA1 * 100 / N;
            avegsocioA = CountA2 * 100 / N;
            AveScienceA = CountA3 * 100 / N;

            AvegoopR = 100 - AvgoopA;
            AvemathR = 100 - avgmathA;
            AvesocioR = 100 - avegsocioA;
            AveScienceR = 100 - AveScienceA;

            listboxApprovedUnapproved.Items.Add("Approved on OPP "+CountA+" "+AvgoopA +"%");

            listboxApprovedUnapproved.Items.Add("Unapproved OOP " + CountR + " " + AvegoopR + "%");

            listboxApprovedUnapproved.Items.Add("Approved Math" + CountA1+" " + avgmathA + "%");

            listboxApprovedUnapproved.Items.Add("Unapproved Math" + CountR1 + " " + AvemathR + "%");

            listboxApprovedUnapproved.Items.Add("Approved Sociology" + CountA2 + " " + avegsocioA + "%");

            listboxApprovedUnapproved.Items.Add("Unapproved Sociology" + CountR2 + " " + AvesocioR + "%");

            listboxApprovedUnapproved.Items.Add("Approved Sciences " + CountA3 + " " + AveScienceA + "%");

            listboxApprovedUnapproved.Items.Add("Unapproved Sciences " + CountR3 + " " + AveScienceR + "%");


        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Greater;
            int Greater2;
            int Greater3;
            int Greater4;
            int index=0;
            int index2=0;
            int index3=0;
            int index4=0;

       Greater = Class[0].OOP;
       Greater2 = Class[0].MATH;
       Greater3 = Class[0].Sociology;
       Greater4 = Class[0].Science;

            i = 0;

            while (i < N)
            {

                if (Class[i].OOP > Greater)
                {
                    Greater = Class[i].OOP;
                    index = i;

                }


                if (Class[i].MATH > Greater2)
                {
                    Greater2 = Class[i].MATH;
                    index2 = i;

                }
 

                if (Class[i].Sociology > Greater3)
                {
                    Greater3 = Class[i].Sociology;
                    index3 = i;
                }

               
                if (Class[i].Science > Greater4)
                {
                    Greater4 = Class[i].Science;
                    index4 = i;
                }
                  i++;
            }
                textBoxOOP.Text = (Class[index].Name.ToString());
                textBoxMatematicaII.Text = (Class[index2].Name.ToString());
                textBoxSicologia.Text = (Class[index3].Name.ToString());
                textBoxScience.Text = (Class[index4].Name.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = 0;
            double best;
            while (i < N)
            {
                Class[i].Average = (Class[i].OOP + Class[i].MATH + Class[i].Sociology + Class[i].Science) / 4;

                listboxAverage.Items.Add("Average of" +' '+Class[i].Name+' '+Class[i].Average +' '+ " %");
                i++;
            }

            best = Class[0].Average;

            int Indexx=0;

            i = 1;
            while (i < N)
            {

                if (Class[i].Average > best)
                {
                    best = Class[i].Average;
                    Indexx = i;
                }
                i++;
            }
            listboxAverage.Items.Add("The best student is" + Class[Indexx].Name);

            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int i, j;
            for(i=0; i<N; i++)
            {
                for (j=0; j < N; j++)
                {
                    
                }
            }


        }

        private void textOOP_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
