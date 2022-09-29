namespace Library
{
    partial class Form3
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
            this.title = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(95, 47);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(140, 26);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(95, 105);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(140, 26);
            this.author.TabIndex = 2;
            this.author.Text = "Author";
            // 
            // publisher
            // 
            this.publisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher.Location = new System.Drawing.Point(95, 162);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(140, 26);
            this.publisher.TabIndex = 3;
            this.publisher.Text = "Publisher";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(95, 217);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(140, 26);
            this.year.TabIndex = 4;
            this.year.Text = "Publishing year";
            // 
            // isbn
            // 
            this.isbn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.Location = new System.Drawing.Point(95, 274);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(140, 26);
            this.isbn.TabIndex = 5;
            this.isbn.Text = "ISBN";
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(95, 331);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(140, 26);
            this.genre.TabIndex = 6;
            this.genre.Text = "Genre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reserve book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Borrow book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.year);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Name = "Form3";
            this.Text = "Reserve/borrow book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}