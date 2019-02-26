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
    public partial class TextInputBox : Form
    {
        private bool bCapaLock = true;
        private bool is数字符号激活 = false;
        private bool OKorCancel = true;


        public static bool Show(string Title, ref string rettext)  //显示InputBox
        {
            TextInputBox inputbox = new TextInputBox();
            inputbox.Text = Title;
            inputbox.ShowDialog();
            rettext = inputbox.inputText.Text;
            if (rettext.Length > 0)
                return inputbox.OKorCancel;
            else
                return false;
        }

        public TextInputBox()
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
                buttonA.BackgroundImage = SoftKeyBoard.Properties.Resources.a_小写标准;
                buttonB.BackgroundImage = SoftKeyBoard.Properties.Resources.b_小写标准;
                buttonC.BackgroundImage = SoftKeyBoard.Properties.Resources.c_小写标准;
                buttonD.BackgroundImage = SoftKeyBoard.Properties.Resources.d_小写标准;
                buttonE.BackgroundImage = SoftKeyBoard.Properties.Resources.e_小写标准;
                buttonF.BackgroundImage = SoftKeyBoard.Properties.Resources.f_小写标准;
                buttonG.BackgroundImage = SoftKeyBoard.Properties.Resources.g_小写标准;
                buttonH.BackgroundImage = SoftKeyBoard.Properties.Resources.h_小写标准;
                buttonI.BackgroundImage = SoftKeyBoard.Properties.Resources.i_小写标准;
                buttonJ.BackgroundImage = SoftKeyBoard.Properties.Resources.j_小写标准;
                buttonK.BackgroundImage = SoftKeyBoard.Properties.Resources.k_小写标准;
                buttonL.BackgroundImage = SoftKeyBoard.Properties.Resources.l_小写标准;
                buttonM.BackgroundImage = SoftKeyBoard.Properties.Resources.m_小写标准;
                buttonN.BackgroundImage = SoftKeyBoard.Properties.Resources.n_小写标准;
                buttonO.BackgroundImage = SoftKeyBoard.Properties.Resources.o_小写标准;
                buttonP.BackgroundImage = SoftKeyBoard.Properties.Resources.p_小写标准;
                buttonQ.BackgroundImage = SoftKeyBoard.Properties.Resources.q_小写标准;
                buttonR.BackgroundImage = SoftKeyBoard.Properties.Resources.r_小写标准;
                buttonS.BackgroundImage = SoftKeyBoard.Properties.Resources.s_小写标准;
                buttonT.BackgroundImage = SoftKeyBoard.Properties.Resources.t_小写标准;
                buttonU.BackgroundImage = SoftKeyBoard.Properties.Resources.u_小写标准;
                buttonV.BackgroundImage = SoftKeyBoard.Properties.Resources.v_小写标准;
                buttonW.BackgroundImage = SoftKeyBoard.Properties.Resources.w_小写标准;
                buttonX.BackgroundImage = SoftKeyBoard.Properties.Resources.x_小写标准;
                buttonY.BackgroundImage = SoftKeyBoard.Properties.Resources.y_小写标准;
                buttonZ.BackgroundImage = SoftKeyBoard.Properties.Resources.z_小写标准;
            }
            else
            {
                buttonA.BackgroundImage = SoftKeyBoard.Properties.Resources.A_大写标准;
                buttonB.BackgroundImage = SoftKeyBoard.Properties.Resources.B_大写标准;
                buttonC.BackgroundImage = SoftKeyBoard.Properties.Resources.C_大写标准;
                buttonD.BackgroundImage = SoftKeyBoard.Properties.Resources.D_大写标准;
                buttonE.BackgroundImage = SoftKeyBoard.Properties.Resources.E_大写标准;
                buttonF.BackgroundImage = SoftKeyBoard.Properties.Resources.F_大写标准;
                buttonG.BackgroundImage = SoftKeyBoard.Properties.Resources.G_大写标准;
                buttonH.BackgroundImage = SoftKeyBoard.Properties.Resources.H_大写标准;
                buttonI.BackgroundImage = SoftKeyBoard.Properties.Resources.I_大写标准;
                buttonJ.BackgroundImage = SoftKeyBoard.Properties.Resources.J_大写标准;
                buttonK.BackgroundImage = SoftKeyBoard.Properties.Resources.K_大写标准;
                buttonL.BackgroundImage = SoftKeyBoard.Properties.Resources.L_大写标准;
                buttonM.BackgroundImage = SoftKeyBoard.Properties.Resources.M_大写标准;
                buttonN.BackgroundImage = SoftKeyBoard.Properties.Resources.N_大写标准;
                buttonO.BackgroundImage = SoftKeyBoard.Properties.Resources.O_大写标准;
                buttonP.BackgroundImage = SoftKeyBoard.Properties.Resources.P_大写标准;
                buttonQ.BackgroundImage = SoftKeyBoard.Properties.Resources.Q_大写标准;
                buttonR.BackgroundImage = SoftKeyBoard.Properties.Resources.R_大写标准;
                buttonS.BackgroundImage = SoftKeyBoard.Properties.Resources.S_大写标准;
                buttonT.BackgroundImage = SoftKeyBoard.Properties.Resources.T_大写标准;
                buttonU.BackgroundImage = SoftKeyBoard.Properties.Resources.U_大写标准;
                buttonV.BackgroundImage = SoftKeyBoard.Properties.Resources.V_大写标准;
                buttonW.BackgroundImage = SoftKeyBoard.Properties.Resources.W_大写标准;
                buttonX.BackgroundImage = SoftKeyBoard.Properties.Resources.X_大写标准;
                buttonY.BackgroundImage = SoftKeyBoard.Properties.Resources.Y_大写标准;
                buttonZ.BackgroundImage = SoftKeyBoard.Properties.Resources.Z_大写标准;
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
                    button28.BackgroundImage = SoftKeyBoard.Properties.Resources.数字符号_激活;
                else
                    button28.BackgroundImage = SoftKeyBoard.Properties.Resources.数字符号_标准;
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
                buttonCOMPELET.BackgroundImage = SoftKeyBoard.Properties.Resources.完成_标准;
            }
            else
            {
                buttonCOMPELET.Enabled = false;
                buttonCOMPELET.BackgroundImage = SoftKeyBoard.Properties.Resources.完成_激活;
            }
        }


        #region 按键的按下弹起视觉效果
        private void buttonA_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (bCapaLock)
                {
                    buttonA.BackgroundImage = SoftKeyBoard.Properties.Resources.A_大写激活;
                }
                else
                {
                    buttonA.BackgroundImage = SoftKeyBoard.Properties.Resources.a_小写激活;
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
                    buttonA.BackgroundImage = SoftKeyBoard.Properties.Resources.A_大写标准;
                }
                else
                {
                    buttonA.BackgroundImage = SoftKeyBoard.Properties.Resources.a_小写标准;
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
                    buttonB.BackgroundImage = SoftKeyBoard.Properties.Resources.B_大写激活;
                }
                else
                {
                    buttonB.BackgroundImage = SoftKeyBoard.Properties.Resources.b_小写激活;
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
                    buttonB.BackgroundImage = SoftKeyBoard.Properties.Resources.B_大写标准;
                }
                else
                {
                    buttonB.BackgroundImage = SoftKeyBoard.Properties.Resources.b_小写标准;
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
                    buttonC.BackgroundImage = SoftKeyBoard.Properties.Resources.C_大写标准;
                }
                else
                {
                    buttonC.BackgroundImage = SoftKeyBoard.Properties.Resources.c_小写标准;
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
                    buttonC.BackgroundImage = SoftKeyBoard.Properties.Resources.C_大写激活;
                }
                else
                {
                    buttonC.BackgroundImage = SoftKeyBoard.Properties.Resources.c_小写激活;
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
                    buttonD.BackgroundImage = SoftKeyBoard.Properties.Resources.D_大写激活;
                }
                else
                {
                    buttonD.BackgroundImage = SoftKeyBoard.Properties.Resources.d_小写激活;
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
                    buttonD.BackgroundImage = SoftKeyBoard.Properties.Resources.D_大写标准;
                }
                else
                {
                    buttonD.BackgroundImage = SoftKeyBoard.Properties.Resources.d_小写标准;
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
                    buttonE.BackgroundImage = SoftKeyBoard.Properties.Resources.E_大写激活;
                }
                else
                {
                    buttonE.BackgroundImage = SoftKeyBoard.Properties.Resources.e_小写激活;
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
                    buttonE.BackgroundImage = SoftKeyBoard.Properties.Resources.E_大写标准;
                }
                else
                {
                    buttonE.BackgroundImage = SoftKeyBoard.Properties.Resources.e_小写标准;
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
                    buttonF.BackgroundImage = SoftKeyBoard.Properties.Resources.F_大写激活;
                }
                else
                {
                    buttonF.BackgroundImage = SoftKeyBoard.Properties.Resources.f_小写激活;
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
                    buttonF.BackgroundImage = SoftKeyBoard.Properties.Resources.F_大写标准;
                }
                else
                {
                    buttonF.BackgroundImage = SoftKeyBoard.Properties.Resources.f_小写标准;
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
                    buttonG.BackgroundImage = SoftKeyBoard.Properties.Resources.G_大写激活;
                }
                else
                {
                    buttonG.BackgroundImage = SoftKeyBoard.Properties.Resources.g_小写激活;
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
                    buttonG.BackgroundImage = SoftKeyBoard.Properties.Resources.G_大写标准;
                }
                else
                {
                    buttonG.BackgroundImage = SoftKeyBoard.Properties.Resources.g_小写标准;
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
                    buttonH.BackgroundImage = SoftKeyBoard.Properties.Resources.H_大写激活;
                }
                else
                {
                    buttonH.BackgroundImage = SoftKeyBoard.Properties.Resources.h_小写激活;
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
                    buttonH.BackgroundImage = SoftKeyBoard.Properties.Resources.H_大写标准;
                }
                else
                {
                    buttonH.BackgroundImage = SoftKeyBoard.Properties.Resources.h_小写标准;
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
                    buttonI.BackgroundImage = SoftKeyBoard.Properties.Resources.I_大写激活;
                }
                else
                {
                    buttonI.BackgroundImage = SoftKeyBoard.Properties.Resources.i_小写激活;
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
                    buttonI.BackgroundImage = SoftKeyBoard.Properties.Resources.I_大写标准;
                }
                else
                {
                    buttonI.BackgroundImage = SoftKeyBoard.Properties.Resources.i_小写标准;
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
                    buttonJ.BackgroundImage = SoftKeyBoard.Properties.Resources.J_大写激活;
                }
                else
                {
                    buttonJ.BackgroundImage = SoftKeyBoard.Properties.Resources.j_小写激活;
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
                    buttonJ.BackgroundImage = SoftKeyBoard.Properties.Resources.J_大写标准;
                }
                else
                {
                    buttonJ.BackgroundImage = SoftKeyBoard.Properties.Resources.j_小写标准;
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
                    buttonK.BackgroundImage = SoftKeyBoard.Properties.Resources.K_大写激活;
                }
                else
                {
                    buttonK.BackgroundImage = SoftKeyBoard.Properties.Resources.k_小写激活;
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
                    buttonK.BackgroundImage = SoftKeyBoard.Properties.Resources.K_大写标准;
                }
                else
                {
                    buttonK.BackgroundImage = SoftKeyBoard.Properties.Resources.k_小写标准;
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
                    buttonL.BackgroundImage = SoftKeyBoard.Properties.Resources.L_大写激活;
                }
                else
                {
                    buttonL.BackgroundImage = SoftKeyBoard.Properties.Resources.l_小写激活;
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
                    buttonL.BackgroundImage = SoftKeyBoard.Properties.Resources.L_大写标准;
                }
                else
                {
                    buttonL.BackgroundImage = SoftKeyBoard.Properties.Resources.l_小写标准;
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
                    buttonM.BackgroundImage = SoftKeyBoard.Properties.Resources.M_大写激活;
                }
                else
                {
                    buttonM.BackgroundImage = SoftKeyBoard.Properties.Resources.m_小写激活;
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
                    buttonM.BackgroundImage = SoftKeyBoard.Properties.Resources.M_大写标准;
                }
                else
                {
                    buttonM.BackgroundImage = SoftKeyBoard.Properties.Resources.m_小写标准;
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
                    buttonN.BackgroundImage = SoftKeyBoard.Properties.Resources.N_大写激活;
                }
                else
                {
                    buttonN.BackgroundImage = SoftKeyBoard.Properties.Resources.n_小写激活;
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
                    buttonN.BackgroundImage = SoftKeyBoard.Properties.Resources.N_大写标准;
                }
                else
                {
                    buttonN.BackgroundImage = SoftKeyBoard.Properties.Resources.n_小写标准;
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
                    buttonO.BackgroundImage = SoftKeyBoard.Properties.Resources.O_大写激活;
                }
                else
                {
                    buttonO.BackgroundImage = SoftKeyBoard.Properties.Resources.o_小写激活;
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
                    buttonO.BackgroundImage = SoftKeyBoard.Properties.Resources.O_大写标准;
                }
                else
                {
                    buttonO.BackgroundImage = SoftKeyBoard.Properties.Resources.o_小写标准;
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
                    buttonP.BackgroundImage = SoftKeyBoard.Properties.Resources.P_大写激活;
                }
                else
                {
                    buttonP.BackgroundImage = SoftKeyBoard.Properties.Resources.p_小写激活;
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
                    buttonP.BackgroundImage = SoftKeyBoard.Properties.Resources.P_大写标准;
                }
                else
                {
                    buttonP.BackgroundImage = SoftKeyBoard.Properties.Resources.p_小写标准;
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
                    buttonQ.BackgroundImage = SoftKeyBoard.Properties.Resources.Q_大写标准;
                }
                else
                {
                    buttonQ.BackgroundImage = SoftKeyBoard.Properties.Resources.q_小写标准;
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
                    buttonQ.BackgroundImage = SoftKeyBoard.Properties.Resources.Q_大写激活;
                }
                else
                {
                    buttonQ.BackgroundImage = SoftKeyBoard.Properties.Resources.q_小写激活;
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
                    buttonR.BackgroundImage = SoftKeyBoard.Properties.Resources.R_大写标准;
                }
                else
                {
                    buttonR.BackgroundImage = SoftKeyBoard.Properties.Resources.r_小写标准;
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
                    buttonR.BackgroundImage = SoftKeyBoard.Properties.Resources.R_大写激活;
                }
                else
                {
                    buttonR.BackgroundImage = SoftKeyBoard.Properties.Resources.r_小写激活;
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
                    buttonS.BackgroundImage = SoftKeyBoard.Properties.Resources.S_大写激活;
                }
                else
                {
                    buttonS.BackgroundImage = SoftKeyBoard.Properties.Resources.s_小写激活;
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
                    buttonS.BackgroundImage = SoftKeyBoard.Properties.Resources.S_大写标准;
                }
                else
                {
                    buttonS.BackgroundImage = SoftKeyBoard.Properties.Resources.s_小写标准;
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
                    buttonT.BackgroundImage = SoftKeyBoard.Properties.Resources.T_大写激活;
                }
                else
                {
                    buttonT.BackgroundImage = SoftKeyBoard.Properties.Resources.t_小写激活;
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
                    buttonT.BackgroundImage = SoftKeyBoard.Properties.Resources.T_大写标准;
                }
                else
                {
                    buttonT.BackgroundImage = SoftKeyBoard.Properties.Resources.t_小写标准;
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
                    buttonU.BackgroundImage = SoftKeyBoard.Properties.Resources.U_大写激活;
                }
                else
                {
                    buttonU.BackgroundImage = SoftKeyBoard.Properties.Resources.u_小写激活;
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
                    buttonU.BackgroundImage = SoftKeyBoard.Properties.Resources.U_大写标准;
                }
                else
                {
                    buttonU.BackgroundImage = SoftKeyBoard.Properties.Resources.u_小写标准;
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
                    buttonV.BackgroundImage = SoftKeyBoard.Properties.Resources.V_大写激活;
                }
                else
                {
                    buttonV.BackgroundImage = SoftKeyBoard.Properties.Resources.v_小写激活;
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
                    buttonV.BackgroundImage = SoftKeyBoard.Properties.Resources.V_大写标准;
                }
                else
                {
                    buttonV.BackgroundImage = SoftKeyBoard.Properties.Resources.v_小写标准;
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
                    buttonW.BackgroundImage = SoftKeyBoard.Properties.Resources.W_大写激活;
                }
                else
                {
                    buttonW.BackgroundImage = SoftKeyBoard.Properties.Resources.w_小写激活;
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
                    buttonW.BackgroundImage = SoftKeyBoard.Properties.Resources.W_大写标准;
                }
                else
                {
                    buttonW.BackgroundImage = SoftKeyBoard.Properties.Resources.w_小写标准;
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
                    buttonX.BackgroundImage = SoftKeyBoard.Properties.Resources.X_大写激活;
                }
                else
                {
                    buttonX.BackgroundImage = SoftKeyBoard.Properties.Resources.x_小写激活;
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
                    buttonX.BackgroundImage = SoftKeyBoard.Properties.Resources.X_大写标准;
                }
                else
                {
                    buttonX.BackgroundImage = SoftKeyBoard.Properties.Resources.x_小写标准;
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
                    buttonY.BackgroundImage = SoftKeyBoard.Properties.Resources.Y_大写激活;
                }
                else
                {
                    buttonY.BackgroundImage = SoftKeyBoard.Properties.Resources.y_小写激活;
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
                    buttonY.BackgroundImage = SoftKeyBoard.Properties.Resources.Y_大写标准;
                }
                else
                {
                    buttonY.BackgroundImage = SoftKeyBoard.Properties.Resources.y_小写标准;
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
                    buttonZ.BackgroundImage = SoftKeyBoard.Properties.Resources.Z_大写激活;
                }
                else
                {
                    buttonZ.BackgroundImage = SoftKeyBoard.Properties.Resources.z_小写激活;
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
                    buttonZ.BackgroundImage = SoftKeyBoard.Properties.Resources.Z_大写标准;
                }
                else
                {
                    buttonZ.BackgroundImage = SoftKeyBoard.Properties.Resources.z_小写标准;
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
                button0.BackgroundImage = SoftKeyBoard.Properties.Resources._0_数字激活;
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
                button0.BackgroundImage = SoftKeyBoard.Properties.Resources._0_数字标准;
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
                buttonDEL.BackgroundImage = SoftKeyBoard.Properties.Resources.删_激活;
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
                buttonDEL.BackgroundImage = SoftKeyBoard.Properties.Resources.删_标准;
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
                buttonCOMPELET.BackgroundImage = SoftKeyBoard.Properties.Resources.完成_激活;
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

        private void buttonLeft_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ConsoleWriteLine("buttonLeft_MouseDown");
                buttonLeft.BackgroundImage = SoftKeyBoard.Properties.Resources.方向左_激活;
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
                buttonLeft.BackgroundImage = SoftKeyBoard.Properties.Resources.方向左_标准;
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
                buttonRigth.BackgroundImage = SoftKeyBoard.Properties.Resources.方向右_激活;
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
                buttonRigth.BackgroundImage = SoftKeyBoard.Properties.Resources.方向右_标准;
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
                buttonLOCK.BackgroundImage = SoftKeyBoard.Properties.Resources.大小写_激活;
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
                buttonLOCK.BackgroundImage = SoftKeyBoard.Properties.Resources.大小写_标准;
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
                buttonSpace.BackgroundImage = SoftKeyBoard.Properties.Resources.空格_激活;
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
                buttonSpace.BackgroundImage = SoftKeyBoard.Properties.Resources.空格_标准;
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
                buttonSHIFT2.BackgroundImage = SoftKeyBoard.Properties.Resources.__激活1;
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
                buttonSHIFT2.BackgroundImage = SoftKeyBoard.Properties.Resources.__标准1;
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
                buttonSHIFT3.BackgroundImage = SoftKeyBoard.Properties.Resources.__激活;
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
                buttonSHIFT3.BackgroundImage = SoftKeyBoard.Properties.Resources.__标准;
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
                buttonSubtract.BackgroundImage = SoftKeyBoard.Properties.Resources.中横线_激活;
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
                buttonSubtract.BackgroundImage = SoftKeyBoard.Properties.Resources.中横线_标准;
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
                buttonSHIFT7.BackgroundImage = SoftKeyBoard.Properties.Resources.且_激活;
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
                buttonSHIFT7.BackgroundImage = SoftKeyBoard.Properties.Resources.且_标准;
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
                buttonDivide.BackgroundImage = SoftKeyBoard.Properties.Resources.左撇_激活;
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
                buttonDivide.BackgroundImage = SoftKeyBoard.Properties.Resources.左撇_标准;
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
                buttoncomma.BackgroundImage = SoftKeyBoard.Properties.Resources.逗号_激活;
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
                buttoncomma.BackgroundImage = SoftKeyBoard.Properties.Resources.逗号_标准;
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
                buttonSHIFT9.BackgroundImage = SoftKeyBoard.Properties.Resources.左括号_激活;
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
                buttonSHIFT9.BackgroundImage = SoftKeyBoard.Properties.Resources.左括号_标准;
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
                buttonSHIFT0.BackgroundImage = SoftKeyBoard.Properties.Resources.右括号_激活;
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
                buttonSHIFT0.BackgroundImage = SoftKeyBoard.Properties.Resources.右括号_标准;
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

        

    }
}
