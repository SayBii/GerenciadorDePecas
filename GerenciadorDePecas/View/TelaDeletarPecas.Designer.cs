namespace GerenciadorDePecas.View
{
    partial class TelaDeletarPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeletarPecas));
            this.btn_deletarpecas = new System.Windows.Forms.Button();
            this.btn_pesquisarpecas = new System.Windows.Forms.Button();
            this.txt_deletarcap = new System.Windows.Forms.TextBox();
            this.txt_deletarmarca = new System.Windows.Forms.TextBox();
            this.txt_deletar = new System.Windows.Forms.TextBox();
            this.txt_deletarpecas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_deletarcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_deletarpecas
            // 
            this.btn_deletarpecas.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_deletarpecas.Location = new System.Drawing.Point(74, 332);
            this.btn_deletarpecas.Name = "btn_deletarpecas";
            this.btn_deletarpecas.Size = new System.Drawing.Size(228, 48);
            this.btn_deletarpecas.TabIndex = 28;
            this.btn_deletarpecas.Text = "Deletar os Dados";
            this.btn_deletarpecas.UseVisualStyleBackColor = true;
            this.btn_deletarpecas.Click += new System.EventHandler(this.btn_deletarpecas_Click);
            // 
            // btn_pesquisarpecas
            // 
            this.btn_pesquisarpecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisarpecas.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisarpecas.Image")));
            this.btn_pesquisarpecas.Location = new System.Drawing.Point(197, 42);
            this.btn_pesquisarpecas.Name = "btn_pesquisarpecas";
            this.btn_pesquisarpecas.Size = new System.Drawing.Size(59, 29);
            this.btn_pesquisarpecas.TabIndex = 27;
            this.btn_pesquisarpecas.UseVisualStyleBackColor = true;
            this.btn_pesquisarpecas.Click += new System.EventHandler(this.btn_pesquisarpecas_Click);
            // 
            // txt_deletarcap
            // 
            this.txt_deletarcap.Location = new System.Drawing.Point(36, 274);
            this.txt_deletarcap.Name = "txt_deletarcap";
            this.txt_deletarcap.Size = new System.Drawing.Size(227, 23);
            this.txt_deletarcap.TabIndex = 26;
            // 
            // txt_deletarmarca
            // 
            this.txt_deletarmarca.Location = new System.Drawing.Point(36, 215);
            this.txt_deletarmarca.Name = "txt_deletarmarca";
            this.txt_deletarmarca.Size = new System.Drawing.Size(155, 23);
            this.txt_deletarmarca.TabIndex = 25;
            // 
            // txt_deletar
            // 
            this.txt_deletar.Location = new System.Drawing.Point(36, 46);
            this.txt_deletar.Name = "txt_deletar";
            this.txt_deletar.Size = new System.Drawing.Size(155, 23);
            this.txt_deletar.TabIndex = 24;
            // 
            // txt_deletarpecas
            // 
            this.txt_deletarpecas.Location = new System.Drawing.Point(34, 163);
            this.txt_deletarpecas.Name = "txt_deletarpecas";
            this.txt_deletarpecas.Size = new System.Drawing.Size(229, 23);
            this.txt_deletarpecas.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Capacidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Peças";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Digite o Código que deseja Deletar.";
            // 
            // txt_deletarcod
            // 
            this.txt_deletarcod.Location = new System.Drawing.Point(34, 105);
            this.txt_deletarcod.Name = "txt_deletarcod";
            this.txt_deletarcod.Size = new System.Drawing.Size(157, 23);
            this.txt_deletarcod.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Código";
            // 
            // TelaDeletarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(389, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_deletarcod);
            this.Controls.Add(this.btn_deletarpecas);
            this.Controls.Add(this.btn_pesquisarpecas);
            this.Controls.Add(this.txt_deletarcap);
            this.Controls.Add(this.txt_deletarmarca);
            this.Controls.Add(this.txt_deletar);
            this.Controls.Add(this.txt_deletarpecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaDeletarPecas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDeletarPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_deletarpecas;
        private Button btn_pesquisarpecas;
        private TextBox txt_deletarcap;
        private TextBox txt_deletarmarca;
        private TextBox txt_deletar;
        private TextBox txt_deletarpecas;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_deletarcod;
        private Label label5;
    }
}