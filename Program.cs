using System;
using System.Drawing;
using System.Windows.Forms;

namespace _NET_Senac_Forms_2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario());
        }
        public class Formulario : Form{
            Label lbNome;
            TextBox tbNome;
            Label lbDtNascimento;
            MaskedTextBox mtbDtNascimento;
            Label lbDiasDev;
            NumericUpDown nudDiasDev;
            PictureBox QRCode;
            public Formulario(){

                this.Text = "Exercícios";
                this.Size = new Size(300,300);
                this.MinimizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.StartPosition = FormStartPosition.CenterScreen;

                lbNome = new Label();
                lbNome.Text = "Nome";
                lbNome.Size = new Size(40,20);
                lbNome.Location = new Point(20, 20);

                tbNome = new TextBox();
                tbNome.Size = new Size(150, 10);
                tbNome.Location = new Point(20, 40);

                lbDtNascimento = new Label();
                lbDtNascimento.Text = "Data de nascimento";
                lbDtNascimento.Size = new Size(150,20);
                lbDtNascimento.Location = new Point(20, 70);

                mtbDtNascimento = new MaskedTextBox();
                mtbDtNascimento.Mask = "00/00/0000";
                mtbDtNascimento.Size = new Size(150, 10);
                mtbDtNascimento.Location = new Point(20, 90);

                lbDiasDev = new Label();
                lbDiasDev.Text = "Dias para devolução";
                lbDiasDev.Size = new Size(150, 20);
                lbDiasDev.Location = new Point(20, 120);

                nudDiasDev = new NumericUpDown();
                nudDiasDev.Minimum = 5;
                nudDiasDev.Maximum = 15;
                nudDiasDev.Size = new Size(90, 10)                    ;
                nudDiasDev.Location = new Point(20, 140);

                QRCode = new PictureBox();
                QRCode.SizeMode = PictureBoxSizeMode.StretchImage;
                QRCode.ClientSize = new Size(30,30);
                QRCode.Load("image.png");
                QRCode.Location = new Point(20, 170);

                this.Controls.Add(lbNome);
                this.Controls.Add(tbNome);
                this.Controls.Add(lbDtNascimento);
                this.Controls.Add(mtbDtNascimento);
                this.Controls.Add(lbDiasDev);
                this.Controls.Add(nudDiasDev);
                this.Controls.Add(QRCode);
            }
        }
    }
}
