namespace BrainOne_IDE
{
    partial class NEW_FRM
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NEW_FRM));
            this.LBL2 = new System.Windows.Forms.Label();
            this.PROG_NM_TXT = new System.Windows.Forms.TextBox();
            this.TITLE_LBL = new System.Windows.Forms.Label();
            this.LBL3 = new System.Windows.Forms.Label();
            this.PTOJ_PTH_TXT = new System.Windows.Forms.TextBox();
            this.BROWES_BTN = new System.Windows.Forms.Button();
            this.OK_BTN = new System.Windows.Forms.Button();
            this.CANCEL_BTN = new System.Windows.Forms.Button();
            this.INCLUDE_CHKBOX = new System.Windows.Forms.CheckBox();
            this.FB_DIALOG = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TOP_PNL = new System.Windows.Forms.Panel();
            this.PNL1 = new System.Windows.Forms.Panel();
            this.PROJ_NM_TXT = new System.Windows.Forms.TextBox();
            this.LBL1 = new System.Windows.Forms.Label();
            this.PNL2 = new System.Windows.Forms.Panel();
            this.PNL3 = new System.Windows.Forms.Panel();
            this.TOP_PNL.SuspendLayout();
            this.PNL1.SuspendLayout();
            this.PNL2.SuspendLayout();
            this.PNL3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.ForeColor = System.Drawing.Color.White;
            this.LBL2.Location = new System.Drawing.Point(12, 118);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(134, 13);
            this.LBL2.TabIndex = 3;
            this.LBL2.Text = "Program File Name (*.cpp)";
            // 
            // PROG_NM_TXT
            // 
            this.PROG_NM_TXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PROG_NM_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PROG_NM_TXT.ForeColor = System.Drawing.Color.White;
            this.PROG_NM_TXT.Location = new System.Drawing.Point(8, 8);
            this.PROG_NM_TXT.Name = "PROG_NM_TXT";
            this.PROG_NM_TXT.Size = new System.Drawing.Size(356, 13);
            this.PROG_NM_TXT.TabIndex = 2;
            this.PROG_NM_TXT.Enter += new System.EventHandler(this.PROG_NM_TXT_Enter);
            this.PROG_NM_TXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PROG_NM_TXT_MouseDown);
            // 
            // TITLE_LBL
            // 
            this.TITLE_LBL.AutoSize = true;
            this.TITLE_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TITLE_LBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE_LBL.ForeColor = System.Drawing.Color.White;
            this.TITLE_LBL.Location = new System.Drawing.Point(11, 9);
            this.TITLE_LBL.Name = "TITLE_LBL";
            this.TITLE_LBL.Size = new System.Drawing.Size(161, 17);
            this.TITLE_LBL.TabIndex = 4;
            this.TITLE_LBL.Text = "Creating New C++ Project";
            this.TITLE_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TITLE_LBL_MouseDown);
            // 
            // LBL3
            // 
            this.LBL3.AutoSize = true;
            this.LBL3.ForeColor = System.Drawing.Color.White;
            this.LBL3.Location = new System.Drawing.Point(12, 176);
            this.LBL3.Name = "LBL3";
            this.LBL3.Size = new System.Drawing.Size(112, 13);
            this.LBL3.TabIndex = 6;
            this.LBL3.Text = "Project Path (Default)";
            // 
            // PTOJ_PTH_TXT
            // 
            this.PTOJ_PTH_TXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PTOJ_PTH_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PTOJ_PTH_TXT.Enabled = false;
            this.PTOJ_PTH_TXT.ForeColor = System.Drawing.Color.White;
            this.PTOJ_PTH_TXT.Location = new System.Drawing.Point(8, 8);
            this.PTOJ_PTH_TXT.Name = "PTOJ_PTH_TXT";
            this.PTOJ_PTH_TXT.Size = new System.Drawing.Size(325, 13);
            this.PTOJ_PTH_TXT.TabIndex = 5;
            // 
            // BROWES_BTN
            // 
            this.BROWES_BTN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BROWES_BTN.Enabled = false;
            this.BROWES_BTN.FlatAppearance.BorderSize = 0;
            this.BROWES_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BROWES_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BROWES_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BROWES_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BROWES_BTN.ForeColor = System.Drawing.Color.Silver;
            this.BROWES_BTN.Location = new System.Drawing.Point(339, 2);
            this.BROWES_BTN.Name = "BROWES_BTN";
            this.BROWES_BTN.Size = new System.Drawing.Size(32, 25);
            this.BROWES_BTN.TabIndex = 7;
            this.BROWES_BTN.Text = "...";
            this.BROWES_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BROWES_BTN.UseVisualStyleBackColor = false;
            this.BROWES_BTN.Click += new System.EventHandler(this.BROWES_BTN_Click);
            // 
            // OK_BTN
            // 
            this.OK_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OK_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OK_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OK_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OK_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OK_BTN.ForeColor = System.Drawing.Color.DarkGray;
            this.OK_BTN.Location = new System.Drawing.Point(280, 298);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(108, 26);
            this.OK_BTN.TabIndex = 8;
            this.OK_BTN.Text = "Create";
            this.OK_BTN.UseVisualStyleBackColor = false;
            this.OK_BTN.Click += new System.EventHandler(this.OK_BTN_Click);
            // 
            // CANCEL_BTN
            // 
            this.CANCEL_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CANCEL_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CANCEL_BTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CANCEL_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CANCEL_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CANCEL_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CANCEL_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CANCEL_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL_BTN.ForeColor = System.Drawing.Color.DarkGray;
            this.CANCEL_BTN.Location = new System.Drawing.Point(15, 298);
            this.CANCEL_BTN.Name = "CANCEL_BTN";
            this.CANCEL_BTN.Size = new System.Drawing.Size(108, 26);
            this.CANCEL_BTN.TabIndex = 8;
            this.CANCEL_BTN.Text = "Cancel";
            this.CANCEL_BTN.UseVisualStyleBackColor = false;
            this.CANCEL_BTN.Click += new System.EventHandler(this.CANCEL_BTN_Click);
            // 
            // INCLUDE_CHKBOX
            // 
            this.INCLUDE_CHKBOX.AutoSize = true;
            this.INCLUDE_CHKBOX.Checked = true;
            this.INCLUDE_CHKBOX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.INCLUDE_CHKBOX.ForeColor = System.Drawing.Color.White;
            this.INCLUDE_CHKBOX.Location = new System.Drawing.Point(15, 268);
            this.INCLUDE_CHKBOX.Name = "INCLUDE_CHKBOX";
            this.INCLUDE_CHKBOX.Size = new System.Drawing.Size(133, 17);
            this.INCLUDE_CHKBOX.TabIndex = 9;
            this.INCLUDE_CHKBOX.Text = "Include standard code";
            this.INCLUDE_CHKBOX.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(15, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Change Path";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TOP_PNL
            // 
            this.TOP_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TOP_PNL.Controls.Add(this.TITLE_LBL);
            this.TOP_PNL.Location = new System.Drawing.Point(1, 1);
            this.TOP_PNL.Name = "TOP_PNL";
            this.TOP_PNL.Size = new System.Drawing.Size(399, 37);
            this.TOP_PNL.TabIndex = 11;
            this.TOP_PNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOP_PNL_MouseDown);
            // 
            // PNL1
            // 
            this.PNL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL1.Controls.Add(this.PROJ_NM_TXT);
            this.PNL1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNL1.Location = new System.Drawing.Point(15, 75);
            this.PNL1.Name = "PNL1";
            this.PNL1.Size = new System.Drawing.Size(373, 29);
            this.PNL1.TabIndex = 12;
            this.PNL1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // PROJ_NM_TXT
            // 
            this.PROJ_NM_TXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PROJ_NM_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PROJ_NM_TXT.ForeColor = System.Drawing.Color.White;
            this.PROJ_NM_TXT.Location = new System.Drawing.Point(8, 8);
            this.PROJ_NM_TXT.Name = "PROJ_NM_TXT";
            this.PROJ_NM_TXT.Size = new System.Drawing.Size(357, 13);
            this.PROJ_NM_TXT.TabIndex = 2;
            this.PROJ_NM_TXT.TextChanged += new System.EventHandler(this.PROJ_NM_TXT_TextChanged_1);
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.ForeColor = System.Drawing.Color.White;
            this.LBL1.Location = new System.Drawing.Point(12, 59);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(134, 13);
            this.LBL1.TabIndex = 3;
            this.LBL1.Text = "Project Name (Valid Name)";
            // 
            // PNL2
            // 
            this.PNL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL2.Controls.Add(this.PROG_NM_TXT);
            this.PNL2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNL2.Location = new System.Drawing.Point(15, 134);
            this.PNL2.Name = "PNL2";
            this.PNL2.Size = new System.Drawing.Size(373, 29);
            this.PNL2.TabIndex = 13;
            // 
            // PNL3
            // 
            this.PNL3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL3.Controls.Add(this.PTOJ_PTH_TXT);
            this.PNL3.Controls.Add(this.BROWES_BTN);
            this.PNL3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNL3.Location = new System.Drawing.Point(15, 192);
            this.PNL3.Name = "PNL3";
            this.PNL3.Size = new System.Drawing.Size(373, 29);
            this.PNL3.TabIndex = 14;
            // 
            // NEW_FRM
            // 
            this.AcceptButton = this.OK_BTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CancelButton = this.CANCEL_BTN;
            this.ClientSize = new System.Drawing.Size(401, 336);
            this.Controls.Add(this.PNL3);
            this.Controls.Add(this.PNL2);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.PNL1);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.CANCEL_BTN);
            this.Controls.Add(this.TOP_PNL);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.INCLUDE_CHKBOX);
            this.Controls.Add(this.LBL3);
            this.Controls.Add(this.LBL2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NEW_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New File...";
            this.Load += new System.EventHandler(this.NEW_FRM_Load);
            this.TOP_PNL.ResumeLayout(false);
            this.TOP_PNL.PerformLayout();
            this.PNL1.ResumeLayout(false);
            this.PNL1.PerformLayout();
            this.PNL2.ResumeLayout(false);
            this.PNL2.PerformLayout();
            this.PNL3.ResumeLayout(false);
            this.PNL3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.TextBox PROG_NM_TXT;
        private System.Windows.Forms.Label TITLE_LBL;
        private System.Windows.Forms.Label LBL3;
        private System.Windows.Forms.TextBox PTOJ_PTH_TXT;
        private System.Windows.Forms.Button BROWES_BTN;
        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.Button CANCEL_BTN;
        private System.Windows.Forms.CheckBox INCLUDE_CHKBOX;
        private System.Windows.Forms.FolderBrowserDialog FB_DIALOG;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel TOP_PNL;
        private System.Windows.Forms.Panel PNL1;
        private System.Windows.Forms.TextBox PROJ_NM_TXT;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Panel PNL2;
        private System.Windows.Forms.Panel PNL3;
    }
}