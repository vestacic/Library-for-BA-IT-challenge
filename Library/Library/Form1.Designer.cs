namespace Library
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.information = new System.Windows.Forms.ToolStripMenuItem();
            this.forLibrarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveborrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charasteristic = new System.Windows.Forms.ComboBox();
            this.list_display = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.list_name = new System.Windows.Forms.Label();
            this.specific = new System.Windows.Forms.TextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.information,
            this.forLibrarianToolStripMenuItem,
            this.reserveborrowBookToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // information
            // 
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(82, 20);
            this.information.Text = "Information";
            this.information.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // forLibrarianToolStripMenuItem
            // 
            this.forLibrarianToolStripMenuItem.Name = "forLibrarianToolStripMenuItem";
            this.forLibrarianToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.forLibrarianToolStripMenuItem.Text = "For librarian";
            this.forLibrarianToolStripMenuItem.Click += new System.EventHandler(this.forLibrarianToolStripMenuItem_Click);
            // 
            // reserveborrowBookToolStripMenuItem
            // 
            this.reserveborrowBookToolStripMenuItem.Name = "reserveborrowBookToolStripMenuItem";
            this.reserveborrowBookToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.reserveborrowBookToolStripMenuItem.Text = "Reserve/borrow book";
            this.reserveborrowBookToolStripMenuItem.Click += new System.EventHandler(this.reserveborrowBookToolStripMenuItem_Click);
            // 
            // charasteristic
            // 
            this.charasteristic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charasteristic.FormattingEnabled = true;
            this.charasteristic.Location = new System.Drawing.Point(819, 72);
            this.charasteristic.Name = "charasteristic";
            this.charasteristic.Size = new System.Drawing.Size(278, 30);
            this.charasteristic.TabIndex = 1;
            this.charasteristic.Text = "Choose charasteristic";
            // 
            // list_display
            // 
            this.list_display.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_display.Location = new System.Drawing.Point(12, 72);
            this.list_display.Name = "list_display";
            this.list_display.Size = new System.Drawing.Size(801, 244);
            this.list_display.TabIndex = 2;
            this.list_display.Text = "There will be displayed the list of books by your chosen charasteristic...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(819, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show me filtered books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_name
            // 
            this.list_name.AutoSize = true;
            this.list_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_name.Location = new System.Drawing.Point(12, 33);
            this.list_name.Name = "list_name";
            this.list_name.Size = new System.Drawing.Size(238, 24);
            this.list_name.TabIndex = 4;
            this.list_name.Text = "Book list by charasteristic";
            // 
            // specific
            // 
            this.specific.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.specific.Location = new System.Drawing.Point(819, 124);
            this.specific.Name = "specific";
            this.specific.Size = new System.Drawing.Size(278, 29);
            this.specific.TabIndex = 5;
            this.specific.Text = "Enter the exact title or author or etc";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(819, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show full booklist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.specific);
            this.Controls.Add(this.list_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_display);
            this.Controls.Add(this.charasteristic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem information;
        private System.Windows.Forms.ComboBox charasteristic;
        private System.Windows.Forms.RichTextBox list_display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label list_name;
        private System.Windows.Forms.TextBox specific;
        private System.Windows.Forms.ToolStripMenuItem forLibrarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveborrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

