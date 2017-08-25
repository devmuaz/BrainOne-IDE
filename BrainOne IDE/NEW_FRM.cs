using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainOne_IDE
{
    public partial class NEW_FRM : Form
    {
        public NEW_FRM()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }
        //*************************************************************************[(START)This code is for BOX SHADOW AND SYSTEM BORDER]***********
        [System.Runtime.InteropServices.DllImportAttribute("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,       // x-coordinate of upper-left corner
            int nTopRect,        // y-coordinate of upper-left corner
            int nRightRect,      // x-coordinate of lower-right corner
            int nBottomRect,     // y-coordinate of lower-right corner
            int nWidthEllipse,   // height of ellipse
            int nHeightEllipse   // width of ellipse
         );
        [System.Runtime.InteropServices.DllImportAttribute("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImportAttribute("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImportAttribute("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        // variables for box shadow
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        // struct for box shadow
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        // variables for dragging the form
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        //***************************************************************************[(END)This code is for BOX SHADOW AND SYSTEM BORDER]***********
        protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, Top);
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, Left);
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, Right);
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, Bottom);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 1; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                // box shadow
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default:
                    break;
            }

            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }


        }
        // This block is for dragging the form and other things.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void BROWES_BTN_Click(object sender, EventArgs e)
        {
            if (FB_DIALOG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PTOJ_PTH_TXT.Text = FB_DIALOG.SelectedPath.ToString();
            }
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            MAIN_FRM frm = new MAIN_FRM();
            frm = (MAIN_FRM)Application.OpenForms["MAIN_FRM"];

            try
            {
                if (PROJ_NM_TXT.Text == "")
                    MessageBox.Show("Please, set a project name.", "Project Name Needed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (PROG_NM_TXT.Text == "")
                    MessageBox.Show("Please, set a program name.", "Program Name Needed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (!(PROG_NM_TXT.Text.EndsWith(".cpp")))
                    MessageBox.Show("Program name should has an extension of cpp like 'TEST.cpp'", "Error Program name!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (PTOJ_PTH_TXT.Text == "")
                    MessageBox.Show("Please, set the path project", "Path Project Needed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (!(System.IO.Directory.Exists(PTOJ_PTH_TXT.Text)))
                    MessageBox.Show("Project path is not exists!", "Error Project Path!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    
                    System.IO.Directory.CreateDirectory(PTOJ_PTH_TXT.Text.ToString() + "\\" + PROJ_NM_TXT.Text.ToString()).ToString();
                    frm.cpp_PathFile = PTOJ_PTH_TXT.Text.ToString() + "\\" + PROJ_NM_TXT.Text.ToString() + "\\" + PROG_NM_TXT.Text.ToString();
                    frm.PROJ_PATH_LBL.Text = frm.cpp_PathFile;
                    frm.Editor_TXT.Enabled = true;
                    if (INCLUDE_CHKBOX.Checked == true)
                        frm.Editor_TXT.Text = BrainOne_IDE.Properties.Settings.Default.StandardCode.ToString();
                    this.Hide();

                }

                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PTOJ_PTH_TXT.Enabled = true;
                BROWES_BTN.Enabled = true;
            }
            else
            {
                PTOJ_PTH_TXT.Enabled = false;
                BROWES_BTN.Enabled = false;
            }
        }

        private void NEW_FRM_Load(object sender, EventArgs e)
        {
            PTOJ_PTH_TXT.Text = "C:\\Users\\" + System.Environment.UserName.ToString() + "\\Documents\\BrainOne projects";
        }

        private void CANCEL_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TITLE_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TOP_PNL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PROJ_NM_TXT_TextChanged_1(object sender, EventArgs e)
        {
            PROG_NM_TXT.Text = PROJ_NM_TXT.Text + ".cpp";
        }

        private void PROG_NM_TXT_MouseDown(object sender, MouseEventArgs e)
        {
            PROG_NM_TXT.Select(0, PROG_NM_TXT.Text.Length - 4);
        }

        private void PROG_NM_TXT_Enter(object sender, EventArgs e)
        {
            PROG_NM_TXT.Select(0, PROG_NM_TXT.Text.Length - 4);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            PROJ_NM_TXT.Focus();
        }
    }
}
