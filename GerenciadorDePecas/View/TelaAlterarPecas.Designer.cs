namespace GerenciadorDePecas.View
{
    partial class TelaAlterarPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarPecas));
            this.btn_alterar = new System.Windows.Forms.Button();
            this.txt_alterarcap = new System.Windows.Forms.TextBox();
            this.txt_alterarmarca = new System.Windows.Forms.TextBox();
            this.txt_pesquisaalterar = new System.Windows.Forms.TextBox();
            this.txt_alterarpeca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_alterardados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.Location = new System.Drawing.Point(197, 42);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(59, 29);
            this.btn_alterar.TabIndex = 17;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // txt_alterarcap
            // 
            this.txt_alterarcap.Location = new System.Drawing.Point(36, 236);
            this.txt_alterarcap.Name = "txt_alterarcap";
            this.txt_alterarcap.Size = new System.Drawing.Size(278, 23);
            this.txt_alterarcap.TabIndex = 16;
            // 
            // txt_alterarmarca
            // 
            this.txt_alterarmarca.Location = new System.Drawing.Point(36, 178);
            this.txt_alterarmarca.Name = "txt_alterarmarca";
            this.txt_alterarmarca.Size = new System.Drawing.Size(155, 23);
            this.txt_alterarmarca.TabIndex = 15;
            // 
            // txt_pesquisaalterar
            // 
            this.txt_pesquisaalterar.Location = new System.Drawing.Point(36, 46);
            this.txt_pesquisaalterar.Name = "txt_pesquisaalterar";
            this.txt_pesquisaalterar.Size = new System.Drawing.Size(155, 23);
            this.txt_pesquisaalterar.TabIndex = 14;
            // 
            // txt_alterarpeca
            // 
            this.txt_alterarpeca.Location = new System.Drawing.Point(36, 117);
            this.txt_alterarpeca.Name = "txt_alterarpeca";
            this.txt_alterarpeca.Size = new System.Drawing.Size(229, 23);
            this.txt_alterarpeca.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Capacidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Peças";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite o Código que deseja alterar.";
            // 
            // btn_alterardados
            // 
            this.btn_alterardados.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_alterardados.Location = new System.Drawing.Point(56, 275);
            this.btn_alterardados.Name = "btn_alterardados";
            this.btn_alterardados.Size = new System.Drawing.Size(228, 48);
            this.btn_alterardados.TabIndex = 18;
            this.btn_alterardados.Text = "Alterar os Dados";
            this.btn_alterardados.UseVisualStyleBackColor = true;
            this.btn_alterardados.Click += new System.EventHandler(this.btn_alterardados_Click);
            // 
            // TelaAlterarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(339, 336);
            this.Controls.Add(this.btn_alterardados);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.txt_alterarcap);
            this.Controls.Add(this.txt_alterarmarca);
            this.Controls.Add(this.txt_pesquisaalterar);
            this.Controls.Add(this.txt_alterarpeca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaAlterarPecas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Peças...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_alterar;
        private TextBox txt_alterarcap;
        private TextBox txt_alterarmarca;
        private TextBox txt_pesquisaalterar;
        private TextBox txt_alterarpeca;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_alterardados;
    }
}