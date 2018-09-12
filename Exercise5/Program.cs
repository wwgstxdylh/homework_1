using System;
using System.Windows.Forms;
using System.Drawing;

    public class Exercise:Form
    {
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Label lbl = new Label();
        Button btn = new Button();

        public void init()
        {
            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(lbl);
            this.Controls.Add(btn);
            txt1.Dock = System.Windows.Forms.DockStyle.Left;
            txt2.Dock = System.Windows.Forms.DockStyle.Right;
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.Text = "求积";
            lbl.Text = "用于显示结果的标签";
            this.Size = new Size(500, 500);

            btn.Click += new System.EventHandler(this.button1_Click);

        }
        void button1_Click(object sender, EventArgs e)
        {
            string s1 = txt1.Text;
            double a = double.Parse(s1);
            string s2 = txt2.Text;
            double b = double.Parse(s2);
            double product = a * b;
            lbl.Text = a + "和" + b + "的乘积是" + product;

        }
        static void Main()
        {
            Exercise f = new Exercise();
            f.Text = "Form1";
            f.init();
            Application.Run(f);
        }

     
    }

