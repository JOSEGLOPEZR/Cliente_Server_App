
namespace TCP_IP_Sokets_AppDistribuidas
{
    partial class Cliente
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
            this.LabelServidor = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMensage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelServidor
            // 
            this.LabelServidor.AutoSize = true;
            this.LabelServidor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.LabelServidor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelServidor.Location = new System.Drawing.Point(13, 15);
            this.LabelServidor.Name = "LabelServidor";
            this.LabelServidor.Size = new System.Drawing.Size(75, 19);
            this.LabelServidor.TabIndex = 0;
            this.LabelServidor.Text = "Servidor";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.txtIP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtIP.Location = new System.Drawing.Point(94, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(272, 26);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "\r\n";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviar.Location = new System.Drawing.Point(94, 171);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(84, 30);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.txtInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtInfo.Location = new System.Drawing.Point(94, 39);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(272, 94);
            this.txtInfo.TabIndex = 3;
            // 
            // txtMensage
            // 
            this.txtMensage.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.txtMensage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMensage.Location = new System.Drawing.Point(94, 139);
            this.txtMensage.Name = "txtMensage";
            this.txtMensage.Size = new System.Drawing.Size(272, 26);
            this.txtMensage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(11, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensaje";
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.btnConectar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnConectar.Location = new System.Drawing.Point(255, 171);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(111, 30);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectarse";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TCP_IP_Sokets_AppDistribuidas.Properties.Resources.CLIENTE_USAR1;
            this.pictureBox1.Image = global::TCP_IP_Sokets_AppDistribuidas.Properties.Resources.CLIENTE_USAR;
            this.pictureBox1.InitialImage = global::TCP_IP_Sokets_AppDistribuidas.Properties.Resources.CLIENTE_USAR1;
            this.pictureBox1.Location = new System.Drawing.Point(422, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(597, 210);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtMensage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.LabelServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.Text = "Cliente TCP";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelServidor;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMensage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

