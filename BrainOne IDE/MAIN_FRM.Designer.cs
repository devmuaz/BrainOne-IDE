namespace BrainOne_IDE
{
    partial class MAIN_FRM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_FRM));
            this.Top_PNL = new System.Windows.Forms.Panel();
            this.LINE4 = new System.Windows.Forms.Label();
            this.LINE3 = new System.Windows.Forms.Label();
            this.LINE2 = new System.Windows.Forms.Label();
            this.LINE1 = new System.Windows.Forms.Label();
            this.Minimum_BTN = new System.Windows.Forms.Button();
            this.Maximum_BTN = new System.Windows.Forms.Button();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.LOCK_BTN = new System.Windows.Forms.Button();
            this.LINENUMBERS_BTN = new System.Windows.Forms.Button();
            this.CURRENTLINE_BTN = new System.Windows.Forms.Button();
            this.COPY_BTN = new System.Windows.Forms.Button();
            this.LIKE_BTN = new System.Windows.Forms.Button();
            this.ABOUT_BTN = new System.Windows.Forms.Button();
            this.SELECTALL_BTN = new System.Windows.Forms.Button();
            this.DELETE_BTN = new System.Windows.Forms.Button();
            this.PASTE_BTN = new System.Windows.Forms.Button();
            this.CUT_BTN = new System.Windows.Forms.Button();
            this.REDO_BTN = new System.Windows.Forms.Button();
            this.UNDO_BTN = new System.Windows.Forms.Button();
            this.PROJ_PATH_LBL = new System.Windows.Forms.Label();
            this.RUN_BTN = new System.Windows.Forms.Button();
            this.BUILD_BTN = new System.Windows.Forms.Button();
            this.SAVEAS_BTN = new System.Windows.Forms.Button();
            this.SAVE_BTN = new System.Windows.Forms.Button();
            this.OPEN_BTN = new System.Windows.Forms.Button();
            this.NEW_BTN = new System.Windows.Forms.Button();
            this.Title_LBL = new System.Windows.Forms.Label();
            this.Bottom_PNL = new System.Windows.Forms.Panel();
            this.STATUS_LBL = new System.Windows.Forms.Label();
            this.Editor_TXT = new FastColoredTextBoxNS.FastColoredTextBox();
            this.CON_MNU_STRIP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.documentMap1 = new FastColoredTextBoxNS.DocumentMap();
            this.AUTO_COM_MENU = new AutocompleteMenuNS.AutocompleteMenu();
            this.SF_DIALOG = new System.Windows.Forms.SaveFileDialog();
            this.OF_DIALOG = new System.Windows.Forms.OpenFileDialog();
            this.Top_PNL.SuspendLayout();
            this.Bottom_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor_TXT)).BeginInit();
            this.CON_MNU_STRIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_PNL
            // 
            this.Top_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Top_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Top_PNL.Controls.Add(this.LINE4);
            this.Top_PNL.Controls.Add(this.LINE3);
            this.Top_PNL.Controls.Add(this.LINE2);
            this.Top_PNL.Controls.Add(this.LINE1);
            this.Top_PNL.Controls.Add(this.Minimum_BTN);
            this.Top_PNL.Controls.Add(this.Maximum_BTN);
            this.Top_PNL.Controls.Add(this.Exit_BTN);
            this.Top_PNL.Controls.Add(this.LOCK_BTN);
            this.Top_PNL.Controls.Add(this.LINENUMBERS_BTN);
            this.Top_PNL.Controls.Add(this.CURRENTLINE_BTN);
            this.Top_PNL.Controls.Add(this.COPY_BTN);
            this.Top_PNL.Controls.Add(this.LIKE_BTN);
            this.Top_PNL.Controls.Add(this.ABOUT_BTN);
            this.Top_PNL.Controls.Add(this.SELECTALL_BTN);
            this.Top_PNL.Controls.Add(this.DELETE_BTN);
            this.Top_PNL.Controls.Add(this.PASTE_BTN);
            this.Top_PNL.Controls.Add(this.CUT_BTN);
            this.Top_PNL.Controls.Add(this.REDO_BTN);
            this.Top_PNL.Controls.Add(this.UNDO_BTN);
            this.Top_PNL.Controls.Add(this.PROJ_PATH_LBL);
            this.Top_PNL.Controls.Add(this.RUN_BTN);
            this.Top_PNL.Controls.Add(this.BUILD_BTN);
            this.Top_PNL.Controls.Add(this.SAVEAS_BTN);
            this.Top_PNL.Controls.Add(this.SAVE_BTN);
            this.Top_PNL.Controls.Add(this.OPEN_BTN);
            this.Top_PNL.Controls.Add(this.NEW_BTN);
            this.Top_PNL.Controls.Add(this.Title_LBL);
            this.Top_PNL.Location = new System.Drawing.Point(1, 1);
            this.Top_PNL.Name = "Top_PNL";
            this.Top_PNL.Size = new System.Drawing.Size(862, 124);
            this.Top_PNL.TabIndex = 0;
            this.Top_PNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // LINE4
            // 
            this.LINE4.BackColor = System.Drawing.Color.DimGray;
            this.LINE4.Location = new System.Drawing.Point(354, 92);
            this.LINE4.Name = "LINE4";
            this.LINE4.Size = new System.Drawing.Size(1, 26);
            this.LINE4.TabIndex = 13;
            // 
            // LINE3
            // 
            this.LINE3.BackColor = System.Drawing.Color.DimGray;
            this.LINE3.Location = new System.Drawing.Point(745, 33);
            this.LINE3.Name = "LINE3";
            this.LINE3.Size = new System.Drawing.Size(1, 52);
            this.LINE3.TabIndex = 12;
            // 
            // LINE2
            // 
            this.LINE2.BackColor = System.Drawing.Color.DimGray;
            this.LINE2.Location = new System.Drawing.Point(662, 33);
            this.LINE2.Name = "LINE2";
            this.LINE2.Size = new System.Drawing.Size(1, 52);
            this.LINE2.TabIndex = 11;
            // 
            // LINE1
            // 
            this.LINE1.BackColor = System.Drawing.Color.DimGray;
            this.LINE1.Location = new System.Drawing.Point(487, 33);
            this.LINE1.Name = "LINE1";
            this.LINE1.Size = new System.Drawing.Size(1, 52);
            this.LINE1.TabIndex = 10;
            // 
            // Minimum_BTN
            // 
            this.Minimum_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimum_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Minimum_BTN.FlatAppearance.BorderSize = 0;
            this.Minimum_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Minimum_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Minimum_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimum_BTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimum_BTN.ForeColor = System.Drawing.Color.Gray;
            this.Minimum_BTN.Location = new System.Drawing.Point(757, 0);
            this.Minimum_BTN.Name = "Minimum_BTN";
            this.Minimum_BTN.Size = new System.Drawing.Size(32, 32);
            this.Minimum_BTN.TabIndex = 2;
            this.Minimum_BTN.Text = "‒";
            this.Minimum_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimum_BTN.UseVisualStyleBackColor = false;
            this.Minimum_BTN.Click += new System.EventHandler(this.Minimum_BTN_Click);
            // 
            // Maximum_BTN
            // 
            this.Maximum_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximum_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Maximum_BTN.FlatAppearance.BorderSize = 0;
            this.Maximum_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Maximum_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Maximum_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximum_BTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximum_BTN.ForeColor = System.Drawing.Color.Gray;
            this.Maximum_BTN.Location = new System.Drawing.Point(789, 0);
            this.Maximum_BTN.Name = "Maximum_BTN";
            this.Maximum_BTN.Size = new System.Drawing.Size(32, 32);
            this.Maximum_BTN.TabIndex = 1;
            this.Maximum_BTN.Tag = "0";
            this.Maximum_BTN.Text = "⌂";
            this.Maximum_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Maximum_BTN.UseVisualStyleBackColor = false;
            this.Maximum_BTN.Click += new System.EventHandler(this.Maximum_BTN_Click);
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Exit_BTN.FlatAppearance.BorderSize = 0;
            this.Exit_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Exit_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Exit_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_BTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_BTN.ForeColor = System.Drawing.Color.Gray;
            this.Exit_BTN.Location = new System.Drawing.Point(821, 0);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(40, 32);
            this.Exit_BTN.TabIndex = 0;
            this.Exit_BTN.Text = "x";
            this.Exit_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_BTN.UseVisualStyleBackColor = false;
            this.Exit_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // LOCK_BTN
            // 
            this.LOCK_BTN.FlatAppearance.BorderSize = 0;
            this.LOCK_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LOCK_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.LOCK_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOCK_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOCK_BTN.ForeColor = System.Drawing.Color.White;
            this.LOCK_BTN.Image = global::BrainOne_IDE.Properties.Resources.LOCK_PIC;
            this.LOCK_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LOCK_BTN.Location = new System.Drawing.Point(595, 33);
            this.LOCK_BTN.Name = "LOCK_BTN";
            this.LOCK_BTN.Size = new System.Drawing.Size(60, 52);
            this.LOCK_BTN.TabIndex = 9;
            this.LOCK_BTN.Text = "Lock";
            this.LOCK_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LOCK_BTN.UseVisualStyleBackColor = true;
            this.LOCK_BTN.Click += new System.EventHandler(this.LOCK_BTN_Click);
            // 
            // LINENUMBERS_BTN
            // 
            this.LINENUMBERS_BTN.FlatAppearance.BorderSize = 0;
            this.LINENUMBERS_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LINENUMBERS_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.LINENUMBERS_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LINENUMBERS_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LINENUMBERS_BTN.ForeColor = System.Drawing.Color.White;
            this.LINENUMBERS_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LINENUMBERS_BTN.Location = new System.Drawing.Point(495, 62);
            this.LINENUMBERS_BTN.Name = "LINENUMBERS_BTN";
            this.LINENUMBERS_BTN.Size = new System.Drawing.Size(94, 25);
            this.LINENUMBERS_BTN.TabIndex = 9;
            this.LINENUMBERS_BTN.Tag = "1";
            this.LINENUMBERS_BTN.Text = "Line Numbers";
            this.LINENUMBERS_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LINENUMBERS_BTN.UseVisualStyleBackColor = true;
            this.LINENUMBERS_BTN.Click += new System.EventHandler(this.LINENUMBERS_BTN_Click);
            // 
            // CURRENTLINE_BTN
            // 
            this.CURRENTLINE_BTN.FlatAppearance.BorderSize = 0;
            this.CURRENTLINE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CURRENTLINE_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CURRENTLINE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CURRENTLINE_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CURRENTLINE_BTN.ForeColor = System.Drawing.Color.White;
            this.CURRENTLINE_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CURRENTLINE_BTN.Location = new System.Drawing.Point(495, 33);
            this.CURRENTLINE_BTN.Name = "CURRENTLINE_BTN";
            this.CURRENTLINE_BTN.Size = new System.Drawing.Size(94, 25);
            this.CURRENTLINE_BTN.TabIndex = 9;
            this.CURRENTLINE_BTN.Tag = "1";
            this.CURRENTLINE_BTN.Text = "Current Line";
            this.CURRENTLINE_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CURRENTLINE_BTN.UseVisualStyleBackColor = true;
            this.CURRENTLINE_BTN.Click += new System.EventHandler(this.CURRENTLINE_BTN_Click);
            // 
            // COPY_BTN
            // 
            this.COPY_BTN.FlatAppearance.BorderSize = 0;
            this.COPY_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.COPY_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.COPY_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COPY_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COPY_BTN.ForeColor = System.Drawing.Color.White;
            this.COPY_BTN.Image = global::BrainOne_IDE.Properties.Resources.COPY_PIC;
            this.COPY_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.COPY_BTN.Location = new System.Drawing.Point(212, 33);
            this.COPY_BTN.Name = "COPY_BTN";
            this.COPY_BTN.Size = new System.Drawing.Size(60, 52);
            this.COPY_BTN.TabIndex = 9;
            this.COPY_BTN.Text = "Copy";
            this.COPY_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.COPY_BTN.UseVisualStyleBackColor = true;
            this.COPY_BTN.Click += new System.EventHandler(this.COPY_BTN_Click);
            // 
            // LIKE_BTN
            // 
            this.LIKE_BTN.FlatAppearance.BorderSize = 0;
            this.LIKE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LIKE_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.LIKE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LIKE_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIKE_BTN.ForeColor = System.Drawing.Color.White;
            this.LIKE_BTN.Image = global::BrainOne_IDE.Properties.Resources.UNLOVED_PIC;
            this.LIKE_BTN.Location = new System.Drawing.Point(752, 33);
            this.LIKE_BTN.Name = "LIKE_BTN";
            this.LIKE_BTN.Size = new System.Drawing.Size(70, 52);
            this.LIKE_BTN.TabIndex = 9;
            this.LIKE_BTN.Tag = "0";
            this.LIKE_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LIKE_BTN.UseVisualStyleBackColor = true;
            this.LIKE_BTN.Click += new System.EventHandler(this.LIKE_BTN_Click);
            // 
            // ABOUT_BTN
            // 
            this.ABOUT_BTN.FlatAppearance.BorderSize = 0;
            this.ABOUT_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ABOUT_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ABOUT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABOUT_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABOUT_BTN.ForeColor = System.Drawing.Color.White;
            this.ABOUT_BTN.Image = global::BrainOne_IDE.Properties.Resources.ABOUT_PIC;
            this.ABOUT_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ABOUT_BTN.Location = new System.Drawing.Point(669, 33);
            this.ABOUT_BTN.Name = "ABOUT_BTN";
            this.ABOUT_BTN.Size = new System.Drawing.Size(70, 52);
            this.ABOUT_BTN.TabIndex = 9;
            this.ABOUT_BTN.Text = "About";
            this.ABOUT_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ABOUT_BTN.UseVisualStyleBackColor = true;
            this.ABOUT_BTN.Click += new System.EventHandler(this.ABOUT_BTN_Click);
            // 
            // SELECTALL_BTN
            // 
            this.SELECTALL_BTN.FlatAppearance.BorderSize = 0;
            this.SELECTALL_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SELECTALL_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SELECTALL_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SELECTALL_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECTALL_BTN.ForeColor = System.Drawing.Color.White;
            this.SELECTALL_BTN.Image = global::BrainOne_IDE.Properties.Resources.SELECTALL_PIC;
            this.SELECTALL_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SELECTALL_BTN.Location = new System.Drawing.Point(410, 35);
            this.SELECTALL_BTN.Name = "SELECTALL_BTN";
            this.SELECTALL_BTN.Size = new System.Drawing.Size(70, 52);
            this.SELECTALL_BTN.TabIndex = 9;
            this.SELECTALL_BTN.Text = "Select All";
            this.SELECTALL_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SELECTALL_BTN.UseVisualStyleBackColor = true;
            this.SELECTALL_BTN.Click += new System.EventHandler(this.SELECTALL_BTN_Click);
            // 
            // DELETE_BTN
            // 
            this.DELETE_BTN.FlatAppearance.BorderSize = 0;
            this.DELETE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DELETE_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DELETE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELETE_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE_BTN.ForeColor = System.Drawing.Color.White;
            this.DELETE_BTN.Image = global::BrainOne_IDE.Properties.Resources.DETETE_PIC;
            this.DELETE_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DELETE_BTN.Location = new System.Drawing.Point(344, 34);
            this.DELETE_BTN.Name = "DELETE_BTN";
            this.DELETE_BTN.Size = new System.Drawing.Size(60, 52);
            this.DELETE_BTN.TabIndex = 9;
            this.DELETE_BTN.Text = "Delete";
            this.DELETE_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DELETE_BTN.UseVisualStyleBackColor = true;
            this.DELETE_BTN.Click += new System.EventHandler(this.DELETE_BTN_Click);
            // 
            // PASTE_BTN
            // 
            this.PASTE_BTN.FlatAppearance.BorderSize = 0;
            this.PASTE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PASTE_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PASTE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PASTE_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASTE_BTN.ForeColor = System.Drawing.Color.White;
            this.PASTE_BTN.Image = global::BrainOne_IDE.Properties.Resources.PASTE_PIC;
            this.PASTE_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PASTE_BTN.Location = new System.Drawing.Point(278, 34);
            this.PASTE_BTN.Name = "PASTE_BTN";
            this.PASTE_BTN.Size = new System.Drawing.Size(60, 52);
            this.PASTE_BTN.TabIndex = 9;
            this.PASTE_BTN.Text = "Paste";
            this.PASTE_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PASTE_BTN.UseVisualStyleBackColor = true;
            this.PASTE_BTN.Click += new System.EventHandler(this.PASTE_BTN_Click);
            // 
            // CUT_BTN
            // 
            this.CUT_BTN.FlatAppearance.BorderSize = 0;
            this.CUT_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CUT_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CUT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CUT_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUT_BTN.ForeColor = System.Drawing.Color.White;
            this.CUT_BTN.Image = global::BrainOne_IDE.Properties.Resources.CUT_PIC;
            this.CUT_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CUT_BTN.Location = new System.Drawing.Point(146, 34);
            this.CUT_BTN.Name = "CUT_BTN";
            this.CUT_BTN.Size = new System.Drawing.Size(60, 52);
            this.CUT_BTN.TabIndex = 9;
            this.CUT_BTN.Text = "Cut";
            this.CUT_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CUT_BTN.UseVisualStyleBackColor = true;
            this.CUT_BTN.Click += new System.EventHandler(this.CUT_BTN_Click);
            // 
            // REDO_BTN
            // 
            this.REDO_BTN.FlatAppearance.BorderSize = 0;
            this.REDO_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.REDO_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.REDO_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REDO_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REDO_BTN.ForeColor = System.Drawing.Color.White;
            this.REDO_BTN.Image = global::BrainOne_IDE.Properties.Resources.REDO_PIC;
            this.REDO_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.REDO_BTN.Location = new System.Drawing.Point(80, 34);
            this.REDO_BTN.Name = "REDO_BTN";
            this.REDO_BTN.Size = new System.Drawing.Size(60, 52);
            this.REDO_BTN.TabIndex = 9;
            this.REDO_BTN.Text = "Redo";
            this.REDO_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.REDO_BTN.UseVisualStyleBackColor = true;
            this.REDO_BTN.Click += new System.EventHandler(this.REDO_BTN_Click);
            // 
            // UNDO_BTN
            // 
            this.UNDO_BTN.FlatAppearance.BorderSize = 0;
            this.UNDO_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.UNDO_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.UNDO_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UNDO_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNDO_BTN.ForeColor = System.Drawing.Color.White;
            this.UNDO_BTN.Image = global::BrainOne_IDE.Properties.Resources.UNDO_PIC;
            this.UNDO_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UNDO_BTN.Location = new System.Drawing.Point(14, 34);
            this.UNDO_BTN.Name = "UNDO_BTN";
            this.UNDO_BTN.Size = new System.Drawing.Size(60, 52);
            this.UNDO_BTN.TabIndex = 9;
            this.UNDO_BTN.Text = "Undo";
            this.UNDO_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UNDO_BTN.UseVisualStyleBackColor = true;
            this.UNDO_BTN.Click += new System.EventHandler(this.UNDO_BTN_Click);
            // 
            // PROJ_PATH_LBL
            // 
            this.PROJ_PATH_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PROJ_PATH_LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROJ_PATH_LBL.ForeColor = System.Drawing.Color.White;
            this.PROJ_PATH_LBL.Location = new System.Drawing.Point(123, 7);
            this.PROJ_PATH_LBL.Name = "PROJ_PATH_LBL";
            this.PROJ_PATH_LBL.Size = new System.Drawing.Size(635, 17);
            this.PROJ_PATH_LBL.TabIndex = 7;
            this.PROJ_PATH_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PROJ_PATH_TXT_MouseDown);
            // 
            // RUN_BTN
            // 
            this.RUN_BTN.FlatAppearance.BorderSize = 0;
            this.RUN_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.RUN_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RUN_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RUN_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUN_BTN.ForeColor = System.Drawing.Color.White;
            this.RUN_BTN.Image = global::BrainOne_IDE.Properties.Resources.RUN_PIC;
            this.RUN_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RUN_BTN.Location = new System.Drawing.Point(449, 93);
            this.RUN_BTN.Name = "RUN_BTN";
            this.RUN_BTN.Size = new System.Drawing.Size(82, 25);
            this.RUN_BTN.TabIndex = 4;
            this.RUN_BTN.Text = "     &Run";
            this.RUN_BTN.UseVisualStyleBackColor = true;
            this.RUN_BTN.Click += new System.EventHandler(this.RUN_BTN_Click);
            // 
            // BUILD_BTN
            // 
            this.BUILD_BTN.FlatAppearance.BorderSize = 0;
            this.BUILD_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BUILD_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BUILD_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUILD_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUILD_BTN.ForeColor = System.Drawing.Color.White;
            this.BUILD_BTN.Image = global::BrainOne_IDE.Properties.Resources.BUILD_PIC;
            this.BUILD_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUILD_BTN.Location = new System.Drawing.Point(361, 93);
            this.BUILD_BTN.Name = "BUILD_BTN";
            this.BUILD_BTN.Size = new System.Drawing.Size(82, 25);
            this.BUILD_BTN.TabIndex = 4;
            this.BUILD_BTN.Text = "      &Build";
            this.BUILD_BTN.UseVisualStyleBackColor = true;
            this.BUILD_BTN.Click += new System.EventHandler(this.BUILD_BTN_Click);
            // 
            // SAVEAS_BTN
            // 
            this.SAVEAS_BTN.FlatAppearance.BorderSize = 0;
            this.SAVEAS_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SAVEAS_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SAVEAS_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVEAS_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEAS_BTN.ForeColor = System.Drawing.Color.White;
            this.SAVEAS_BTN.Image = global::BrainOne_IDE.Properties.Resources.SAVEAS_PIC;
            this.SAVEAS_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SAVEAS_BTN.Location = new System.Drawing.Point(266, 93);
            this.SAVEAS_BTN.Name = "SAVEAS_BTN";
            this.SAVEAS_BTN.Size = new System.Drawing.Size(82, 25);
            this.SAVEAS_BTN.TabIndex = 4;
            this.SAVEAS_BTN.Text = "     &Save As";
            this.SAVEAS_BTN.UseVisualStyleBackColor = true;
            this.SAVEAS_BTN.Click += new System.EventHandler(this.SAVEAS_BTN_Click);
            // 
            // SAVE_BTN
            // 
            this.SAVE_BTN.FlatAppearance.BorderSize = 0;
            this.SAVE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SAVE_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SAVE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE_BTN.ForeColor = System.Drawing.Color.White;
            this.SAVE_BTN.Image = global::BrainOne_IDE.Properties.Resources.SAVE_PIC;
            this.SAVE_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SAVE_BTN.Location = new System.Drawing.Point(182, 93);
            this.SAVE_BTN.Name = "SAVE_BTN";
            this.SAVE_BTN.Size = new System.Drawing.Size(82, 25);
            this.SAVE_BTN.TabIndex = 4;
            this.SAVE_BTN.Text = "     &Save";
            this.SAVE_BTN.UseVisualStyleBackColor = true;
            this.SAVE_BTN.Click += new System.EventHandler(this.SAVE_BTN_Click);
            // 
            // OPEN_BTN
            // 
            this.OPEN_BTN.FlatAppearance.BorderSize = 0;
            this.OPEN_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.OPEN_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OPEN_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OPEN_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPEN_BTN.ForeColor = System.Drawing.Color.White;
            this.OPEN_BTN.Image = global::BrainOne_IDE.Properties.Resources.OPEN_PIC;
            this.OPEN_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OPEN_BTN.Location = new System.Drawing.Point(98, 93);
            this.OPEN_BTN.Name = "OPEN_BTN";
            this.OPEN_BTN.Size = new System.Drawing.Size(82, 25);
            this.OPEN_BTN.TabIndex = 4;
            this.OPEN_BTN.Text = "     &Open";
            this.OPEN_BTN.UseVisualStyleBackColor = true;
            this.OPEN_BTN.Click += new System.EventHandler(this.OPEN_BTN_Click);
            // 
            // NEW_BTN
            // 
            this.NEW_BTN.FlatAppearance.BorderSize = 0;
            this.NEW_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NEW_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NEW_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NEW_BTN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW_BTN.ForeColor = System.Drawing.Color.White;
            this.NEW_BTN.Image = global::BrainOne_IDE.Properties.Resources.NEW_PIC;
            this.NEW_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NEW_BTN.Location = new System.Drawing.Point(14, 93);
            this.NEW_BTN.Name = "NEW_BTN";
            this.NEW_BTN.Size = new System.Drawing.Size(82, 25);
            this.NEW_BTN.TabIndex = 4;
            this.NEW_BTN.Text = "     &New";
            this.NEW_BTN.UseVisualStyleBackColor = true;
            this.NEW_BTN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Title_LBL
            // 
            this.Title_LBL.AutoSize = true;
            this.Title_LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_LBL.ForeColor = System.Drawing.Color.White;
            this.Title_LBL.Location = new System.Drawing.Point(11, 8);
            this.Title_LBL.Name = "Title_LBL";
            this.Title_LBL.Size = new System.Drawing.Size(100, 15);
            this.Title_LBL.TabIndex = 3;
            this.Title_LBL.Text = "BrainOne IDE v1.0";
            this.Title_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // Bottom_PNL
            // 
            this.Bottom_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bottom_PNL.BackColor = System.Drawing.SystemColors.Highlight;
            this.Bottom_PNL.Controls.Add(this.STATUS_LBL);
            this.Bottom_PNL.Location = new System.Drawing.Point(1, 567);
            this.Bottom_PNL.Name = "Bottom_PNL";
            this.Bottom_PNL.Size = new System.Drawing.Size(862, 23);
            this.Bottom_PNL.TabIndex = 1;
            // 
            // STATUS_LBL
            // 
            this.STATUS_LBL.AutoSize = true;
            this.STATUS_LBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS_LBL.ForeColor = System.Drawing.Color.White;
            this.STATUS_LBL.Location = new System.Drawing.Point(5, 3);
            this.STATUS_LBL.Name = "STATUS_LBL";
            this.STATUS_LBL.Size = new System.Drawing.Size(43, 17);
            this.STATUS_LBL.TabIndex = 0;
            this.STATUS_LBL.Text = "Status";
            // 
            // Editor_TXT
            // 
            this.Editor_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor_TXT.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.AUTO_COM_MENU.SetAutocompleteMenu(this.Editor_TXT, this.AUTO_COM_MENU);
            this.Editor_TXT.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.Editor_TXT.AutoScrollMinSize = new System.Drawing.Size(0, 17);
            this.Editor_TXT.BackBrush = null;
            this.Editor_TXT.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.Editor_TXT.CharHeight = 17;
            this.Editor_TXT.CharWidth = 8;
            this.Editor_TXT.ContextMenuStrip = this.CON_MNU_STRIP;
            this.Editor_TXT.CurrentLineColor = System.Drawing.Color.DarkGray;
            this.Editor_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Editor_TXT.DisabledColor = System.Drawing.Color.White;
            this.Editor_TXT.Enabled = false;
            this.Editor_TXT.FindEndOfFoldingBlockStrategy = FastColoredTextBoxNS.FindEndOfFoldingBlockStrategy.Strategy2;
            this.Editor_TXT.FoldingIndicatorColor = System.Drawing.Color.DeepSkyBlue;
            this.Editor_TXT.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Editor_TXT.ForeColor = System.Drawing.Color.Black;
            this.Editor_TXT.Hotkeys = resources.GetString("Editor_TXT.Hotkeys");
            this.Editor_TXT.IndentBackColor = System.Drawing.Color.Gainsboro;
            this.Editor_TXT.IsReplaceMode = false;
            this.Editor_TXT.Language = FastColoredTextBoxNS.Language.CSharp;
            this.Editor_TXT.LeftBracket = '(';
            this.Editor_TXT.LeftBracket2 = '{';
            this.Editor_TXT.LineNumberColor = System.Drawing.Color.DimGray;
            this.Editor_TXT.Location = new System.Drawing.Point(1, 126);
            this.Editor_TXT.Name = "Editor_TXT";
            this.Editor_TXT.Paddings = new System.Windows.Forms.Padding(0);
            this.Editor_TXT.RightBracket = ')';
            this.Editor_TXT.RightBracket2 = '}';
            this.Editor_TXT.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Editor_TXT.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Editor_TXT.ServiceColors")));
            this.Editor_TXT.ShowScrollBars = false;
            this.Editor_TXT.Size = new System.Drawing.Size(730, 442);
            this.Editor_TXT.TabIndex = 2;
            this.Editor_TXT.WordWrap = true;
            this.Editor_TXT.Zoom = 100;
            this.Editor_TXT.TextChanging += new System.EventHandler<FastColoredTextBoxNS.TextChangingEventArgs>(this.Editor_TXT_TextChanging);
            // 
            // CON_MNU_STRIP
            // 
            this.CON_MNU_STRIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CON_MNU_STRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripSeparator5,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator6,
            this.selectAllToolStripMenuItem1});
            this.CON_MNU_STRIP.Name = "CON_MNU_STRIP";
            this.CON_MNU_STRIP.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CON_MNU_STRIP.ShowCheckMargin = true;
            this.CON_MNU_STRIP.ShowImageMargin = false;
            this.CON_MNU_STRIP.ShowItemToolTips = false;
            this.CON_MNU_STRIP.Size = new System.Drawing.Size(165, 170);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.redoToolStripMenuItem1.Text = "Redo";
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // documentMap1
            // 
            this.documentMap1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentMap1.BackColor = System.Drawing.SystemColors.Menu;
            this.documentMap1.ForeColor = System.Drawing.Color.Black;
            this.documentMap1.Location = new System.Drawing.Point(732, 126);
            this.documentMap1.Name = "documentMap1";
            this.documentMap1.Size = new System.Drawing.Size(131, 442);
            this.documentMap1.TabIndex = 5;
            this.documentMap1.Target = this.Editor_TXT;
            // 
            // AUTO_COM_MENU
            // 
            this.AUTO_COM_MENU.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("AUTO_COM_MENU.Colors")));
            this.AUTO_COM_MENU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUTO_COM_MENU.ImageList = null;
            this.AUTO_COM_MENU.Items = new string[] {
        "asm",
        "else",
        "new",
        "this",
        "auto",
        "enum",
        "operator",
        "throw",
        "bool",
        "explicit",
        "private",
        "true",
        "break",
        "export",
        "protected",
        "try",
        "case",
        "extern",
        "public",
        "typedef",
        "catch",
        "false",
        "register",
        "typeid",
        "char",
        "float",
        "reinterpret_cast",
        "typename",
        "class",
        "for",
        "return",
        "union",
        "const",
        "friend",
        "short",
        "unsigned",
        "const_cast\tgoto",
        "signed",
        "using",
        "continue",
        "if",
        "sizeof",
        "virtual",
        "default",
        "inline",
        "static",
        "void",
        "delete",
        "int",
        "static_cast\tvolatile",
        "do",
        "long",
        "struct",
        "wchar_t",
        "double",
        "mutable",
        "switch",
        "while",
        "And",
        "bitor",
        "not_eq",
        "xor",
        "and_eq",
        "compl",
        "or",
        "xor_eq",
        "bitand",
        "not",
        "or_eq",
        "cout",
        "cin",
        "main",
        "include"};
            this.AUTO_COM_MENU.LeftPadding = 0;
            this.AUTO_COM_MENU.MinFragmentLength = 1;
            this.AUTO_COM_MENU.TargetControlWrapper = null;
            // 
            // SF_DIALOG
            // 
            this.SF_DIALOG.Title = "Save As...";
            // 
            // OF_DIALOG
            // 
            this.OF_DIALOG.RestoreDirectory = true;
            // 
            // MAIN_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 591);
            this.Controls.Add(this.documentMap1);
            this.Controls.Add(this.Editor_TXT);
            this.Controls.Add(this.Bottom_PNL);
            this.Controls.Add(this.Top_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(230, 149);
            this.Name = "MAIN_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrainOne IDE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MAIN_FRM_FormClosed);
            this.Load += new System.EventHandler(this.Mian_FRM_Load);
            this.Resize += new System.EventHandler(this.Mian_FRM_Resize);
            this.Top_PNL.ResumeLayout(false);
            this.Top_PNL.PerformLayout();
            this.Bottom_PNL.ResumeLayout(false);
            this.Bottom_PNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor_TXT)).EndInit();
            this.CON_MNU_STRIP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_PNL;
        private System.Windows.Forms.Panel Bottom_PNL;
        private FastColoredTextBoxNS.DocumentMap documentMap1;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.Button Minimum_BTN;
        private System.Windows.Forms.Button Maximum_BTN;
        private System.Windows.Forms.Label Title_LBL;
        private AutocompleteMenuNS.AutocompleteMenu AUTO_COM_MENU;
        private System.Windows.Forms.Button RUN_BTN;
        private System.Windows.Forms.Button BUILD_BTN;
        private System.Windows.Forms.Button SAVEAS_BTN;
        private System.Windows.Forms.Button SAVE_BTN;
        private System.Windows.Forms.Button OPEN_BTN;
        private System.Windows.Forms.Button NEW_BTN;
        public FastColoredTextBoxNS.FastColoredTextBox Editor_TXT;
        public System.Windows.Forms.Label STATUS_LBL;
        private System.Windows.Forms.SaveFileDialog SF_DIALOG;
        private System.Windows.Forms.OpenFileDialog OF_DIALOG;
        public System.Windows.Forms.Label PROJ_PATH_LBL;
        private System.Windows.Forms.ContextMenuStrip CON_MNU_STRIP;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.Button UNDO_BTN;
        private System.Windows.Forms.Button LOCK_BTN;
        private System.Windows.Forms.Button LINENUMBERS_BTN;
        private System.Windows.Forms.Button CURRENTLINE_BTN;
        private System.Windows.Forms.Button COPY_BTN;
        private System.Windows.Forms.Button DELETE_BTN;
        private System.Windows.Forms.Button PASTE_BTN;
        private System.Windows.Forms.Button CUT_BTN;
        private System.Windows.Forms.Button REDO_BTN;
        private System.Windows.Forms.Button SELECTALL_BTN;
        private System.Windows.Forms.Label LINE2;
        private System.Windows.Forms.Label LINE1;
        private System.Windows.Forms.Button ABOUT_BTN;
        private System.Windows.Forms.Label LINE3;
        private System.Windows.Forms.Button LIKE_BTN;
        private System.Windows.Forms.Label LINE4;
    }
}

