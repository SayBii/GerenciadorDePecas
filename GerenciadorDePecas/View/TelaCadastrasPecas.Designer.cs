namespace GerenciadorDePecas.View
{
    partial class TelaCadastrasPecas
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
            this.txtbox_pecas = new System.Windows.Forms.TextBox();
            this.txtbox_marca = new System.Windows.Forms.TextBox();
            this.txtbox_cap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cadastrarpecas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_pecas
            // 
            this.txtbox_pecas.Location = new System.Drawing.Point(69, 96);
            this.txtbox_pecas.Name = "txtbox_pecas";
            this.txtbox_pecas.Size = new System.Drawing.Size(175, 23);
            this.txtbox_pecas.TabIndex = 0;
            // 
            // txtbox_marca
            // 
            this.txtbox_marca.Location = new System.Drawing.Point(69, 152);
            this.txtbox_marca.Name = "txtbox_marca";
            this.txtbox_marca.Size = new System.Drawing.Size(100, 23);
            this.txtbox_marca.TabIndex = 1;
            // 
            // txtbox_cap
            // 
            this.txtbox_cap.Location = new System.Drawing.Point(69, 214);
            this.txtbox_cap.Name = "txtbox_cap";
            this.txtbox_cap.Size = new System.Drawing.Size(175, 23);
            this.txtbox_cap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peças";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marcas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "CADASTRAR PEÇAS";
            // 
            // btn_cadastrarpecas
            // 
            this.btn_cadastrarpecas.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastrarpecas.Location = new System.Drawing.Point(52, 273);
            this.btn_cadastrarpecas.Name = "btn_cadastrarpecas";
            this.btn_cadastrarpecas.Size = new System.Drawing.Size(236, 46);
            this.btn_cadastrarpecas.TabIndex = 7;
            this.btn_cadastrarpecas.Text = "Cadastrar";
            this.btn_cadastrarpecas.UseVisualStyleBackColor = true;
            this.btn_cadastrarpecas.Click += new System.EventHandler(this.btn_cadastrarpecas_Click);
            // 
            // TelaCadastrasPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(334, 341);
            this.Controls.Add(this.btn_cadastrarpecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_cap);
            this.Controls.Add(this.txtbox_marca);
            this.Controls.Add(this.txtbox_pecas);
            this.MaximizeBox = false;
            this.Name = "TelaCadastrasPecas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrasPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbox_pecas;
        private TextBox txtbox_marca;
        private TextBox txtbox_cap;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_cadastrarpecas;
    }
}