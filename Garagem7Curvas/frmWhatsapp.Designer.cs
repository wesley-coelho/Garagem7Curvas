namespace Garagem7Curvas
{
    partial class frmWhatsapp
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
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(48, 69);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(264, 22);
            this.tbTelefone.TabIndex = 0;
            // 
            // rtbMsg
            // 
            this.rtbMsg.Location = new System.Drawing.Point(50, 115);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(261, 196);
            this.rtbMsg.TabIndex = 1;
            this.rtbMsg.Text = "Mensagem";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(47, 340);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(264, 32);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Whatsapp";
            // 
            // frmWhatsapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.tbTelefone);
            this.Name = "frmWhatsapp";
            this.Text = "frmWhatsapp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
    }
}