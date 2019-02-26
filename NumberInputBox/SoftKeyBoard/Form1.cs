using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using System.Threading;
using System.Drawing.Drawing2D;

namespace SoftKeyBoard
{
    public partial class NumberInputForm : Form
    {
        //显示InputBox
        public static bool Show(string Title, ref string rettext)
        {
            NumberInputForm inputbox = new NumberInputForm();
            inputbox.Text = Title;
            inputbox.ShowDialog();
            rettext = inputbox.inputText.Text;
            if (rettext.Length > 0)
                return inputbox.OKorCancel;
            else
                return false;
        }

        private bool OKorCancel = true;

        public NumberInputForm()
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
                buttonCOMPELET.BackgroundImage = SoftKeyBoard.Properties.Resources.完成_标准;
            }
            catch
            {
                buttonCOMPELET.Enabled = false;
                buttonCOMPELET.BackgroundImage = SoftKeyBoard.Properties.Resources.完成_激活;
            }
        }

        #region 每个按钮的按下弹起动画
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("button1_MouseDown");
                button1.BackgroundImage = SoftKeyBoard.Properties.Resources._1_数字激活;
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
                button1.BackgroundImage = SoftKeyBoard.Properties.Resources._1_数字标准;
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
                button2.BackgroundImage = SoftKeyBoard.Properties.Resources._2_数字激活;
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
                button2.BackgroundImage = SoftKeyBoard.Properties.Resources._2_数字标准;
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
                button3.BackgroundImage = SoftKeyBoard.Properties.Resources._3_数字激活;
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
                button3.BackgroundImage = SoftKeyBoard.Properties.Resources._3_数字标准;
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
                button4.BackgroundImage = SoftKeyBoard.Properties.Resources._4_数字激活;
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
                button4.BackgroundImage = SoftKeyBoard.Properties.Resources._4_数字标准;
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
                button5.BackgroundImage = SoftKeyBoard.Properties.Resources._5_数字激活;
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
                button5.BackgroundImage = SoftKeyBoard.Properties.Resources._5_数字标准;
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
                button6.BackgroundImage = SoftKeyBoard.Properties.Resources._6_数字激活;
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
                button6.BackgroundImage = SoftKeyBoard.Properties.Resources._6_数字标准;
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
                button7.BackgroundImage = SoftKeyBoard.Properties.Resources._7_数字激活;
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
                button7.BackgroundImage = SoftKeyBoard.Properties.Resources._7_数字标准;
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
                button8.BackgroundImage = SoftKeyBoard.Properties.Resources._8_数字激活;
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
                button8.BackgroundImage = SoftKeyBoard.Properties.Resources._8_数字标准;
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
                button9.BackgroundImage = SoftKeyBoard.Properties.Resources._9_数字激活;
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
                button9.BackgroundImage = SoftKeyBoard.Properties.Resources._9_数字标准;
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
                button0.BackgroundImage = SoftKeyBoard.Properties.Resources._0w_数字激活;
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
                button0.BackgroundImage = SoftKeyBoard.Properties.Resources._0w_数字标准;
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
                buttonDEL.BackgroundImage = SoftKeyBoard.Properties.Resources.删p ;
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
                buttonDEL.BackgroundImage = SoftKeyBoard.Properties.Resources.删 ;
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
                buttonCOMPELET.BackgroundImage = SoftKeyBoard.Properties.Resources.完成_激活 ;
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
                buttonCOMPELET.BackgroundImage = SoftKeyBoard.Properties.Resources.完成_标准;
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
                buttonCancel.BackgroundImage = SoftKeyBoard.Properties.Resources.取消_激活;
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
                buttonCancel.BackgroundImage = SoftKeyBoard.Properties.Resources.取消_标准;
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
                buttonDecimal.BackgroundImage = SoftKeyBoard.Properties.Resources.点_激活;
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
                buttonDecimal.BackgroundImage = SoftKeyBoard.Properties.Resources.点_标准;
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

        

        
    }
}
