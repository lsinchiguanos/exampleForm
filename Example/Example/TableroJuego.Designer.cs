namespace Example
{
    partial class TableroJuego
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
            this.dgvTablero = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPuntajeB = new System.Windows.Forms.TextBox();
            this.txtPuntajeA = new System.Windows.Forms.TextBox();
            this.lbJugadorB = new System.Windows.Forms.Label();
            this.lbJugadorA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTurnoA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPartidas = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTablero
            // 
            this.dgvTablero.AllowUserToAddRows = false;
            this.dgvTablero.AllowUserToDeleteRows = false;
            this.dgvTablero.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablero.Location = new System.Drawing.Point(12, 12);
            this.dgvTablero.Name = "dgvTablero";
            this.dgvTablero.ReadOnly = true;
            this.dgvTablero.RowTemplate.Height = 24;
            this.dgvTablero.Size = new System.Drawing.Size(739, 491);
            this.dgvTablero.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPuntajeB);
            this.groupBox1.Controls.Add(this.txtPuntajeA);
            this.groupBox1.Controls.Add(this.lbJugadorB);
            this.groupBox1.Controls.Add(this.lbJugadorA);
            this.groupBox1.Location = new System.Drawing.Point(757, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puntajes";
            // 
            // txtPuntajeB
            // 
            this.txtPuntajeB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPuntajeB.Location = new System.Drawing.Point(141, 114);
            this.txtPuntajeB.Name = "txtPuntajeB";
            this.txtPuntajeB.ReadOnly = true;
            this.txtPuntajeB.Size = new System.Drawing.Size(100, 22);
            this.txtPuntajeB.TabIndex = 0;
            this.txtPuntajeB.Text = "0";
            // 
            // txtPuntajeA
            // 
            this.txtPuntajeA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPuntajeA.Location = new System.Drawing.Point(141, 62);
            this.txtPuntajeA.Name = "txtPuntajeA";
            this.txtPuntajeA.ReadOnly = true;
            this.txtPuntajeA.Size = new System.Drawing.Size(100, 22);
            this.txtPuntajeA.TabIndex = 0;
            this.txtPuntajeA.Text = "0";
            // 
            // lbJugadorB
            // 
            this.lbJugadorB.AutoSize = true;
            this.lbJugadorB.Location = new System.Drawing.Point(56, 96);
            this.lbJugadorB.Name = "lbJugadorB";
            this.lbJugadorB.Size = new System.Drawing.Size(73, 17);
            this.lbJugadorB.TabIndex = 0;
            this.lbJugadorB.Text = "JugadorB:";
            // 
            // lbJugadorA
            // 
            this.lbJugadorA.AutoSize = true;
            this.lbJugadorA.Location = new System.Drawing.Point(56, 37);
            this.lbJugadorA.Name = "lbJugadorA";
            this.lbJugadorA.Size = new System.Drawing.Size(73, 17);
            this.lbJugadorA.TabIndex = 0;
            this.lbJugadorA.Text = "JugadorA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTurnoA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbPartidas);
            this.groupBox2.Location = new System.Drawing.Point(757, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 99);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Juegos";
            // 
            // lbTurnoA
            // 
            this.lbTurnoA.AutoSize = true;
            this.lbTurnoA.Location = new System.Drawing.Point(56, 45);
            this.lbTurnoA.Name = "lbTurnoA";
            this.lbTurnoA.Size = new System.Drawing.Size(89, 17);
            this.lbTurnoA.TabIndex = 0;
            this.lbTurnoA.Text = "JUGADOR A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Turno:";
            // 
            // lbPartidas
            // 
            this.lbPartidas.AutoSize = true;
            this.lbPartidas.Location = new System.Drawing.Point(78, 70);
            this.lbPartidas.Name = "lbPartidas";
            this.lbPartidas.Size = new System.Drawing.Size(51, 17);
            this.lbPartidas.TabIndex = 0;
            this.lbPartidas.Text = "2 DE 3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnIniciar);
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Location = new System.Drawing.Point(757, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 211);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btnIniciar
            // 
            this.btnIniciar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIniciar.Location = new System.Drawing.Point(26, 36);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(246, 42);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(26, 140);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(246, 42);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNuevo.Location = new System.Drawing.Point(26, 87);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(246, 42);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // TableroJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTablero);
            this.Name = "TableroJuego";
            this.Text = "Tablero de Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableroJuego_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPuntajeB;
        private System.Windows.Forms.TextBox txtPuntajeA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.DataGridView dgvTablero;
        private System.Windows.Forms.Label lbJugadorB;
        private System.Windows.Forms.Label lbJugadorA;
        private System.Windows.Forms.Label lbPartidas;
        private System.Windows.Forms.Label lbTurnoA;
        private System.Windows.Forms.Button btnNuevo;
    }
}