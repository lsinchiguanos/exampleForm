namespace Example
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNickNameA = new System.Windows.Forms.TextBox();
            this.txtNickNameB = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudJuegos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "JUGADOR A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "JUGADOR B:";
            // 
            // txtNickNameA
            // 
            this.txtNickNameA.Location = new System.Drawing.Point(198, 36);
            this.txtNickNameA.Name = "txtNickNameA";
            this.txtNickNameA.Size = new System.Drawing.Size(205, 22);
            this.txtNickNameA.TabIndex = 1;
            // 
            // txtNickNameB
            // 
            this.txtNickNameB.Location = new System.Drawing.Point(198, 73);
            this.txtNickNameB.Name = "txtNickNameB";
            this.txtNickNameB.Size = new System.Drawing.Size(205, 22);
            this.txtNickNameB.TabIndex = 2;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(92, 153);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(311, 37);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "JUEGOS:";
            // 
            // nudJuegos
            // 
            this.nudJuegos.Location = new System.Drawing.Point(198, 111);
            this.nudJuegos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudJuegos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJuegos.Name = "nudJuegos";
            this.nudJuegos.ReadOnly = true;
            this.nudJuegos.Size = new System.Drawing.Size(205, 22);
            this.nudJuegos.TabIndex = 3;
            this.nudJuegos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 223);
            this.Controls.Add(this.nudJuegos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.txtNickNameB);
            this.Controls.Add(this.txtNickNameA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example";
            ((System.ComponentModel.ISupportInitialize)(this.nudJuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNickNameA;
        private System.Windows.Forms.TextBox txtNickNameB;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudJuegos;
    }
}

