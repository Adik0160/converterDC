namespace converterDC
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textUin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIout = new System.Windows.Forms.TextBox();
            this.comboESeries = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUin = new System.Windows.Forms.Label();
            this.labelL1 = new System.Windows.Forms.Label();
            this.labelR1 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz wartości";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uwe [V]:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUin
            // 
            this.textUin.Location = new System.Drawing.Point(63, 10);
            this.textUin.Name = "textUin";
            this.textUin.Size = new System.Drawing.Size(100, 20);
            this.textUin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uwy [V]:";
            // 
            // textUout
            // 
            this.textUout.Location = new System.Drawing.Point(63, 37);
            this.textUout.Name = "textUout";
            this.textUout.Size = new System.Drawing.Size(100, 20);
            this.textUout.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iwy [A]:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textIout
            // 
            this.textIout.Location = new System.Drawing.Point(63, 63);
            this.textIout.Name = "textIout";
            this.textIout.Size = new System.Drawing.Size(100, 20);
            this.textIout.TabIndex = 6;
            // 
            // comboESeries
            // 
            this.comboESeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboESeries.FormattingEnabled = true;
            this.comboESeries.Items.AddRange(new object[] {
            "E12",
            "E24"});
            this.comboESeries.Location = new System.Drawing.Point(118, 89);
            this.comboESeries.Name = "comboESeries";
            this.comboESeries.Size = new System.Drawing.Size(45, 21);
            this.comboESeries.TabIndex = 7;
            this.comboESeries.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tabela szeregów E:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelUin
            // 
            this.labelUin.AutoSize = true;
            this.labelUin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUin.Location = new System.Drawing.Point(247, 42);
            this.labelUin.Name = "labelUin";
            this.labelUin.Size = new System.Drawing.Size(0, 16);
            this.labelUin.TabIndex = 10;
            // 
            // labelL1
            // 
            this.labelL1.AutoSize = true;
            this.labelL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelL1.Location = new System.Drawing.Point(567, 102);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(0, 16);
            this.labelL1.TabIndex = 11;
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelR1.Location = new System.Drawing.Point(567, 176);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(0, 16);
            this.labelR1.TabIndex = 12;
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelR2.Location = new System.Drawing.Point(567, 263);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(0, 16);
            this.labelR2.TabIndex = 13;
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOut.Location = new System.Drawing.Point(745, 123);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(0, 16);
            this.labelOut.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 352);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.labelR1);
            this.Controls.Add(this.labelL1);
            this.Controls.Add(this.labelUin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboESeries);
            this.Controls.Add(this.textIout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUin;
        private System.Windows.Forms.Label labelL1;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.ComboBox comboESeries;
    }
}

