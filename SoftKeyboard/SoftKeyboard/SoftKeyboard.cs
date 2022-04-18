using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SoftKeyboard
{
    public class SoftKeyboard9 : Form
    {
        //显示InputBox
        public static bool Show(string Title, ref string rettext)
        {
            SoftKeyboard9 inputbox = new SoftKeyboard9();
            inputbox.Text = Title;
            inputbox.ShowDialog();
            rettext = inputbox.inputText.Text;
            if (rettext.Length > 0)
                return inputbox.OKorCancel;
            else
                return false;
        }

        private bool OKorCancel = true;

        public SoftKeyboard9()
        {
            InitializeComponent();
        }

        private void ConsoleWriteLine(string str) { }

        private void common_Click(object sender, EventArgs e)
        {
            try
            {
                string str = ((Button)sender).Name;
                str = "" + str[str.Length - 1];
                inputText.Text += str;
            }
            catch { }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            inputText.Text += ".";
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (inputText.Text.Length > 0)
            {
                try
                {
                    inputText.Text = inputText.Text.Substring(0, inputText.Text.Length - 1);
                }
                catch { }
            }
        }

        private void buttonCOMPELET_Click(object sender, EventArgs e)
        {
            OKorCancel = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            inputText.Text = "";
            OKorCancel = false;
            this.Close();
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double val = Convert.ToDouble(inputText.Text);
                buttonCOMPELET.Enabled = true;
                buttonCOMPELET.BackgroundImage = SoftKeyboard.Properties.Resources.完成_标准;
            }
            catch
            {
                buttonCOMPELET.Enabled = false;
                buttonCOMPELET.BackgroundImage = SoftKeyboard.Properties.Resources.完成_激活;
            }
        }

        #region 每个按钮的按下弹起动画
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button1_MouseDown");
                button1.BackgroundImage = SoftKeyboard.Properties.Resources._1_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button1_MouseUp");
                button1.BackgroundImage = SoftKeyboard.Properties.Resources._1_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button2_MouseDown");
                button2.BackgroundImage = SoftKeyboard.Properties.Resources._2_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button1_MouseUp");
                button2.BackgroundImage = SoftKeyboard.Properties.Resources._2_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button3_MouseDown");
                button3.BackgroundImage = SoftKeyboard.Properties.Resources._3_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button3_MouseUp");
                button3.BackgroundImage = SoftKeyboard.Properties.Resources._3_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button4_MouseDown");
                button4.BackgroundImage = SoftKeyboard.Properties.Resources._4_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button4_MouseUp");
                button4.BackgroundImage = SoftKeyboard.Properties.Resources._4_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button5_MouseDown");
                button5.BackgroundImage = SoftKeyboard.Properties.Resources._5_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button5_MouseUp");
                button5.BackgroundImage = SoftKeyboard.Properties.Resources._5_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button6_MouseDown");
                button6.BackgroundImage = SoftKeyboard.Properties.Resources._6_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button6_MouseUp");
                button6.BackgroundImage = SoftKeyboard.Properties.Resources._6_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button7_MouseDown");
                button7.BackgroundImage = SoftKeyboard.Properties.Resources._7_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button7_MouseUp");
                button7.BackgroundImage = SoftKeyboard.Properties.Resources._7_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button8_MouseDown");
                button8.BackgroundImage = SoftKeyboard.Properties.Resources._8_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button8_MouseUp");
                button8.BackgroundImage = SoftKeyboard.Properties.Resources._8_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button9_MouseDown");
                button9.BackgroundImage = SoftKeyboard.Properties.Resources._9_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button9_MouseUp");
                button9.BackgroundImage = SoftKeyboard.Properties.Resources._9_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button0_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button0_MouseDown");
                button0.BackgroundImage = SoftKeyboard.Properties.Resources._0w_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
             
        }

        private void button0_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button0_MouseUp");
                button0.BackgroundImage = SoftKeyboard.Properties.Resources._0w_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDEL_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDEL_MouseDown");
                buttonDEL.BackgroundImage = SoftKeyboard.Properties.Resources.删p ;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDEL_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDEL_MouseUp");
                buttonDEL.BackgroundImage = SoftKeyboard.Properties.Resources.删 ;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCOMPELET_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCOMPELET_MouseDown");
                buttonCOMPELET.BackgroundImage = SoftKeyboard.Properties.Resources.完成_激活 ;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCOMPELET_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCOMPELET_MouseUp");
                buttonCOMPELET.BackgroundImage = SoftKeyboard.Properties.Resources.完成_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCancel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCancel_MouseDown");
                buttonCancel.BackgroundImage = SoftKeyboard.Properties.Resources.取消_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCancel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCancel_MouseUp");
                buttonCancel.BackgroundImage = SoftKeyboard.Properties.Resources.取消_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDecimal_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDecimal_MouseDown");
                buttonDecimal.BackgroundImage = SoftKeyboard.Properties.Resources.点_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDecimal_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDecimal_MouseUp");
                buttonDecimal.BackgroundImage = SoftKeyboard.Properties.Resources.点_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }



        private void buttonCOMPELET1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCOMPELET1_MouseDown");
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCOMPELET1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCOMPELET1_MouseUp");
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }
#endregion

        #region 每个按钮绘制圆角边
        private void buttonCOMPELET_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonCOMPELET.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonCOMPELET.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCancel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonCancel.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonCancel.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDEL_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonDEL.ClientRectangle;
                newRectangle.Inflate(0, 0);

                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonDEL.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }


        private void button1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button1.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button1.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button2.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button2.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button3.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button3.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button4.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button4.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button5.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button5.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button6.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button6.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button7_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button7.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button7.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button8_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button8.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button8.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button9_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button9.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button9.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button0_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button0.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button0.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        internal static GraphicsPath CreateRoundedRectanglePath(Rectangle rect)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            try
            {
                int cornerRadius = 13;
                roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
                roundedRect.AddLine(rect.X + cornerRadius * 2, rect.Y + 1, rect.Right - cornerRadius * 2, rect.Y + 1);
                roundedRect.AddArc(rect.Right - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
                roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Bottom - cornerRadius * 2);
                roundedRect.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
                roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                roundedRect.AddLine(rect.X + 1, rect.Bottom - cornerRadius * 2, rect.X + 1, rect.Y + cornerRadius * 2);
                roundedRect.CloseFigure();
            }
            catch (Exception err)
            {
            }
            return roundedRect;
        }

        private void buttonDecimal_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonDecimal.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonDecimal.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }
        #endregion

        

        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCOMPELET = new System.Windows.Forms.Button();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackgroundImage = global::SoftKeyboard.Properties.Resources.点_标准;
            this.buttonDecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDecimal.Location = new System.Drawing.Point(296, 549);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(120, 120);
            this.buttonDecimal.TabIndex = 59;
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDecimal_Click);
            this.buttonDecimal.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonDecimal_Paint);
            this.buttonDecimal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDecimal_MouseDown);
            this.buttonDecimal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDecimal_MouseUp);
            // 
            // button0
            // 
            this.button0.BackgroundImage = global::SoftKeyboard.Properties.Resources._0w_数字标准;
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button0.Location = new System.Drawing.Point(12, 549);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(226, 120);
            this.button0.TabIndex = 56;
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.common_Click);
            this.button0.Paint += new System.Windows.Forms.PaintEventHandler(this.button0_Paint);
            this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button0_MouseDown);
            this.button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button0_MouseUp);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::SoftKeyboard.Properties.Resources._9_数字标准;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Location = new System.Drawing.Point(296, 139);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 120);
            this.button9.TabIndex = 55;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.common_Click);
            this.button9.Paint += new System.Windows.Forms.PaintEventHandler(this.button9_Paint);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button9_MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button9_MouseUp);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::SoftKeyboard.Properties.Resources._8_数字标准;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Location = new System.Drawing.Point(155, 139);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 120);
            this.button8.TabIndex = 54;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.common_Click);
            this.button8.Paint += new System.Windows.Forms.PaintEventHandler(this.button8_Paint);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button8_MouseUp);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::SoftKeyboard.Properties.Resources._7_数字标准;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(12, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 120);
            this.button7.TabIndex = 53;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.common_Click);
            this.button7.Paint += new System.Windows.Forms.PaintEventHandler(this.button7_Paint);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button7_MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button7_MouseUp);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::SoftKeyboard.Properties.Resources._6_数字标准;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(296, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 120);
            this.button6.TabIndex = 46;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.common_Click);
            this.button6.Paint += new System.Windows.Forms.PaintEventHandler(this.button6_Paint);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::SoftKeyboard.Properties.Resources._5_数字标准;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(155, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 120);
            this.button5.TabIndex = 45;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.common_Click);
            this.button5.Paint += new System.Windows.Forms.PaintEventHandler(this.button5_Paint);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SoftKeyboard.Properties.Resources._4_数字标准;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(12, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 120);
            this.button4.TabIndex = 44;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.common_Click);
            this.button4.Paint += new System.Windows.Forms.PaintEventHandler(this.button4_Paint);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SoftKeyboard.Properties.Resources._3_数字标准;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(296, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 120);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.common_Click);
            this.button3.Paint += new System.Windows.Forms.PaintEventHandler(this.button3_Paint);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SoftKeyboard.Properties.Resources._2_数字标准;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(155, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 120);
            this.button2.TabIndex = 42;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.common_Click);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SoftKeyboard.Properties.Resources._1_数字标准;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 120);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.common_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // buttonCOMPELET
            // 
            this.buttonCOMPELET.BackColor = System.Drawing.Color.Transparent;
            this.buttonCOMPELET.BackgroundImage = global::SoftKeyboard.Properties.Resources.完成_激活;
            this.buttonCOMPELET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCOMPELET.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCOMPELET.Location = new System.Drawing.Point(440, 549);
            this.buttonCOMPELET.Name = "buttonCOMPELET";
            this.buttonCOMPELET.Size = new System.Drawing.Size(184, 119);
            this.buttonCOMPELET.TabIndex = 21;
            this.buttonCOMPELET.UseVisualStyleBackColor = false;
            this.buttonCOMPELET.Click += new System.EventHandler(this.buttonCOMPELET_Click);
            this.buttonCOMPELET.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCOMPELET_Paint);
            this.buttonCOMPELET.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCOMPELET_MouseDown);
            this.buttonCOMPELET.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonCOMPELET_MouseUp);
            // 
            // buttonDEL
            // 
            this.buttonDEL.BackColor = System.Drawing.Color.Transparent;
            this.buttonDEL.BackgroundImage = global::SoftKeyboard.Properties.Resources.删;
            this.buttonDEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDEL.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDEL.Location = new System.Drawing.Point(440, 139);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(184, 119);
            this.buttonDEL.TabIndex = 16;
            this.buttonDEL.UseVisualStyleBackColor = false;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            this.buttonDEL.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonDEL_Paint);
            this.buttonDEL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDEL_MouseDown);
            this.buttonDEL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDEL_MouseUp);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BackgroundImage = global::SoftKeyboard.Properties.Resources.取消_标准;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(440, 409);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(184, 119);
            this.buttonCancel.TabIndex = 41;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCancel_Paint);
            this.buttonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseDown);
            this.buttonCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseUp);
            // 
            // inputText
            // 
            this.inputText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inputText.Font = new System.Drawing.Font("黑体", 55F);
            this.inputText.Location = new System.Drawing.Point(12, 12);
            this.inputText.Name = "inputText";
            this.inputText.ReadOnly = true;
            this.inputText.Size = new System.Drawing.Size(612, 112);
            this.inputText.TabIndex = 44;
            this.inputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // SoftKeyboard9
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(639, 686);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonCOMPELET);
            this.Controls.Add(this.buttonDEL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(75, 0);
            this.Name = "SoftKeyboard9";
            this.Text = "请输入数字";
            this.ControlBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCOMPELET;
        private System.Windows.Forms.Button buttonDEL;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox inputText;
        
    }
    
    
    
    
    
    
    
    public class SoftKeyboard26 : Form
    {
        private bool bCapaLock = true;
        private bool is数字符号激活 = false;
        private bool OKorCancel = true;


        public static bool Show(string Title, ref string rettext)  //显示InputBox
        {
            SoftKeyboard26 inputbox = new SoftKeyboard26();
            inputbox.Text = Title;
            inputbox.ShowDialog();
            rettext = inputbox.inputText.Text;
            if (rettext.Length > 0)
                return inputbox.OKorCancel;
            else
                return false;
        }

        public SoftKeyboard26()
        {
            InitializeComponent();
        }

        private void ConsoleWriteLine(string str) { }

        private void addToCursor(string str)
        {
            inputText.SelectedText = str;
            InputTextCursorRe();
        }

        private void InputTextCursorRe()
        {
            int selstart = inputText.SelectionStart;
            int sellen = inputText.SelectionLength;
            inputText.Focus();
            try
            {
                inputText.SelectionStart = selstart;
            }
            catch { }
            try
            {
                inputText.SelectionLength = sellen;
            }
            catch { }
        }

        #region 字母数字按键点击事件
        private void common_Click(object sender, EventArgs e)
        {
            try
            {
                string str = ((Button)sender).Name;
                str = "" + str[str.Length - 1];
                if (bCapaLock)
                    addToCursor(str);
                else
                    addToCursor(str.ToLower());
            }
            catch { }
        }
        #endregion

        #region 符号按键点击事件
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            addToCursor(".");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

            addToCursor("/");
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            addToCursor(" ");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            addToCursor("-");
        }

        private void buttonSHIFT2_Click(object sender, EventArgs e)
        {
            addToCursor("@");
        }

        private void buttonSHIFT7_Click(object sender, EventArgs e)
        {
            addToCursor("&");
        }

        private void buttoncomma_Click(object sender, EventArgs e)
        {
            addToCursor(",");
        }

        private void buttonSHIFT3_Click(object sender, EventArgs e)
        {
            addToCursor("#");
        }

        private void buttonSHIFT9_Click(object sender, EventArgs e)
        {
            addToCursor("(");
        }

        private void buttonSHIFT0_Click(object sender, EventArgs e)
        {
            addToCursor(")");
        }
        #endregion

        #region 光标调整，删除按键被按下
        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (inputText.SelectionLength > 0)
                inputText.SelectedText = "";
            else if (inputText.SelectionStart > 0)
            {
                int selstarttmp = inputText.SelectionStart;
                inputText.Text = inputText.Text.Remove(inputText.SelectionStart - 1, 1);
                try { inputText.SelectionStart = selstarttmp - 1; }
                catch { }
            }
            InputTextCursorRe();
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (inputText.SelectionLength > 0)
                inputText.SelectionLength = 0;
            else if (inputText.SelectionStart > 0)
                inputText.SelectionStart--;
            InputTextCursorRe();
        }
        private void buttonRigth_Click(object sender, EventArgs e)
        {
            if (inputText.SelectionLength > 0)
            {
                inputText.SelectionStart += inputText.SelectionLength;
                inputText.SelectionLength = 0;
            }
            else if (inputText.SelectionStart < inputText.TextLength)
                inputText.SelectionStart++;
            InputTextCursorRe();
        }
        #endregion
        #region 模式切换
        #region 切换大小写
        private void buttonLOCK_Click(object sender, EventArgs e)
        {
            if (bCapaLock)
            {
                buttonA.BackgroundImage = SoftKeyboard.Properties.Resources.a_小写标准;
                buttonB.BackgroundImage = SoftKeyboard.Properties.Resources.b_小写标准;
                buttonC.BackgroundImage = SoftKeyboard.Properties.Resources.c_小写标准;
                buttonD.BackgroundImage = SoftKeyboard.Properties.Resources.d_小写标准;
                buttonE.BackgroundImage = SoftKeyboard.Properties.Resources.e_小写标准;
                buttonF.BackgroundImage = SoftKeyboard.Properties.Resources.f_小写标准;
                buttonG.BackgroundImage = SoftKeyboard.Properties.Resources.g_小写标准;
                buttonH.BackgroundImage = SoftKeyboard.Properties.Resources.h_小写标准;
                buttonI.BackgroundImage = SoftKeyboard.Properties.Resources.i_小写标准;
                buttonJ.BackgroundImage = SoftKeyboard.Properties.Resources.j_小写标准;
                buttonK.BackgroundImage = SoftKeyboard.Properties.Resources.k_小写标准;
                buttonL.BackgroundImage = SoftKeyboard.Properties.Resources.l_小写标准;
                buttonM.BackgroundImage = SoftKeyboard.Properties.Resources.m_小写标准;
                buttonN.BackgroundImage = SoftKeyboard.Properties.Resources.n_小写标准;
                buttonO.BackgroundImage = SoftKeyboard.Properties.Resources.o_小写标准;
                buttonP.BackgroundImage = SoftKeyboard.Properties.Resources.p_小写标准;
                buttonQ.BackgroundImage = SoftKeyboard.Properties.Resources.q_小写标准;
                buttonR.BackgroundImage = SoftKeyboard.Properties.Resources.r_小写标准;
                buttonS.BackgroundImage = SoftKeyboard.Properties.Resources.s_小写标准;
                buttonT.BackgroundImage = SoftKeyboard.Properties.Resources.t_小写标准;
                buttonU.BackgroundImage = SoftKeyboard.Properties.Resources.u_小写标准;
                buttonV.BackgroundImage = SoftKeyboard.Properties.Resources.v_小写标准;
                buttonW.BackgroundImage = SoftKeyboard.Properties.Resources.w_小写标准;
                buttonX.BackgroundImage = SoftKeyboard.Properties.Resources.x_小写标准;
                buttonY.BackgroundImage = SoftKeyboard.Properties.Resources.y_小写标准;
                buttonZ.BackgroundImage = SoftKeyboard.Properties.Resources.z_小写标准;
            }
            else
            {
                buttonA.BackgroundImage = SoftKeyboard.Properties.Resources.A_大写标准;
                buttonB.BackgroundImage = SoftKeyboard.Properties.Resources.B_大写标准;
                buttonC.BackgroundImage = SoftKeyboard.Properties.Resources.C_大写标准;
                buttonD.BackgroundImage = SoftKeyboard.Properties.Resources.D_大写标准;
                buttonE.BackgroundImage = SoftKeyboard.Properties.Resources.E_大写标准;
                buttonF.BackgroundImage = SoftKeyboard.Properties.Resources.F_大写标准;
                buttonG.BackgroundImage = SoftKeyboard.Properties.Resources.G_大写标准;
                buttonH.BackgroundImage = SoftKeyboard.Properties.Resources.H_大写标准;
                buttonI.BackgroundImage = SoftKeyboard.Properties.Resources.I_大写标准;
                buttonJ.BackgroundImage = SoftKeyboard.Properties.Resources.J_大写标准;
                buttonK.BackgroundImage = SoftKeyboard.Properties.Resources.K_大写标准;
                buttonL.BackgroundImage = SoftKeyboard.Properties.Resources.L_大写标准;
                buttonM.BackgroundImage = SoftKeyboard.Properties.Resources.M_大写标准;
                buttonN.BackgroundImage = SoftKeyboard.Properties.Resources.N_大写标准;
                buttonO.BackgroundImage = SoftKeyboard.Properties.Resources.O_大写标准;
                buttonP.BackgroundImage = SoftKeyboard.Properties.Resources.P_大写标准;
                buttonQ.BackgroundImage = SoftKeyboard.Properties.Resources.Q_大写标准;
                buttonR.BackgroundImage = SoftKeyboard.Properties.Resources.R_大写标准;
                buttonS.BackgroundImage = SoftKeyboard.Properties.Resources.S_大写标准;
                buttonT.BackgroundImage = SoftKeyboard.Properties.Resources.T_大写标准;
                buttonU.BackgroundImage = SoftKeyboard.Properties.Resources.U_大写标准;
                buttonV.BackgroundImage = SoftKeyboard.Properties.Resources.V_大写标准;
                buttonW.BackgroundImage = SoftKeyboard.Properties.Resources.W_大写标准;
                buttonX.BackgroundImage = SoftKeyboard.Properties.Resources.X_大写标准;
                buttonY.BackgroundImage = SoftKeyboard.Properties.Resources.Y_大写标准;
                buttonZ.BackgroundImage = SoftKeyboard.Properties.Resources.Z_大写标准;
            }
            bCapaLock = !bCapaLock;
            InputTextCursorRe();
        }
        #endregion
        #region 切换字母/数字符号
        private void button28_Click(object sender, EventArgs e)
        {
            panel1.Visible = !is数字符号激活;
            panel3.Visible = is数字符号激活;
            try
            {
                if (!is数字符号激活)
                    button28.BackgroundImage = SoftKeyboard.Properties.Resources.数字符号_激活;
                else
                    button28.BackgroundImage = SoftKeyboard.Properties.Resources.数字符号_标准;
            }
            catch
            {
            }
            is数字符号激活 = !is数字符号激活;
            InputTextCursorRe();
        }
        #endregion
        #endregion

        #region 确定、取消
        private void buttonCOMPELET_Click(object sender, EventArgs e)
        {
            OKorCancel = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            inputText.Text = "";
            OKorCancel = false;
            this.Close();
        }
        #endregion

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            if (inputText.TextLength > 0)
            {
                buttonCOMPELET.Enabled = true;
                buttonCOMPELET.BackgroundImage = SoftKeyboard.Properties.Resources.完成_标准;
            }
            else
            {
                buttonCOMPELET.Enabled = false;
                buttonCOMPELET.BackgroundImage = SoftKeyboard.Properties.Resources.完成_激活;
            }
        }


        #region 按键的按下弹起视觉效果
        private void buttonA_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonA.BackgroundImage = SoftKeyboard.Properties.Resources.A_大写激活;
                }
                else
                {
                    buttonA.BackgroundImage = SoftKeyboard.Properties.Resources.a_小写激活;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void buttonA_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonA.BackgroundImage = SoftKeyboard.Properties.Resources.A_大写标准;
                }
                else
                {
                    buttonA.BackgroundImage = SoftKeyboard.Properties.Resources.a_小写标准;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void buttonB_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonB.BackgroundImage = SoftKeyboard.Properties.Resources.B_大写激活;
                }
                else
                {
                    buttonB.BackgroundImage = SoftKeyboard.Properties.Resources.b_小写激活;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void buttonB_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonB.BackgroundImage = SoftKeyboard.Properties.Resources.B_大写标准;
                }
                else
                {
                    buttonB.BackgroundImage = SoftKeyboard.Properties.Resources.b_小写标准;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void buttonC_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonC.BackgroundImage = SoftKeyboard.Properties.Resources.C_大写标准;
                }
                else
                {
                    buttonC.BackgroundImage = SoftKeyboard.Properties.Resources.c_小写标准;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void buttonC_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonC.BackgroundImage = SoftKeyboard.Properties.Resources.C_大写激活;
                }
                else
                {
                    buttonC.BackgroundImage = SoftKeyboard.Properties.Resources.c_小写激活;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void buttonD_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonD.BackgroundImage = SoftKeyboard.Properties.Resources.D_大写激活;
                }
                else
                {
                    buttonD.BackgroundImage = SoftKeyboard.Properties.Resources.d_小写激活;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void buttonD_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonD.BackgroundImage = SoftKeyboard.Properties.Resources.D_大写标准;
                }
                else
                {
                    buttonD.BackgroundImage = SoftKeyboard.Properties.Resources.d_小写标准;
                }
            }
            catch (Exception err)
            {
            }
        }

        private void buttonE_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonE_MouseDown");
                if (bCapaLock)
                {
                    buttonE.BackgroundImage = SoftKeyboard.Properties.Resources.E_大写激活;
                }
                else
                {
                    buttonE.BackgroundImage = SoftKeyboard.Properties.Resources.e_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonE_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonE_MouseUp");
                if (bCapaLock)
                {
                    buttonE.BackgroundImage = SoftKeyboard.Properties.Resources.E_大写标准;
                }
                else
                {
                    buttonE.BackgroundImage = SoftKeyboard.Properties.Resources.e_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonF_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonF_MouseDown");
                if (bCapaLock)
                {
                    buttonF.BackgroundImage = SoftKeyboard.Properties.Resources.F_大写激活;
                }
                else
                {
                    buttonF.BackgroundImage = SoftKeyboard.Properties.Resources.f_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonF_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonF_MouseUp");
                if (bCapaLock)
                {
                    buttonF.BackgroundImage = SoftKeyboard.Properties.Resources.F_大写标准;
                }
                else
                {
                    buttonF.BackgroundImage = SoftKeyboard.Properties.Resources.f_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonG_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonG_MouseDown");
                if (bCapaLock)
                {
                    buttonG.BackgroundImage = SoftKeyboard.Properties.Resources.G_大写激活;
                }
                else
                {
                    buttonG.BackgroundImage = SoftKeyboard.Properties.Resources.g_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonG_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonG_MouseUp");
                if (bCapaLock)
                {
                    buttonG.BackgroundImage = SoftKeyboard.Properties.Resources.G_大写标准;
                }
                else
                {
                    buttonG.BackgroundImage = SoftKeyboard.Properties.Resources.g_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonH_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonH_MouseDown");
                if (bCapaLock)
                {
                    buttonH.BackgroundImage = SoftKeyboard.Properties.Resources.H_大写激活;
                }
                else
                {
                    buttonH.BackgroundImage = SoftKeyboard.Properties.Resources.h_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonH_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonH_MouseUp");
                if (bCapaLock)
                {
                    buttonH.BackgroundImage = SoftKeyboard.Properties.Resources.H_大写标准;
                }
                else
                {
                    buttonH.BackgroundImage = SoftKeyboard.Properties.Resources.h_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonI_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonI_MouseDown");
                if (bCapaLock)
                {
                    buttonI.BackgroundImage = SoftKeyboard.Properties.Resources.I_大写激活;
                }
                else
                {
                    buttonI.BackgroundImage = SoftKeyboard.Properties.Resources.i_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonI_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonI_MouseUp");
                if (bCapaLock)
                {
                    buttonI.BackgroundImage = SoftKeyboard.Properties.Resources.I_大写标准;
                }
                else
                {
                    buttonI.BackgroundImage = SoftKeyboard.Properties.Resources.i_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonJ_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonJ_MouseDown");
                if (bCapaLock)
                {
                    buttonJ.BackgroundImage = SoftKeyboard.Properties.Resources.J_大写激活;
                }
                else
                {
                    buttonJ.BackgroundImage = SoftKeyboard.Properties.Resources.j_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonJ_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonJ_MouseUp");
                if (bCapaLock)
                {
                    buttonJ.BackgroundImage = SoftKeyboard.Properties.Resources.J_大写标准;
                }
                else
                {
                    buttonJ.BackgroundImage = SoftKeyboard.Properties.Resources.j_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonK_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonK_MouseDown");
                if (bCapaLock)
                {
                    buttonK.BackgroundImage = SoftKeyboard.Properties.Resources.K_大写激活;
                }
                else
                {
                    buttonK.BackgroundImage = SoftKeyboard.Properties.Resources.k_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonK_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonKMouseUp");
                if (bCapaLock)
                {
                    buttonK.BackgroundImage = SoftKeyboard.Properties.Resources.K_大写标准;
                }
                else
                {
                    buttonK.BackgroundImage = SoftKeyboard.Properties.Resources.k_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonL_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonL_MouseDown");
                if (bCapaLock)
                {
                    buttonL.BackgroundImage = SoftKeyboard.Properties.Resources.L_大写激活;
                }
                else
                {
                    buttonL.BackgroundImage = SoftKeyboard.Properties.Resources.l_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonL_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonL_MouseUp");
                if (bCapaLock)
                {
                    buttonL.BackgroundImage = SoftKeyboard.Properties.Resources.L_大写标准;
                }
                else
                {
                    buttonL.BackgroundImage = SoftKeyboard.Properties.Resources.l_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonM_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonM_MouseDown");
                if (bCapaLock)
                {
                    buttonM.BackgroundImage = SoftKeyboard.Properties.Resources.M_大写激活;
                }
                else
                {
                    buttonM.BackgroundImage = SoftKeyboard.Properties.Resources.m_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonM_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonM_MouseUp");
                if (bCapaLock)
                {
                    buttonM.BackgroundImage = SoftKeyboard.Properties.Resources.M_大写标准;
                }
                else
                {
                    buttonM.BackgroundImage = SoftKeyboard.Properties.Resources.m_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonN_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonN_MouseDown");
                if (bCapaLock)
                {
                    buttonN.BackgroundImage = SoftKeyboard.Properties.Resources.N_大写激活;
                }
                else
                {
                    buttonN.BackgroundImage = SoftKeyboard.Properties.Resources.n_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonN_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonN_MouseUp");
                if (bCapaLock)
                {
                    buttonN.BackgroundImage = SoftKeyboard.Properties.Resources.N_大写标准;
                }
                else
                {
                    buttonN.BackgroundImage = SoftKeyboard.Properties.Resources.n_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonO_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonO_MouseDown");
                if (bCapaLock)
                {
                    buttonO.BackgroundImage = SoftKeyboard.Properties.Resources.O_大写激活;
                }
                else
                {
                    buttonO.BackgroundImage = SoftKeyboard.Properties.Resources.o_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonO_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonO_MouseUp");
                if (bCapaLock)
                {
                    buttonO.BackgroundImage = SoftKeyboard.Properties.Resources.O_大写标准;
                }
                else
                {
                    buttonO.BackgroundImage = SoftKeyboard.Properties.Resources.o_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonP_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonP_MouseDown");
                if (bCapaLock)
                {
                    buttonP.BackgroundImage = SoftKeyboard.Properties.Resources.P_大写激活;
                }
                else
                {
                    buttonP.BackgroundImage = SoftKeyboard.Properties.Resources.p_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonP_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonP_MouseUp");
                if (bCapaLock)
                {
                    buttonP.BackgroundImage = SoftKeyboard.Properties.Resources.P_大写标准;
                }
                else
                {
                    buttonP.BackgroundImage = SoftKeyboard.Properties.Resources.p_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonQ_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonQ_MouseUp");
                if (bCapaLock)
                {
                    buttonQ.BackgroundImage = SoftKeyboard.Properties.Resources.Q_大写标准;
                }
                else
                {
                    buttonQ.BackgroundImage = SoftKeyboard.Properties.Resources.q_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonQ_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonQ_MouseDown");
                if (bCapaLock)
                {
                    buttonQ.BackgroundImage = SoftKeyboard.Properties.Resources.Q_大写激活;
                }
                else
                {
                    buttonQ.BackgroundImage = SoftKeyboard.Properties.Resources.q_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonR_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonR_MouseUp");
                if (bCapaLock)
                {
                    buttonR.BackgroundImage = SoftKeyboard.Properties.Resources.R_大写标准;
                }
                else
                {
                    buttonR.BackgroundImage = SoftKeyboard.Properties.Resources.r_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonR_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonR_MouseDown");
                if (bCapaLock)
                {
                    buttonR.BackgroundImage = SoftKeyboard.Properties.Resources.R_大写激活;
                }
                else
                {
                    buttonR.BackgroundImage = SoftKeyboard.Properties.Resources.r_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonS_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonS_MouseDown");
                if (bCapaLock)
                {
                    buttonS.BackgroundImage = SoftKeyboard.Properties.Resources.S_大写激活;
                }
                else
                {
                    buttonS.BackgroundImage = SoftKeyboard.Properties.Resources.s_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonS_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonS_MouseUp");
                if (bCapaLock)
                {
                    buttonS.BackgroundImage = SoftKeyboard.Properties.Resources.S_大写标准;
                }
                else
                {
                    buttonS.BackgroundImage = SoftKeyboard.Properties.Resources.s_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonT_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonT_MouseDown");
                if (bCapaLock)
                {
                    buttonT.BackgroundImage = SoftKeyboard.Properties.Resources.T_大写激活;
                }
                else
                {
                    buttonT.BackgroundImage = SoftKeyboard.Properties.Resources.t_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonT_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonT_MouseUp");
                if (bCapaLock)
                {
                    buttonT.BackgroundImage = SoftKeyboard.Properties.Resources.T_大写标准;
                }
                else
                {
                    buttonT.BackgroundImage = SoftKeyboard.Properties.Resources.t_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonU_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonU_MouseDown");
                if (bCapaLock)
                {
                    buttonU.BackgroundImage = SoftKeyboard.Properties.Resources.U_大写激活;
                }
                else
                {
                    buttonU.BackgroundImage = SoftKeyboard.Properties.Resources.u_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonU_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonU_MouseUp");
                if (bCapaLock)
                {
                    buttonU.BackgroundImage = SoftKeyboard.Properties.Resources.U_大写标准;
                }
                else
                {
                    buttonU.BackgroundImage = SoftKeyboard.Properties.Resources.u_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }


        private void buttonV_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonV_MouseDown");
                if (bCapaLock)
                {
                    buttonV.BackgroundImage = SoftKeyboard.Properties.Resources.V_大写激活;
                }
                else
                {
                    buttonV.BackgroundImage = SoftKeyboard.Properties.Resources.v_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonV_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonV_MouseUp");
                if (bCapaLock)
                {
                    buttonV.BackgroundImage = SoftKeyboard.Properties.Resources.V_大写标准;
                }
                else
                {
                    buttonV.BackgroundImage = SoftKeyboard.Properties.Resources.v_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonW_MouseDown");
                if (bCapaLock)
                {
                    buttonW.BackgroundImage = SoftKeyboard.Properties.Resources.W_大写激活;
                }
                else
                {
                    buttonW.BackgroundImage = SoftKeyboard.Properties.Resources.w_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonW_MouseUp");
                if (bCapaLock)
                {
                    buttonW.BackgroundImage = SoftKeyboard.Properties.Resources.W_大写标准;
                }
                else
                {
                    buttonW.BackgroundImage = SoftKeyboard.Properties.Resources.w_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonX_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonX_MouseDown");
                if (bCapaLock)
                {
                    buttonX.BackgroundImage = SoftKeyboard.Properties.Resources.X_大写激活;
                }
                else
                {
                    buttonX.BackgroundImage = SoftKeyboard.Properties.Resources.x_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonX_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonJ_MouseUp");
                if (bCapaLock)
                {
                    buttonX.BackgroundImage = SoftKeyboard.Properties.Resources.X_大写标准;
                }
                else
                {
                    buttonX.BackgroundImage = SoftKeyboard.Properties.Resources.x_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonY_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonY_MouseDown");
                if (bCapaLock)
                {
                    buttonY.BackgroundImage = SoftKeyboard.Properties.Resources.Y_大写激活;
                }
                else
                {
                    buttonY.BackgroundImage = SoftKeyboard.Properties.Resources.y_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonY_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonY_MouseUp");
                if (bCapaLock)
                {
                    buttonY.BackgroundImage = SoftKeyboard.Properties.Resources.Y_大写标准;
                }
                else
                {
                    buttonY.BackgroundImage = SoftKeyboard.Properties.Resources.y_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonZ_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonZ_MouseDown");
                if (bCapaLock)
                {
                    buttonZ.BackgroundImage = SoftKeyboard.Properties.Resources.Z_大写激活;
                }
                else
                {
                    buttonZ.BackgroundImage = SoftKeyboard.Properties.Resources.z_小写激活;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonZ_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonZ_MouseUp");
                if (bCapaLock)
                {
                    buttonZ.BackgroundImage = SoftKeyboard.Properties.Resources.Z_大写标准;
                }
                else
                {
                    buttonZ.BackgroundImage = SoftKeyboard.Properties.Resources.z_小写标准;
                }
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button1_MouseDown");
                button1.BackgroundImage = SoftKeyboard.Properties.Resources._1_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button1_MouseUp");
                button1.BackgroundImage = SoftKeyboard.Properties.Resources._1_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button2_MouseDown");
                button2.BackgroundImage = SoftKeyboard.Properties.Resources._2_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button1_MouseUp");
                button2.BackgroundImage = SoftKeyboard.Properties.Resources._2_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button3_MouseDown");
                button3.BackgroundImage = SoftKeyboard.Properties.Resources._3_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button3_MouseUp");
                button3.BackgroundImage = SoftKeyboard.Properties.Resources._3_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button4_MouseDown");
                button4.BackgroundImage = SoftKeyboard.Properties.Resources._4_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button4_MouseUp");
                button4.BackgroundImage = SoftKeyboard.Properties.Resources._4_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button5_MouseDown");
                button5.BackgroundImage = SoftKeyboard.Properties.Resources._5_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button5_MouseUp");
                button5.BackgroundImage = SoftKeyboard.Properties.Resources._5_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button6_MouseDown");
                button6.BackgroundImage = SoftKeyboard.Properties.Resources._6_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button6_MouseUp");
                button6.BackgroundImage = SoftKeyboard.Properties.Resources._6_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button7_MouseDown");
                button7.BackgroundImage = SoftKeyboard.Properties.Resources._7_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button7_MouseUp");
                button7.BackgroundImage = SoftKeyboard.Properties.Resources._7_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button8_MouseDown");
                button8.BackgroundImage = SoftKeyboard.Properties.Resources._8_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button8_MouseUp");
                button8.BackgroundImage = SoftKeyboard.Properties.Resources._8_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button9_MouseDown");
                button9.BackgroundImage = SoftKeyboard.Properties.Resources._9_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button9_MouseUp");
                button9.BackgroundImage = SoftKeyboard.Properties.Resources._9_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button0_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button0_MouseDown");
                button0.BackgroundImage = SoftKeyboard.Properties.Resources._0_数字激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }

        }

        private void button0_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button0_MouseUp");
                button0.BackgroundImage = SoftKeyboard.Properties.Resources._0_数字标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDEL_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDEL_MouseDown");
                buttonDEL.BackgroundImage = SoftKeyboard.Properties.Resources.删_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDEL_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDEL_MouseUp");
                buttonDEL.BackgroundImage = SoftKeyboard.Properties.Resources.删_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCOMPELET_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCOMPELET_MouseDown");
                buttonCOMPELET.BackgroundImage = SoftKeyboard.Properties.Resources.完成_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCOMPELET_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCOMPELET_MouseUp");
                buttonCOMPELET.BackgroundImage = SoftKeyboard.Properties.Resources.完成_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCancel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCancel_MouseDown");
                buttonCancel.BackgroundImage = SoftKeyboard.Properties.Resources.取消_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCancel_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCancel_MouseUp");
                buttonCancel.BackgroundImage = SoftKeyboard.Properties.Resources.取消_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonLeft_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonLeft_MouseDown");
                buttonLeft.BackgroundImage = SoftKeyboard.Properties.Resources.方向左_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonLeft_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonLeft_MouseUp");
                buttonLeft.BackgroundImage = SoftKeyboard.Properties.Resources.方向左_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonRigth_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonRigth_MouseDown");
                buttonRigth.BackgroundImage = SoftKeyboard.Properties.Resources.方向右_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonRigth_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonRigth_MouseUp");
                buttonRigth.BackgroundImage = SoftKeyboard.Properties.Resources.方向右_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonLOCK_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonLOCK_MouseDown");
                buttonLOCK.BackgroundImage = SoftKeyboard.Properties.Resources.大小写_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonLOCK_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonLOCK_MouseUP");
                buttonLOCK.BackgroundImage = SoftKeyboard.Properties.Resources.大小写_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }


        private void buttonSpace_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSpace_MouseDown");
                buttonSpace.BackgroundImage = SoftKeyboard.Properties.Resources.空格_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSpace_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSpace_MouseUp");
                buttonSpace.BackgroundImage = SoftKeyboard.Properties.Resources.空格_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT2_MouseDown");
                buttonSHIFT2.BackgroundImage = SoftKeyboard.Properties.Resources.__激活1;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT2_MouseUp");
                buttonSHIFT2.BackgroundImage = SoftKeyboard.Properties.Resources.__标准1;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT3_MouseDown");
                buttonSHIFT3.BackgroundImage = SoftKeyboard.Properties.Resources.__激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT3_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT3_MouseUp");
                buttonSHIFT3.BackgroundImage = SoftKeyboard.Properties.Resources.__标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSubtract_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSubtract_MouseDown");
                buttonSubtract.BackgroundImage = SoftKeyboard.Properties.Resources.中横线_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSubtract_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSubtract_MouseUp");
                buttonSubtract.BackgroundImage = SoftKeyboard.Properties.Resources.中横线_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT7_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT7_MouseDown");
                buttonSHIFT7.BackgroundImage = SoftKeyboard.Properties.Resources.且_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT7_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT7_MouseUp");
                buttonSHIFT7.BackgroundImage = SoftKeyboard.Properties.Resources.且_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDivide_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDivide_MouseDown");
                buttonDivide.BackgroundImage = SoftKeyboard.Properties.Resources.左撇_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDivide_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDivide_MouseUp");
                buttonDivide.BackgroundImage = SoftKeyboard.Properties.Resources.左撇_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttoncomma_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttoncomma_MouseDown");
                buttoncomma.BackgroundImage = SoftKeyboard.Properties.Resources.逗号_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttoncomma_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttoncomma_MouseUp");
                buttoncomma.BackgroundImage = SoftKeyboard.Properties.Resources.逗号_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDecimal_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDecimal_MouseDown");
                buttonDecimal.BackgroundImage = SoftKeyboard.Properties.Resources.点_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDecimal_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonDecimal_MouseUp");
                buttonDecimal.BackgroundImage = SoftKeyboard.Properties.Resources.点_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCOMPELET_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void buttonCOMPELET1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCOMPELET1_MouseDown");
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCOMPELET1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonCOMPELET1_MouseUp");
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT9_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT9_MouseDown");
                buttonSHIFT9.BackgroundImage = SoftKeyboard.Properties.Resources.左括号_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT9_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT9_MouseUp");
                buttonSHIFT9.BackgroundImage = SoftKeyboard.Properties.Resources.左括号_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT0_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT0_MouseDown");
                buttonSHIFT0.BackgroundImage = SoftKeyboard.Properties.Resources.右括号_激活;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT0_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonSHIFT0_MouseUp");
                buttonSHIFT0.BackgroundImage = SoftKeyboard.Properties.Resources.右括号_标准;
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }
        #endregion

        internal static GraphicsPath CreateRoundedRectanglePath(Rectangle rect)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            try
            {
                int cornerRadius = 13;
                roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
                roundedRect.AddLine(rect.X + cornerRadius * 2, rect.Y + 1, rect.Right - cornerRadius * 2, rect.Y + 1);
                roundedRect.AddArc(rect.Right - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
                roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Bottom - cornerRadius * 2);
                roundedRect.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
                roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                roundedRect.AddLine(rect.X + 1, rect.Bottom - cornerRadius * 2, rect.X + 1, rect.Y + cornerRadius * 2);
                roundedRect.CloseFigure();
            }
            catch
            {
            }
            return roundedRect;
        }

        #region 为每个按键绘制圆角边框
        private void buttonRigth_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonRigth.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);

                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonRigth.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonLeft_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonLeft.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonLeft.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonM_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonM.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonM.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonN_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonN.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonN.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonB_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonB.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonB.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonV_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonV.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonV.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonC_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonC.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonC.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonX_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonX.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonX.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonZ_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonZ.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonZ.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSpace_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonSpace.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonSpace.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button28_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button28.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button28.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }




        private void buttonLOCK_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonLOCK.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonLOCK.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonA_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonA.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                buttonA.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonS_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonS.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonS.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonD_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonD.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonD.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonF_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonF.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonF.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonG_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonG.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonG.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonH_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonH.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonH.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonJ_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonJ.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonJ.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonK_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonK.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonK.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonL_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonL.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonL.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCOMPELET_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonCOMPELET.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonCOMPELET.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonCancel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonCancel.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonCancel.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDEL_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonDEL.ClientRectangle;
                newRectangle.Inflate(0, 0);

                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonDEL.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonP_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonP.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonP.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonO_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonO.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonO.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonI_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonI.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonI.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonU_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonU.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonU.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonY_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonY.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonY.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonT_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonT.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                buttonT.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonR_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonR.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonR.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonE_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonE.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonE.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonW_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonW.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonW.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonQ_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonQ.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonQ.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button1.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button1.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button2.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button2.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button3.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button3.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button4.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button4.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button5.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button5.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button6.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button6.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button7_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button7.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button7.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button8_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button8.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button8.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button9_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button9.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button9.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void button0_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = button0.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                button0.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonSHIFT2.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonSHIFT2.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT3_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonSHIFT3.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonSHIFT3.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSubtract_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonSubtract.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonSubtract.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT7_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonSHIFT7.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonSHIFT7.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDivide_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonDivide.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonDivide.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttoncomma_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttoncomma.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttoncomma.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonDecimal_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonDecimal.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonDecimal.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT9_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonSHIFT9.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonSHIFT9.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        private void buttonSHIFT0_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newRectangle = buttonSHIFT0.ClientRectangle;
                newRectangle.Inflate(0, 0);
                buttonPath = CreateRoundedRectanglePath(newRectangle);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = 2.0F;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                e.Graphics.DrawPath(pen, buttonPath);
                buttonSHIFT0.Region = new System.Drawing.Region(buttonPath);
            }
            catch (Exception err)
            {
                ConsoleWriteLine(err.ToString());
            }
        }

        #endregion

        

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSpace = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSHIFT0 = new System.Windows.Forms.Button();
            this.buttonSHIFT9 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttoncomma = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonSHIFT7 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonSHIFT3 = new System.Windows.Forms.Button();
            this.buttonSHIFT2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonCOMPELET = new System.Windows.Forms.Button();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.buttonLOCK = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonRigth = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSpace
            // 
            this.buttonSpace.BackgroundImage = global::SoftKeyboard.Properties.Resources.空格_标准;
            this.buttonSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSpace.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSpace.Location = new System.Drawing.Point(298, 590);
            this.buttonSpace.Name = "buttonSpace";
            this.buttonSpace.Size = new System.Drawing.Size(701, 120);
            this.buttonSpace.TabIndex = 33;
            this.buttonSpace.UseVisualStyleBackColor = true;
            this.buttonSpace.Click += new System.EventHandler(this.buttonSpace_Click);
            this.buttonSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSpace_Paint);
            this.buttonSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSpace_MouseDown);
            this.buttonSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSpace_MouseUp);
            // 
            // button28
            // 
            this.button28.BackgroundImage = global::SoftKeyboard.Properties.Resources.数字符号_标准;
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button28.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button28.Location = new System.Drawing.Point(12, 589);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(280, 120);
            this.button28.TabIndex = 32;
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            this.button28.Paint += new System.Windows.Forms.PaintEventHandler(this.button28_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.buttonSHIFT0);
            this.panel1.Controls.Add(this.buttonSHIFT9);
            this.panel1.Controls.Add(this.buttonDecimal);
            this.panel1.Controls.Add(this.buttoncomma);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.buttonDivide);
            this.panel1.Controls.Add(this.buttonSHIFT7);
            this.panel1.Controls.Add(this.buttonSubtract);
            this.panel1.Controls.Add(this.buttonSHIFT3);
            this.panel1.Controls.Add(this.buttonSHIFT2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 390);
            this.panel1.TabIndex = 41;
            // 
            // buttonSHIFT0
            // 
            this.buttonSHIFT0.BackgroundImage = global::SoftKeyboard.Properties.Resources.右括号_标准;
            this.buttonSHIFT0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSHIFT0.Location = new System.Drawing.Point(1180, 136);
            this.buttonSHIFT0.Name = "buttonSHIFT0";
            this.buttonSHIFT0.Size = new System.Drawing.Size(120, 120);
            this.buttonSHIFT0.TabIndex = 72;
            this.buttonSHIFT0.UseVisualStyleBackColor = true;
            this.buttonSHIFT0.Click += new System.EventHandler(this.buttonSHIFT0_Click);
            this.buttonSHIFT0.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSHIFT0_Paint);
            this.buttonSHIFT0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT0_MouseDown);
            this.buttonSHIFT0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT0_MouseUp);
            // 
            // buttonSHIFT9
            // 
            this.buttonSHIFT9.BackgroundImage = global::SoftKeyboard.Properties.Resources.左括号_标准;
            this.buttonSHIFT9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSHIFT9.Location = new System.Drawing.Point(1044, 136);
            this.buttonSHIFT9.Name = "buttonSHIFT9";
            this.buttonSHIFT9.Size = new System.Drawing.Size(120, 120);
            this.buttonSHIFT9.TabIndex = 62;
            this.buttonSHIFT9.UseVisualStyleBackColor = true;
            this.buttonSHIFT9.Click += new System.EventHandler(this.buttonSHIFT9_Click);
            this.buttonSHIFT9.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSHIFT9_Paint);
            this.buttonSHIFT9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT9_MouseDown);
            this.buttonSHIFT9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT9_MouseUp);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackgroundImage = global::SoftKeyboard.Properties.Resources.点_标准;
            this.buttonDecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDecimal.Location = new System.Drawing.Point(906, 136);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(120, 120);
            this.buttonDecimal.TabIndex = 59;
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDecimal_Click);
            this.buttonDecimal.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonDecimal_Paint);
            this.buttonDecimal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDecimal_MouseDown);
            this.buttonDecimal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDecimal_MouseUp);
            // 
            // buttoncomma
            // 
            this.buttoncomma.BackgroundImage = global::SoftKeyboard.Properties.Resources.逗号_标准;
            this.buttoncomma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttoncomma.Location = new System.Drawing.Point(770, 136);
            this.buttoncomma.Name = "buttoncomma";
            this.buttoncomma.Size = new System.Drawing.Size(120, 120);
            this.buttoncomma.TabIndex = 58;
            this.buttoncomma.UseVisualStyleBackColor = true;
            this.buttoncomma.Click += new System.EventHandler(this.buttoncomma_Click);
            this.buttoncomma.Paint += new System.Windows.Forms.PaintEventHandler(this.buttoncomma_Paint);
            this.buttoncomma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttoncomma_MouseDown);
            this.buttoncomma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttoncomma_MouseUp);
            // 
            // button0
            // 
            this.button0.BackgroundImage = global::SoftKeyboard.Properties.Resources._0_数字标准;
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button0.Location = new System.Drawing.Point(1244, 5);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(120, 120);
            this.button0.TabIndex = 56;
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.common_Click);
            this.button0.Paint += new System.Windows.Forms.PaintEventHandler(this.button0_Paint);
            this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button0_MouseDown);
            this.button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button0_MouseUp);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::SoftKeyboard.Properties.Resources._9_数字标准;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Location = new System.Drawing.Point(1109, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 120);
            this.button9.TabIndex = 55;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.common_Click);
            this.button9.Paint += new System.Windows.Forms.PaintEventHandler(this.button9_Paint);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button9_MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button9_MouseUp);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::SoftKeyboard.Properties.Resources._8_数字标准;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Location = new System.Drawing.Point(974, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 120);
            this.button8.TabIndex = 54;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.common_Click);
            this.button8.Paint += new System.Windows.Forms.PaintEventHandler(this.button8_Paint);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button8_MouseUp);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::SoftKeyboard.Properties.Resources._7_数字标准;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(839, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 120);
            this.button7.TabIndex = 53;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.common_Click);
            this.button7.Paint += new System.Windows.Forms.PaintEventHandler(this.button7_Paint);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button7_MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button7_MouseUp);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackgroundImage = global::SoftKeyboard.Properties.Resources.左撇_标准;
            this.buttonDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDivide.Location = new System.Drawing.Point(634, 136);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(120, 120);
            this.buttonDivide.TabIndex = 52;
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            this.buttonDivide.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonDivide_Paint);
            this.buttonDivide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDivide_MouseDown);
            this.buttonDivide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDivide_MouseUp);
            // 
            // buttonSHIFT7
            // 
            this.buttonSHIFT7.BackgroundImage = global::SoftKeyboard.Properties.Resources.且_标准;
            this.buttonSHIFT7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSHIFT7.Location = new System.Drawing.Point(498, 136);
            this.buttonSHIFT7.Name = "buttonSHIFT7";
            this.buttonSHIFT7.Size = new System.Drawing.Size(120, 120);
            this.buttonSHIFT7.TabIndex = 51;
            this.buttonSHIFT7.UseVisualStyleBackColor = true;
            this.buttonSHIFT7.Click += new System.EventHandler(this.buttonSHIFT7_Click);
            this.buttonSHIFT7.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSHIFT7_Paint);
            this.buttonSHIFT7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT7_MouseDown);
            this.buttonSHIFT7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT7_MouseUp);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackgroundImage = global::SoftKeyboard.Properties.Resources.中横线_标准;
            this.buttonSubtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSubtract.Location = new System.Drawing.Point(362, 136);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(120, 120);
            this.buttonSubtract.TabIndex = 50;
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            this.buttonSubtract.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSubtract_Paint);
            this.buttonSubtract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSubtract_MouseDown);
            this.buttonSubtract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSubtract_MouseUp);
            // 
            // buttonSHIFT3
            // 
            this.buttonSHIFT3.BackgroundImage = global::SoftKeyboard.Properties.Resources.@__标准;
            this.buttonSHIFT3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSHIFT3.Location = new System.Drawing.Point(226, 136);
            this.buttonSHIFT3.Name = "buttonSHIFT3";
            this.buttonSHIFT3.Size = new System.Drawing.Size(120, 120);
            this.buttonSHIFT3.TabIndex = 49;
            this.buttonSHIFT3.UseVisualStyleBackColor = true;
            this.buttonSHIFT3.Click += new System.EventHandler(this.buttonSHIFT3_Click);
            this.buttonSHIFT3.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSHIFT3_Paint);
            this.buttonSHIFT3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT3_MouseDown);
            this.buttonSHIFT3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT3_MouseUp);
            // 
            // buttonSHIFT2
            // 
            this.buttonSHIFT2.BackgroundImage = global::SoftKeyboard.Properties.Resources.@__标准1;
            this.buttonSHIFT2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSHIFT2.Location = new System.Drawing.Point(90, 136);
            this.buttonSHIFT2.Name = "buttonSHIFT2";
            this.buttonSHIFT2.Size = new System.Drawing.Size(120, 120);
            this.buttonSHIFT2.TabIndex = 48;
            this.buttonSHIFT2.UseVisualStyleBackColor = true;
            this.buttonSHIFT2.Click += new System.EventHandler(this.buttonSHIFT2_Click);
            this.buttonSHIFT2.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSHIFT2_Paint);
            this.buttonSHIFT2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT2_MouseDown);
            this.buttonSHIFT2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSHIFT2_MouseUp);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::SoftKeyboard.Properties.Resources._6_数字标准;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(704, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 120);
            this.button6.TabIndex = 46;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.common_Click);
            this.button6.Paint += new System.Windows.Forms.PaintEventHandler(this.button6_Paint);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::SoftKeyboard.Properties.Resources._5_数字标准;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(569, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 120);
            this.button5.TabIndex = 45;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.common_Click);
            this.button5.Paint += new System.Windows.Forms.PaintEventHandler(this.button5_Paint);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SoftKeyboard.Properties.Resources._4_数字标准;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(434, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 120);
            this.button4.TabIndex = 44;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.common_Click);
            this.button4.Paint += new System.Windows.Forms.PaintEventHandler(this.button4_Paint);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SoftKeyboard.Properties.Resources._3_数字标准;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(299, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 120);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.common_Click);
            this.button3.Paint += new System.Windows.Forms.PaintEventHandler(this.button3_Paint);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SoftKeyboard.Properties.Resources._2_数字标准;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(164, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 120);
            this.button2.TabIndex = 42;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.common_Click);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SoftKeyboard.Properties.Resources._1_数字标准;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(29, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 120);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.common_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // buttonK
            // 
            this.buttonK.BackColor = System.Drawing.Color.Transparent;
            this.buttonK.BackgroundImage = global::SoftKeyboard.Properties.Resources.K_大写标准;
            this.buttonK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonK.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonK.Location = new System.Drawing.Point(1041, 137);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(119, 119);
            this.buttonK.TabIndex = 19;
            this.buttonK.UseVisualStyleBackColor = false;
            this.buttonK.Click += new System.EventHandler(this.common_Click);
            this.buttonK.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonK_Paint);
            this.buttonK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonK_MouseDown);
            this.buttonK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonK_MouseUp);
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.Color.Transparent;
            this.buttonL.BackgroundImage = global::SoftKeyboard.Properties.Resources.L_大写标准;
            this.buttonL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonL.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonL.Location = new System.Drawing.Point(1177, 137);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(119, 119);
            this.buttonL.TabIndex = 20;
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.common_Click);
            this.buttonL.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonL_Paint);
            this.buttonL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonL_MouseDown);
            this.buttonL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonL_MouseUp);
            // 
            // buttonJ
            // 
            this.buttonJ.BackColor = System.Drawing.Color.Transparent;
            this.buttonJ.BackgroundImage = global::SoftKeyboard.Properties.Resources.J_大写标准;
            this.buttonJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonJ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonJ.Location = new System.Drawing.Point(905, 137);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(119, 119);
            this.buttonJ.TabIndex = 18;
            this.buttonJ.UseVisualStyleBackColor = false;
            this.buttonJ.Click += new System.EventHandler(this.common_Click);
            this.buttonJ.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonJ_Paint);
            this.buttonJ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonJ_MouseDown);
            this.buttonJ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonJ_MouseUp);
            // 
            // buttonCOMPELET
            // 
            this.buttonCOMPELET.BackColor = System.Drawing.Color.Transparent;
            this.buttonCOMPELET.BackgroundImage = global::SoftKeyboard.Properties.Resources.完成_激活;
            this.buttonCOMPELET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCOMPELET.Enabled = false;
            this.buttonCOMPELET.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCOMPELET.Location = new System.Drawing.Point(1005, 591);
            this.buttonCOMPELET.Name = "buttonCOMPELET";
            this.buttonCOMPELET.Size = new System.Drawing.Size(184, 119);
            this.buttonCOMPELET.TabIndex = 21;
            this.buttonCOMPELET.UseVisualStyleBackColor = false;
            this.buttonCOMPELET.Click += new System.EventHandler(this.buttonCOMPELET_Click);
            this.buttonCOMPELET.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCOMPELET_Paint);
            this.buttonCOMPELET.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCOMPELET_MouseClick);
            this.buttonCOMPELET.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCOMPELET_MouseDown);
            this.buttonCOMPELET.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonCOMPELET_MouseUp);
            // 
            // buttonDEL
            // 
            this.buttonDEL.BackColor = System.Drawing.Color.Transparent;
            this.buttonDEL.BackgroundImage = global::SoftKeyboard.Properties.Resources.删_标准;
            this.buttonDEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDEL.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDEL.Location = new System.Drawing.Point(1245, 12);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(119, 119);
            this.buttonDEL.TabIndex = 16;
            this.buttonDEL.UseVisualStyleBackColor = false;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            this.buttonDEL.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonDEL_Paint);
            this.buttonDEL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDEL_MouseDown);
            this.buttonDEL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDEL_MouseUp);
            // 
            // buttonLOCK
            // 
            this.buttonLOCK.BackColor = System.Drawing.Color.Transparent;
            this.buttonLOCK.BackgroundImage = global::SoftKeyboard.Properties.Resources.大小写_标准;
            this.buttonLOCK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLOCK.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLOCK.Location = new System.Drawing.Point(29, 269);
            this.buttonLOCK.Name = "buttonLOCK";
            this.buttonLOCK.Size = new System.Drawing.Size(254, 119);
            this.buttonLOCK.TabIndex = 25;
            this.buttonLOCK.UseVisualStyleBackColor = false;
            this.buttonLOCK.Click += new System.EventHandler(this.buttonLOCK_Click);
            this.buttonLOCK.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLOCK_Paint);
            this.buttonLOCK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLOCK_MouseDown);
            this.buttonLOCK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLOCK_MouseUp);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.Transparent;
            this.buttonP.BackgroundImage = global::SoftKeyboard.Properties.Resources.P_大写标准;
            this.buttonP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonP.Location = new System.Drawing.Point(1244, 7);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(119, 119);
            this.buttonP.TabIndex = 15;
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.common_Click);
            this.buttonP.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonP_Paint);
            this.buttonP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonP_MouseDown);
            this.buttonP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonP_MouseUp);
            // 
            // buttonZ
            // 
            this.buttonZ.BackColor = System.Drawing.Color.Transparent;
            this.buttonZ.BackgroundImage = global::SoftKeyboard.Properties.Resources.Z_大写标准;
            this.buttonZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonZ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonZ.Location = new System.Drawing.Point(299, 269);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(119, 119);
            this.buttonZ.TabIndex = 26;
            this.buttonZ.UseVisualStyleBackColor = false;
            this.buttonZ.Click += new System.EventHandler(this.common_Click);
            this.buttonZ.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonZ_Paint);
            this.buttonZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonZ_MouseDown);
            this.buttonZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonZ_MouseUp);
            // 
            // buttonO
            // 
            this.buttonO.BackColor = System.Drawing.Color.Transparent;
            this.buttonO.BackgroundImage = global::SoftKeyboard.Properties.Resources.O_大写标准;
            this.buttonO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonO.Location = new System.Drawing.Point(1109, 7);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(119, 119);
            this.buttonO.TabIndex = 14;
            this.buttonO.UseVisualStyleBackColor = false;
            this.buttonO.Click += new System.EventHandler(this.common_Click);
            this.buttonO.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonO_Paint);
            this.buttonO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonO_MouseDown);
            this.buttonO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonO_MouseUp);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.Transparent;
            this.buttonX.BackgroundImage = global::SoftKeyboard.Properties.Resources.X_大写标准;
            this.buttonX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonX.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonX.Location = new System.Drawing.Point(434, 269);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(119, 119);
            this.buttonX.TabIndex = 27;
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.common_Click);
            this.buttonX.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonX_Paint);
            this.buttonX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonX_MouseDown);
            this.buttonX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonX_MouseUp);
            // 
            // buttonI
            // 
            this.buttonI.BackColor = System.Drawing.Color.Transparent;
            this.buttonI.BackgroundImage = global::SoftKeyboard.Properties.Resources.I_大写标准;
            this.buttonI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonI.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonI.Location = new System.Drawing.Point(974, 7);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(119, 119);
            this.buttonI.TabIndex = 13;
            this.buttonI.UseVisualStyleBackColor = false;
            this.buttonI.Click += new System.EventHandler(this.common_Click);
            this.buttonI.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonI_Paint);
            this.buttonI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonI_MouseDown);
            this.buttonI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonI_MouseUp);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Transparent;
            this.buttonC.BackgroundImage = global::SoftKeyboard.Properties.Resources.C_大写标准;
            this.buttonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonC.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonC.Location = new System.Drawing.Point(569, 269);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(119, 119);
            this.buttonC.TabIndex = 28;
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.common_Click);
            this.buttonC.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonC_Paint);
            this.buttonC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonC_MouseDown);
            this.buttonC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonC_MouseUp);
            // 
            // buttonU
            // 
            this.buttonU.BackColor = System.Drawing.Color.Transparent;
            this.buttonU.BackgroundImage = global::SoftKeyboard.Properties.Resources.U_大写标准;
            this.buttonU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonU.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonU.Location = new System.Drawing.Point(839, 7);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(119, 119);
            this.buttonU.TabIndex = 12;
            this.buttonU.UseVisualStyleBackColor = false;
            this.buttonU.Click += new System.EventHandler(this.common_Click);
            this.buttonU.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonU_Paint);
            this.buttonU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonU_MouseDown);
            this.buttonU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonU_MouseUp);
            // 
            // buttonV
            // 
            this.buttonV.BackColor = System.Drawing.Color.Transparent;
            this.buttonV.BackgroundImage = global::SoftKeyboard.Properties.Resources.V_大写标准;
            this.buttonV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonV.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonV.Location = new System.Drawing.Point(704, 269);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(119, 119);
            this.buttonV.TabIndex = 29;
            this.buttonV.UseVisualStyleBackColor = false;
            this.buttonV.Click += new System.EventHandler(this.common_Click);
            this.buttonV.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonV_Paint);
            this.buttonV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonV_MouseDown);
            this.buttonV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonV_MouseUp);
            // 
            // buttonH
            // 
            this.buttonH.BackColor = System.Drawing.Color.Transparent;
            this.buttonH.BackgroundImage = global::SoftKeyboard.Properties.Resources.H_大写标准;
            this.buttonH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonH.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonH.Location = new System.Drawing.Point(769, 137);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(119, 119);
            this.buttonH.TabIndex = 11;
            this.buttonH.UseVisualStyleBackColor = false;
            this.buttonH.Click += new System.EventHandler(this.common_Click);
            this.buttonH.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonH_Paint);
            this.buttonH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonH_MouseDown);
            this.buttonH.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonH_MouseUp);
            // 
            // buttonG
            // 
            this.buttonG.BackColor = System.Drawing.Color.Transparent;
            this.buttonG.BackgroundImage = global::SoftKeyboard.Properties.Resources.G_大写标准;
            this.buttonG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonG.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonG.Location = new System.Drawing.Point(633, 137);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(119, 119);
            this.buttonG.TabIndex = 10;
            this.buttonG.UseVisualStyleBackColor = false;
            this.buttonG.Click += new System.EventHandler(this.common_Click);
            this.buttonG.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonG_Paint);
            this.buttonG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonG_MouseDown);
            this.buttonG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonG_MouseUp);
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.Transparent;
            this.buttonF.BackgroundImage = global::SoftKeyboard.Properties.Resources.F_大写标准;
            this.buttonF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonF.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonF.Location = new System.Drawing.Point(497, 137);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(119, 119);
            this.buttonF.TabIndex = 9;
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.common_Click);
            this.buttonF.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonF_Paint);
            this.buttonF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonF_MouseDown);
            this.buttonF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonF_MouseUp);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.Transparent;
            this.buttonD.BackgroundImage = global::SoftKeyboard.Properties.Resources.D_大写标准;
            this.buttonD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonD.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonD.Location = new System.Drawing.Point(361, 137);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(119, 119);
            this.buttonD.TabIndex = 8;
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.common_Click);
            this.buttonD.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonD_Paint);
            this.buttonD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonD_MouseDown);
            this.buttonD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonD_MouseUp);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.Transparent;
            this.buttonS.BackgroundImage = global::SoftKeyboard.Properties.Resources.S_大写标准;
            this.buttonS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonS.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonS.Location = new System.Drawing.Point(225, 137);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(119, 119);
            this.buttonS.TabIndex = 7;
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.common_Click);
            this.buttonS.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonS_Paint);
            this.buttonS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonS_MouseDown);
            this.buttonS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonS_MouseUp);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.Transparent;
            this.buttonB.BackgroundImage = global::SoftKeyboard.Properties.Resources.B_大写标准;
            this.buttonB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonB.Location = new System.Drawing.Point(839, 269);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(119, 119);
            this.buttonB.TabIndex = 36;
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.common_Click);
            this.buttonB.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonB_Paint);
            this.buttonB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonB_MouseDown);
            this.buttonB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonB_MouseUp);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.Transparent;
            this.buttonA.BackgroundImage = global::SoftKeyboard.Properties.Resources.A_大写标准;
            this.buttonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonA.Location = new System.Drawing.Point(89, 137);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(119, 119);
            this.buttonA.TabIndex = 6;
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.common_Click);
            this.buttonA.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonA_Paint);
            this.buttonA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonA_MouseDown);
            this.buttonA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonA_MouseUp);
            // 
            // buttonN
            // 
            this.buttonN.BackColor = System.Drawing.Color.Transparent;
            this.buttonN.BackgroundImage = global::SoftKeyboard.Properties.Resources.N_大写标准;
            this.buttonN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonN.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonN.Location = new System.Drawing.Point(974, 269);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(119, 119);
            this.buttonN.TabIndex = 37;
            this.buttonN.UseVisualStyleBackColor = false;
            this.buttonN.Click += new System.EventHandler(this.common_Click);
            this.buttonN.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonN_Paint);
            this.buttonN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonN_MouseDown);
            this.buttonN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonN_MouseUp);
            // 
            // buttonY
            // 
            this.buttonY.BackColor = System.Drawing.Color.Transparent;
            this.buttonY.BackgroundImage = global::SoftKeyboard.Properties.Resources.Y_大写标准;
            this.buttonY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonY.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonY.Location = new System.Drawing.Point(704, 7);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(119, 119);
            this.buttonY.TabIndex = 5;
            this.buttonY.UseVisualStyleBackColor = false;
            this.buttonY.Click += new System.EventHandler(this.common_Click);
            this.buttonY.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonY_Paint);
            this.buttonY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonY_MouseDown);
            this.buttonY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonY_MouseUp);
            // 
            // buttonM
            // 
            this.buttonM.BackColor = System.Drawing.Color.Transparent;
            this.buttonM.BackgroundImage = global::SoftKeyboard.Properties.Resources.M_大写标准;
            this.buttonM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonM.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonM.Location = new System.Drawing.Point(1109, 269);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(119, 119);
            this.buttonM.TabIndex = 38;
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.common_Click);
            this.buttonM.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonM_Paint);
            this.buttonM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonM_MouseDown);
            this.buttonM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonM_MouseUp);
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.Color.Transparent;
            this.buttonT.BackgroundImage = global::SoftKeyboard.Properties.Resources.T_大写标准;
            this.buttonT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonT.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonT.Location = new System.Drawing.Point(569, 7);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(119, 119);
            this.buttonT.TabIndex = 4;
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.common_Click);
            this.buttonT.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonT_Paint);
            this.buttonT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonT_MouseDown);
            this.buttonT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonT_MouseUp);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeft.BackgroundImage = global::SoftKeyboard.Properties.Resources.方向左_标准;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLeft.Location = new System.Drawing.Point(956, 12);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(119, 119);
            this.buttonLeft.TabIndex = 39;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            this.buttonLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLeft_Paint);
            this.buttonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseDown);
            this.buttonLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseUp);
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.Transparent;
            this.buttonR.BackgroundImage = global::SoftKeyboard.Properties.Resources.R_大写标准;
            this.buttonR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonR.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonR.Location = new System.Drawing.Point(434, 7);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(119, 119);
            this.buttonR.TabIndex = 3;
            this.buttonR.UseVisualStyleBackColor = false;
            this.buttonR.Click += new System.EventHandler(this.common_Click);
            this.buttonR.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonR_Paint);
            this.buttonR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonR_MouseDown);
            this.buttonR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonR_MouseUp);
            // 
            // buttonRigth
            // 
            this.buttonRigth.BackColor = System.Drawing.Color.Transparent;
            this.buttonRigth.BackgroundImage = global::SoftKeyboard.Properties.Resources.方向右_标准;
            this.buttonRigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRigth.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRigth.Location = new System.Drawing.Point(1092, 12);
            this.buttonRigth.Name = "buttonRigth";
            this.buttonRigth.Size = new System.Drawing.Size(119, 119);
            this.buttonRigth.TabIndex = 40;
            this.buttonRigth.UseVisualStyleBackColor = false;
            this.buttonRigth.Click += new System.EventHandler(this.buttonRigth_Click);
            this.buttonRigth.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonRigth_Paint);
            this.buttonRigth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRigth_MouseDown);
            this.buttonRigth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRigth_MouseUp);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Transparent;
            this.buttonE.BackgroundImage = global::SoftKeyboard.Properties.Resources.E_大写标准;
            this.buttonE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonE.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonE.Location = new System.Drawing.Point(299, 7);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(119, 119);
            this.buttonE.TabIndex = 2;
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.common_Click);
            this.buttonE.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonE_Paint);
            this.buttonE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonE_MouseDown);
            this.buttonE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonE_MouseUp);
            // 
            // buttonW
            // 
            this.buttonW.BackColor = System.Drawing.Color.Transparent;
            this.buttonW.BackgroundImage = global::SoftKeyboard.Properties.Resources.W_大写标准;
            this.buttonW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonW.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonW.Location = new System.Drawing.Point(164, 7);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(119, 119);
            this.buttonW.TabIndex = 1;
            this.buttonW.UseVisualStyleBackColor = false;
            this.buttonW.Click += new System.EventHandler(this.common_Click);
            this.buttonW.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonW_Paint);
            this.buttonW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonW_MouseDown);
            this.buttonW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonW_MouseUp);
            // 
            // buttonQ
            // 
            this.buttonQ.BackColor = System.Drawing.Color.Transparent;
            this.buttonQ.BackgroundImage = global::SoftKeyboard.Properties.Resources.Q_大写标准;
            this.buttonQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQ.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonQ.Location = new System.Drawing.Point(29, 7);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(119, 119);
            this.buttonQ.TabIndex = 0;
            this.buttonQ.UseVisualStyleBackColor = false;
            this.buttonQ.Click += new System.EventHandler(this.common_Click);
            this.buttonQ.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonQ_Paint);
            this.buttonQ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonQ_MouseDown);
            this.buttonQ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonQ_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.buttonQ);
            this.panel3.Controls.Add(this.buttonW);
            this.panel3.Controls.Add(this.buttonE);
            this.panel3.Controls.Add(this.buttonR);
            this.panel3.Controls.Add(this.buttonT);
            this.panel3.Controls.Add(this.buttonM);
            this.panel3.Controls.Add(this.buttonY);
            this.panel3.Controls.Add(this.buttonN);
            this.panel3.Controls.Add(this.buttonA);
            this.panel3.Controls.Add(this.buttonB);
            this.panel3.Controls.Add(this.buttonS);
            this.panel3.Controls.Add(this.buttonD);
            this.panel3.Controls.Add(this.buttonF);
            this.panel3.Controls.Add(this.buttonG);
            this.panel3.Controls.Add(this.buttonH);
            this.panel3.Controls.Add(this.buttonV);
            this.panel3.Controls.Add(this.buttonU);
            this.panel3.Controls.Add(this.buttonC);
            this.panel3.Controls.Add(this.buttonI);
            this.panel3.Controls.Add(this.buttonX);
            this.panel3.Controls.Add(this.buttonO);
            this.panel3.Controls.Add(this.buttonZ);
            this.panel3.Controls.Add(this.buttonP);
            this.panel3.Controls.Add(this.buttonLOCK);
            this.panel3.Controls.Add(this.buttonJ);
            this.panel3.Controls.Add(this.buttonL);
            this.panel3.Controls.Add(this.buttonK);
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1383, 390);
            this.panel3.TabIndex = 43;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BackgroundImage = global::SoftKeyboard.Properties.Resources.取消_标准;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(1195, 591);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(184, 119);
            this.buttonCancel.TabIndex = 41;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCancel_Paint);
            this.buttonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseDown);
            this.buttonCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseUp);
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("黑体", 55F);
            this.inputText.Location = new System.Drawing.Point(29, 12);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(909, 112);
            this.inputText.TabIndex = 44;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // SoftKeyboard26
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1388, 721);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonRigth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSpace);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.buttonCOMPELET);
            this.Controls.Add(this.buttonDEL);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(0, 160);
            this.Name = "SoftKeyboard26";
            this.Text = "请输入";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ControlBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpace;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSHIFT0;
        private System.Windows.Forms.Button buttonSHIFT9;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttoncomma;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonSHIFT7;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonSHIFT3;
        private System.Windows.Forms.Button buttonSHIFT2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonCOMPELET;
        private System.Windows.Forms.Button buttonDEL;
        private System.Windows.Forms.Button buttonLOCK;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonRigth;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox inputText;
    }
}
