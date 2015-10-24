namespace Cadastro_AmigoOculto
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobreNome = new System.Windows.Forms.Label();
            this.lblPresente1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.txtPresente1 = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.txtPresente2 = new System.Windows.Forms.TextBox();
            this.txtPresente3 = new System.Windows.Forms.TextBox();
            this.lblPresente2 = new System.Windows.Forms.Label();
            this.lblPresente3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(53, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoSize = true;
            this.lblSobreNome.Location = new System.Drawing.Point(22, 46);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.Size = new System.Drawing.Size(61, 13);
            this.lblSobreNome.TabIndex = 1;
            this.lblSobreNome.Text = "Sobrenome";
            // 
            // lblPresente1
            // 
            this.lblPresente1.AutoSize = true;
            this.lblPresente1.Location = new System.Drawing.Point(22, 82);
            this.lblPresente1.Name = "lblPresente1";
            this.lblPresente1.Size = new System.Drawing.Size(61, 13);
            this.lblPresente1.TabIndex = 2;
            this.lblPresente1.Text = "Presente 1:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Location = new System.Drawing.Point(94, 46);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(100, 20);
            this.txtSobreNome.TabIndex = 4;
            // 
            // txtPresente1
            // 
            this.txtPresente1.Location = new System.Drawing.Point(94, 82);
            this.txtPresente1.Multiline = true;
            this.txtPresente1.Name = "txtPresente1";
            this.txtPresente1.Size = new System.Drawing.Size(198, 25);
            this.txtPresente1.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(217, 7);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(217, 41);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 7;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // txtPresente2
            // 
            this.txtPresente2.Location = new System.Drawing.Point(94, 129);
            this.txtPresente2.Name = "txtPresente2";
            this.txtPresente2.Size = new System.Drawing.Size(198, 20);
            this.txtPresente2.TabIndex = 8;
            // 
            // txtPresente3
            // 
            this.txtPresente3.Location = new System.Drawing.Point(94, 175);
            this.txtPresente3.Name = "txtPresente3";
            this.txtPresente3.Size = new System.Drawing.Size(198, 20);
            this.txtPresente3.TabIndex = 9;
            // 
            // lblPresente2
            // 
            this.lblPresente2.AutoSize = true;
            this.lblPresente2.Location = new System.Drawing.Point(28, 136);
            this.lblPresente2.Name = "lblPresente2";
            this.lblPresente2.Size = new System.Drawing.Size(61, 13);
            this.lblPresente2.TabIndex = 10;
            this.lblPresente2.Text = "Presente 2:";
            // 
            // lblPresente3
            // 
            this.lblPresente3.AutoSize = true;
            this.lblPresente3.Location = new System.Drawing.Point(28, 181);
            this.lblPresente3.Name = "lblPresente3";
            this.lblPresente3.Size = new System.Drawing.Size(61, 13);
            this.lblPresente3.TabIndex = 11;
            this.lblPresente3.Text = "Presente 3:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 233);
            this.Controls.Add(this.lblPresente3);
            this.Controls.Add(this.lblPresente2);
            this.Controls.Add(this.txtPresente3);
            this.Controls.Add(this.txtPresente2);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPresente1);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPresente1);
            this.Controls.Add(this.lblSobreNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobreNome;
        private System.Windows.Forms.Label lblPresente1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.TextBox txtPresente1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.TextBox txtPresente2;
        private System.Windows.Forms.TextBox txtPresente3;
        private System.Windows.Forms.Label lblPresente2;
        private System.Windows.Forms.Label lblPresente3;
    }
}

