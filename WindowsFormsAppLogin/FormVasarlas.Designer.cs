namespace WindowsFormsAppLogin
{
    partial class FormVasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVasarlas));
            this.listBox_termekek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_termekid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_termeknev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ar = new System.Windows.Forms.TextBox();
            this.numericUpDown_db = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button_vasarlas = new System.Windows.Forms.Button();
            this.textBox_vegosszeg = new System.Windows.Forms.TextBox();
            this.listBox_kosar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_termekek
            // 
            this.listBox_termekek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_termekek.FormattingEnabled = true;
            this.listBox_termekek.Location = new System.Drawing.Point(0, 0);
            this.listBox_termekek.Name = "listBox_termekek";
            this.listBox_termekek.Size = new System.Drawing.Size(120, 450);
            this.listBox_termekek.TabIndex = 0;
            this.listBox_termekek.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(126, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBox_termekid
            // 
            this.textBox_termekid.Location = new System.Drawing.Point(129, 50);
            this.textBox_termekid.Name = "textBox_termekid";
            this.textBox_termekid.Size = new System.Drawing.Size(100, 20);
            this.textBox_termekid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(126, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név";
            // 
            // textBox_termeknev
            // 
            this.textBox_termeknev.Location = new System.Drawing.Point(129, 110);
            this.textBox_termeknev.Name = "textBox_termeknev";
            this.textBox_termeknev.Size = new System.Drawing.Size(100, 20);
            this.textBox_termeknev.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(127, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ár";
            // 
            // textBox_ar
            // 
            this.textBox_ar.Location = new System.Drawing.Point(129, 188);
            this.textBox_ar.Name = "textBox_ar";
            this.textBox_ar.Size = new System.Drawing.Size(100, 20);
            this.textBox_ar.TabIndex = 6;
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Location = new System.Drawing.Point(126, 250);
            this.numericUpDown_db.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown_db.Name = "numericUpDown_db";
            this.numericUpDown_db.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_db.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(127, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "DB";
            // 
            // button_vasarlas
            // 
            this.button_vasarlas.Location = new System.Drawing.Point(130, 313);
            this.button_vasarlas.Name = "button_vasarlas";
            this.button_vasarlas.Size = new System.Drawing.Size(75, 23);
            this.button_vasarlas.TabIndex = 9;
            this.button_vasarlas.Text = "Vásárlás";
            this.button_vasarlas.UseVisualStyleBackColor = true;
            this.button_vasarlas.Click += new System.EventHandler(this.button_vasarlas_Click);
            // 
            // textBox_vegosszeg
            // 
            this.textBox_vegosszeg.Location = new System.Drawing.Point(129, 353);
            this.textBox_vegosszeg.Name = "textBox_vegosszeg";
            this.textBox_vegosszeg.Size = new System.Drawing.Size(100, 20);
            this.textBox_vegosszeg.TabIndex = 10;
            this.textBox_vegosszeg.TextChanged += new System.EventHandler(this.textBox_vegosszeg_TextChanged);
            // 
            // listBox_kosar
            // 
            this.listBox_kosar.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_kosar.FormattingEnabled = true;
            this.listBox_kosar.Location = new System.Drawing.Point(680, 0);
            this.listBox_kosar.Name = "listBox_kosar";
            this.listBox_kosar.Size = new System.Drawing.Size(120, 450);
            this.listBox_kosar.TabIndex = 11;
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_kosar);
            this.Controls.Add(this.textBox_vegosszeg);
            this.Controls.Add(this.button_vasarlas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_db);
            this.Controls.Add(this.textBox_ar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_termeknev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_termekid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_termekek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVasarlas";
            this.Text = "FormVasarlas";
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_termekek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_termekid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_termeknev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ar;
        private System.Windows.Forms.NumericUpDown numericUpDown_db;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_vasarlas;
        private System.Windows.Forms.TextBox textBox_vegosszeg;
        private System.Windows.Forms.ListBox listBox_kosar;
    }
}