namespace Projeto4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelX = new Label();
            barraTranslacaoX = new TrackBar();
            labelY = new Label();
            barraTranslacaoY = new TrackBar();
            labelEscala = new Label();
            trackEscala = new TrackBar();
            btnCor1 = new Button();
            btnCor2 = new Button();
            btnCor3 = new Button();
            btnCor4 = new Button();
            btnCor5 = new Button();
            btnCor6 = new Button();
            btnCor7 = new Button();
            btnCor8 = new Button();
            btnCor9 = new Button();
            btnCor10 = new Button();
            ((System.ComponentModel.ISupportInitialize)barraTranslacaoX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barraTranslacaoY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackEscala).BeginInit();
            SuspendLayout();
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(650, 260);
            labelX.Name = "labelX";
            labelX.Size = new Size(84, 15);
            labelX.TabIndex = 0;
            labelX.Text = "Translação X: 0";
            // 
            // barraTranslacaoX
            // 
            barraTranslacaoX.Location = new Point(650, 280);
            barraTranslacaoX.Maximum = 200;
            barraTranslacaoX.Minimum = -200;
            barraTranslacaoX.Name = "barraTranslacaoX";
            barraTranslacaoX.Size = new Size(220, 45);
            barraTranslacaoX.TabIndex = 1;
            barraTranslacaoX.ValueChanged += AtualizarTranslacaoX;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(650, 330);
            labelY.Name = "labelY";
            labelY.Size = new Size(84, 15);
            labelY.TabIndex = 2;
            labelY.Text = "Translação Y: 0";
            // 
            // barraTranslacaoY
            // 
            barraTranslacaoY.Location = new Point(650, 350);
            barraTranslacaoY.Maximum = 200;
            barraTranslacaoY.Minimum = -200;
            barraTranslacaoY.Name = "barraTranslacaoY";
            barraTranslacaoY.Size = new Size(220, 45);
            barraTranslacaoY.TabIndex = 3;
            barraTranslacaoY.ValueChanged += AtualizarTranslacaoY;
            // 
            // labelEscala
            // 
            labelEscala.AutoSize = true;
            labelEscala.Location = new Point(650, 400);
            labelEscala.Name = "labelEscala";
            labelEscala.Size = new Size(73, 15);
            labelEscala.TabIndex = 4;
            labelEscala.Text = "Escala: 100%";
            // 
            // trackEscala
            // 
            trackEscala.Location = new Point(650, 420);
            trackEscala.Maximum = 250;
            trackEscala.Minimum = 20;
            trackEscala.Name = "trackEscala";
            trackEscala.Size = new Size(220, 45);
            trackEscala.TabIndex = 5;
            trackEscala.Value = 100;
            trackEscala.ValueChanged += AtualizarEscala;
            // 
            // btnCor1
            // 
            btnCor1.BackColor = Color.FromArgb(255, 0, 0);
            btnCor1.Location = new Point(650, 72);
            btnCor1.Name = "btnCor1";
            btnCor1.Size = new Size(40, 40);
            btnCor1.TabIndex = 6;
            btnCor1.UseVisualStyleBackColor = false;
            btnCor1.Click += btnCor1_Click;
            // 
            // btnCor2
            // 
            btnCor2.BackColor = Color.FromArgb(0, 0, 255);
            btnCor2.Location = new Point(695, 72);
            btnCor2.Name = "btnCor2";
            btnCor2.Size = new Size(40, 40);
            btnCor2.TabIndex = 7;
            btnCor2.UseVisualStyleBackColor = false;
            btnCor2.Click += btnCor2_Click;
            // 
            // btnCor3
            // 
            btnCor3.BackColor = Color.FromArgb(0, 255, 0);
            btnCor3.Location = new Point(740, 72);
            btnCor3.Name = "btnCor3";
            btnCor3.Size = new Size(40, 40);
            btnCor3.TabIndex = 8;
            btnCor3.UseVisualStyleBackColor = false;
            btnCor3.Click += btnCor3_Click;
            // 
            // btnCor4
            // 
            btnCor4.BackColor = Color.FromArgb(255, 255, 0);
            btnCor4.Location = new Point(785, 72);
            btnCor4.Name = "btnCor4";
            btnCor4.Size = new Size(40, 40);
            btnCor4.TabIndex = 9;
            btnCor4.UseVisualStyleBackColor = false;
            btnCor4.Click += btnCor4_Click;
            // 
            // btnCor5
            // 
            btnCor5.BackColor = Color.FromArgb(255, 165, 0);
            btnCor5.Location = new Point(830, 72);
            btnCor5.Name = "btnCor5";
            btnCor5.Size = new Size(40, 40);
            btnCor5.TabIndex = 10;
            btnCor5.UseVisualStyleBackColor = false;
            btnCor5.Click += btnCor5_Click;
            // 
            // btnCor6
            // 
            btnCor6.BackColor = Color.FromArgb(128, 0, 128);
            btnCor6.Location = new Point(650, 117);
            btnCor6.Name = "btnCor6";
            btnCor6.Size = new Size(40, 40);
            btnCor6.TabIndex = 11;
            btnCor6.UseVisualStyleBackColor = false;
            btnCor6.Click += btnCor6_Click;
            // 
            // btnCor7
            // 
            btnCor7.BackColor = Color.FromArgb(0, 255, 255);
            btnCor7.Location = new Point(695, 117);
            btnCor7.Name = "btnCor7";
            btnCor7.Size = new Size(40, 40);
            btnCor7.TabIndex = 12;
            btnCor7.UseVisualStyleBackColor = false;
            btnCor7.Click += btnCor7_Click;
            // 
            // btnCor8
            // 
            btnCor8.BackColor = Color.FromArgb(139, 69, 19);
            btnCor8.Location = new Point(740, 117);
            btnCor8.Name = "btnCor8";
            btnCor8.Size = new Size(40, 40);
            btnCor8.TabIndex = 13;
            btnCor8.UseVisualStyleBackColor = false;
            btnCor8.Click += btnCor8_Click;
            // 
            // btnCor9
            // 
            btnCor9.BackColor = Color.FromArgb(0, 0, 0);
            btnCor9.Location = new Point(785, 117);
            btnCor9.Name = "btnCor9";
            btnCor9.Size = new Size(40, 40);
            btnCor9.TabIndex = 14;
            btnCor9.UseVisualStyleBackColor = false;
            btnCor9.Click += btnCor9_Click;
            // 
            // btnCor10
            // 
            btnCor10.BackColor = Color.FromArgb(255, 255, 255);
            btnCor10.Location = new Point(830, 117);
            btnCor10.Name = "btnCor10";
            btnCor10.Size = new Size(40, 40);
            btnCor10.TabIndex = 15;
            btnCor10.UseVisualStyleBackColor = false;
            btnCor10.Click += btnCor10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(labelX);
            Controls.Add(barraTranslacaoX);
            Controls.Add(labelY);
            Controls.Add(barraTranslacaoY);
            Controls.Add(labelEscala);
            Controls.Add(trackEscala);
            Controls.Add(btnCor1);
            Controls.Add(btnCor2);
            Controls.Add(btnCor3);
            Controls.Add(btnCor4);
            Controls.Add(btnCor5);
            Controls.Add(btnCor6);
            Controls.Add(btnCor7);
            Controls.Add(btnCor8);
            Controls.Add(btnCor9);
            Controls.Add(btnCor10);
            Name = "Form1";
            Text = "Projeto ICG - Icosaedro 2D";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)barraTranslacaoX).EndInit();
            ((System.ComponentModel.ISupportInitialize)barraTranslacaoY).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackEscala).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Campos dos controles criados no Designer (TrackBars de transformação)
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TrackBar barraTranslacaoX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TrackBar barraTranslacaoY;
        private System.Windows.Forms.Label labelEscala;
        private System.Windows.Forms.TrackBar trackEscala;

        // Campos dos botões de cor (mosaico)
        private System.Windows.Forms.Button btnCor1;
        private System.Windows.Forms.Button btnCor2;
        private System.Windows.Forms.Button btnCor3;
        private System.Windows.Forms.Button btnCor4;
        private System.Windows.Forms.Button btnCor5;
        private System.Windows.Forms.Button btnCor6;
        private System.Windows.Forms.Button btnCor7;
        private System.Windows.Forms.Button btnCor8;
        private System.Windows.Forms.Button btnCor9;
        private System.Windows.Forms.Button btnCor10;
    }
}