using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BrainOne_IDE
{
    public partial class MAIN_FRM : Form
    {
        public string cpp_PathFile;

        public MAIN_FRM()
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

        private void Mian_FRM_Load(object sender, EventArgs e)
        {
            if (!(Directory.Exists("C:\\Users" + System.Environment.UserName.ToString() + "\\Documents\\BrainOne Projects")))
            {
                System.IO.Directory.CreateDirectory("C:\\Users\\" + System.Environment.UserName.ToString() + "\\Documents\\BrainOne Projects");
            }

            BrainOne_IDE.Properties.Settings.Default.Reload();
            if (BrainOne_IDE.Properties.Settings.Default.LOVE_SET == "0")
            {
                LIKE_BTN.Image = BrainOne_IDE.Properties.Resources.UNLOVED_PIC;
                LIKE_BTN.Tag = "0";
            }

            else if (BrainOne_IDE.Properties.Settings.Default.LOVE_SET == "1")
            {
                LIKE_BTN.Image = BrainOne_IDE.Properties.Resources.LOVED_PIC;
                LIKE_BTN.Tag = "1";
            }

            cpp_PathFile = BrainOne_IDE.Properties.Settings.Default.SET_PATH;
            if (File.Exists(cpp_PathFile))
            {
                StreamReader Reader = new StreamReader(cpp_PathFile);
                Editor_TXT.Text = Reader.ReadToEnd();
                Reader.Close();
                Editor_TXT.Enabled = true;
                PROJ_PATH_LBL.Text = cpp_PathFile;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Maximum_BTN_Click(object sender, EventArgs e)
        {
            if (Maximum_BTN.Tag == "0")
            {
                this.WindowState = FormWindowState.Maximized;
                Maximum_BTN.Tag = "1";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Maximum_BTN.Tag = "0";
            }
        }

        private void Mian_FRM_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Maximum_BTN.Tag = "0";
            }
        }

        private void Minimum_BTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NEW_FRM frm = new NEW_FRM();
            frm.ShowDialog();
        }

        private void SAVE_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == false)
            {
                MessageBox.Show("No project and file was Edited or Created..!\nSelect 'New' to Create some or 'Open'\nto open a specific file.",
                    "Nothing to save..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cpp_PathFile == "")
                {
                    SF_DIALOG.Filter = "C++ File (*.cpp) | *.cpp";
                    if (SF_DIALOG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            StreamWriter Writer = new StreamWriter(SF_DIALOG.OpenFile());
                            Writer.Write(Editor_TXT.Text);
                            Writer.Close();
                            cpp_PathFile = Path.GetFullPath(SF_DIALOG.FileName.ToString());
                            STATUS_LBL.Text = "Status: Saved Successfully.";
                            PROJ_PATH_LBL.Text = cpp_PathFile;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    try
                    {
                        StreamWriter Writer = new StreamWriter(cpp_PathFile);
                        Writer.Write(Editor_TXT.Text);
                        Writer.Close();
                        STATUS_LBL.Text = "Status: Saved Successfully.";
                        PROJ_PATH_LBL.Text = cpp_PathFile;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void Editor_TXT_TextChanging(object sender, FastColoredTextBoxNS.TextChangingEventArgs e)
        {
            STATUS_LBL.Text = "Status: Ready";
        }

        private void PROJ_PATH_TXT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RUN_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == false)
            {
                MessageBox.Show("No project and file was Edited or Created..!\nSelect 'New' to Create some or 'Open'\nto open a specific file.",
                    "Nothing to build or execute..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    StreamWriter Writer = new StreamWriter(cpp_PathFile);
                    Writer.Write(Editor_TXT.Text);
                    Writer.Close();
                    

                    string object_PathFile = Path.GetFullPath(cpp_PathFile).Replace(Path.GetFileName(cpp_PathFile), string.Empty) +
                    Path.GetFileNameWithoutExtension(cpp_PathFile) + ".exe";
                    Process.Start("CMD.exe", "/K cd \\ && g++ " + '"' + cpp_PathFile + '"' + " -o " + '"' + object_PathFile + '"' +
                        " && " + '"' + object_PathFile + '"' + " && echo. && echo.");
                    STATUS_LBL.Text = "Status: Executed Successfully.";
                    PROJ_PATH_LBL.Text = cpp_PathFile;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }

        }

        private void BUILD_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == false)
            {
                MessageBox.Show("No project and file was Edited or Created..!\nSelect 'New' to Create some or 'Open'\nto open a specific file.",
                    "Nothing to build or execute..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    StreamWriter Writer = new StreamWriter(cpp_PathFile);
                    Writer.Write(Editor_TXT.Text);
                    Writer.Close();
                    

                    string object_PathFile = Path.GetFullPath(cpp_PathFile).Replace(Path.GetFileName(cpp_PathFile), string.Empty) +
                    Path.GetFileNameWithoutExtension(cpp_PathFile) + ".exe";
                    Process.Start("CMD.exe", "/C g++ " + '"' + cpp_PathFile + '"' + " -o " + '"' + object_PathFile + '"');
                    STATUS_LBL.Text = "Status: Built Successfully.";
                    PROJ_PATH_LBL.Text = cpp_PathFile;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SAVEAS_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == false)
            {
                MessageBox.Show("No project and file was Edited or Created..!\nSelect 'New' to Create some or 'Open'\nto open a specific file.",
                    "Nothing to save..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SF_DIALOG.Filter = "C++ File (*.cpp) | *.cpp";
                if (SF_DIALOG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        StreamWriter Writer = new StreamWriter(SF_DIALOG.OpenFile());
                        Writer.Write(Editor_TXT.Text);
                        Writer.Close();
                        cpp_PathFile = Path.GetFullPath(SF_DIALOG.FileName.ToString());
                        STATUS_LBL.Text = "Status: Saved Successfully.";
                        PROJ_PATH_LBL.Text = cpp_PathFile;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editor_TXT.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editor_TXT.Redo();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editor_TXT.SelectedText = "";
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editor_TXT.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editor_TXT.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editor_TXT.Paste();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editor_TXT.SelectAll();
        }

        private void INTRO_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void OPEN_BTN_Click(object sender, EventArgs e)
        {
            OF_DIALOG.Filter = "C++ File(*.cpp) | *.cpp";
            if (OF_DIALOG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamReader Reader = new StreamReader(OF_DIALOG.OpenFile());
                    Editor_TXT.Text = Reader.ReadToEnd();
                    Reader.Close();
                    Editor_TXT.Enabled = true;
                    cpp_PathFile = Path.GetFullPath(OF_DIALOG.FileName.ToString());
                    PROJ_PATH_LBL.Text = cpp_PathFile;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LOCK_BTN_Click(object sender, EventArgs e)
        {
            if (LOCK_BTN.Text == "Lock")
            {
                LOCK_BTN.Image = BrainOne_IDE.Properties.Resources.UNLOCK_PIC;
                LOCK_BTN.Text = "Unlock";
                Editor_TXT.ReadOnly = true;
            }
            else
            {
                LOCK_BTN.Image = BrainOne_IDE.Properties.Resources.LOCK_PIC;
                LOCK_BTN.Text = "Lock";
                Editor_TXT.ReadOnly = false;
            }
        }

        private void LINENUMBERS_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == true)
            if (LINENUMBERS_BTN.Tag == "1")
            {
                LINENUMBERS_BTN.Tag = "0";
                Editor_TXT.ShowLineNumbers = false;
            }
            else
            {
                LINENUMBERS_BTN.Tag = "1";
                Editor_TXT.ShowLineNumbers = true;
            }
        }

        private void CURRENTLINE_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == true)
            if (CURRENTLINE_BTN.Tag == "1")
            {
                CURRENTLINE_BTN.Tag = "0";
                Editor_TXT.CurrentLineColor = Color.Transparent;
            }
            else
            {
                CURRENTLINE_BTN.Tag = "1";
                Editor_TXT.CurrentLineColor = Color.DarkGray;
            }
        }

        private void UNDO_BTN_Click(object sender, EventArgs e)
        {
            if(Editor_TXT.Enabled == true)
                Editor_TXT.Undo();
        }

        private void REDO_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == true)
                Editor_TXT.Redo();
        }

        private void CUT_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == true)
                Editor_TXT.Cut();
        }

        private void COPY_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == true)
                Editor_TXT.Copy();
        }

        private void PASTE_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == true)
                Editor_TXT.Paste();
        }

        private void DELETE_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == true)
                Editor_TXT.SelectedText = "";
        }

        private void SELECTALL_BTN_Click(object sender, EventArgs e)
        {
            if (Editor_TXT.Enabled == true)
                Editor_TXT.SelectAll();
        }

        private void LIKE_BTN_Click(object sender, EventArgs e)
        {
            if (LIKE_BTN.Tag == "0")
            {
                LIKE_BTN.Image = BrainOne_IDE.Properties.Resources.LOVED_PIC;
                LIKE_BTN.Tag = "1";
                STATUS_LBL.Text = "Status: Loved it";
            }
            else
            {
                LIKE_BTN.Image = BrainOne_IDE.Properties.Resources.UNLOVED_PIC;
                LIKE_BTN.Tag = "0";
                STATUS_LBL.Text = "Status";
            }

        }

        private void MAIN_FRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            BrainOne_IDE.Properties.Settings.Default.SET_PATH = cpp_PathFile;
            BrainOne_IDE.Properties.Settings.Default.LOVE_SET = LIKE_BTN.Tag.ToString();
            BrainOne_IDE.Properties.Settings.Default.Save();
        }

        private void ABOUT_BTN_Click(object sender, EventArgs e)
        {
            ABOUT_FRM FRM = new ABOUT_FRM();
            FRM.ShowDialog();
        }

    }
}
