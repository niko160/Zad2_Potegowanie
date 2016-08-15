namespace Potegowanie
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
            this.UndoButton = new System.Windows.Forms.Button();
            this.CountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WynikObliczen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CzasObliczen = new System.Windows.Forms.Label();
            this.Podstawa = new System.Windows.Forms.NumericUpDown();
            this.Wykladnik = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Podstawa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykladnik)).BeginInit();
            this.SuspendLayout();
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(179, 36);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 0;
            this.UndoButton.Text = "Cofnij";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(179, 72);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 23);
            this.CountButton.TabIndex = 1;
            this.CountButton.Text = "Oblicz!";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wynik:";
            // 
            // WynikObliczen
            // 
            this.WynikObliczen.AutoSize = true;
            this.WynikObliczen.Location = new System.Drawing.Point(73, 134);
            this.WynikObliczen.Name = "WynikObliczen";
            this.WynikObliczen.Size = new System.Drawing.Size(13, 13);
            this.WynikObliczen.TabIndex = 3;
            this.WynikObliczen.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Czas:";
            // 
            // CzasObliczen
            // 
            this.CzasObliczen.AutoSize = true;
            this.CzasObliczen.Location = new System.Drawing.Point(73, 163);
            this.CzasObliczen.Name = "CzasObliczen";
            this.CzasObliczen.Size = new System.Drawing.Size(13, 13);
            this.CzasObliczen.TabIndex = 5;
            this.CzasObliczen.Text = "0";
            // 
            // Podstawa
            // 
            this.Podstawa.Location = new System.Drawing.Point(15, 36);
            this.Podstawa.Name = "Podstawa";
            this.Podstawa.Size = new System.Drawing.Size(120, 20);
            this.Podstawa.TabIndex = 8;
            // 
            // Wykladnik
            // 
            this.Wykladnik.Location = new System.Drawing.Point(15, 75);
            this.Wykladnik.Name = "Wykladnik";
            this.Wykladnik.Size = new System.Drawing.Size(120, 20);
            this.Wykladnik.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.Wykladnik);
            this.Controls.Add(this.Podstawa);
            this.Controls.Add(this.CzasObliczen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WynikObliczen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.UndoButton);
            this.Name = "Form1";
            this.Text = "Potegowanie";
            ((System.ComponentModel.ISupportInitialize)(this.Podstawa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wykladnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WynikObliczen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CzasObliczen;
        private System.Windows.Forms.NumericUpDown Podstawa;
        private System.Windows.Forms.NumericUpDown Wykladnik;
    }
}

