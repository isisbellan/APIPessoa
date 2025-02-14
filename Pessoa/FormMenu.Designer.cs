namespace Pessoa
{
    partial class FormMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarPessoa = new System.Windows.Forms.Button();
            this.btnBuscarPessoa = new System.Windows.Forms.Button();
            this.btnEditarPessoa = new System.Windows.Forms.Button();
            this.btnRemoverPessoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnAdicionarPessoa
            // 
            this.btnAdicionarPessoa.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPessoa.Location = new System.Drawing.Point(235, 80);
            this.btnAdicionarPessoa.Name = "btnAdicionarPessoa";
            this.btnAdicionarPessoa.Size = new System.Drawing.Size(203, 64);
            this.btnAdicionarPessoa.TabIndex = 1;
            this.btnAdicionarPessoa.Text = "Adicionar pessoa";
            this.btnAdicionarPessoa.UseVisualStyleBackColor = true;
            this.btnAdicionarPessoa.Click += new System.EventHandler(this.btnAdicionarPessoa_Click);
            // 
            // btnBuscarPessoa
            // 
            this.btnBuscarPessoa.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPessoa.Location = new System.Drawing.Point(235, 161);
            this.btnBuscarPessoa.Name = "btnBuscarPessoa";
            this.btnBuscarPessoa.Size = new System.Drawing.Size(203, 64);
            this.btnBuscarPessoa.TabIndex = 2;
            this.btnBuscarPessoa.Text = "Buscar pessoa";
            this.btnBuscarPessoa.UseVisualStyleBackColor = true;
            this.btnBuscarPessoa.Click += new System.EventHandler(this.btnBuscarPessoa_Click);
            // 
            // btnEditarPessoa
            // 
            this.btnEditarPessoa.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPessoa.Location = new System.Drawing.Point(235, 244);
            this.btnEditarPessoa.Name = "btnEditarPessoa";
            this.btnEditarPessoa.Size = new System.Drawing.Size(203, 64);
            this.btnEditarPessoa.TabIndex = 3;
            this.btnEditarPessoa.Text = "Editar pessoa";
            this.btnEditarPessoa.UseVisualStyleBackColor = true;
            this.btnEditarPessoa.Click += new System.EventHandler(this.btnEditarPessoa_Click);
            // 
            // btnRemoverPessoa
            // 
            this.btnRemoverPessoa.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverPessoa.Location = new System.Drawing.Point(235, 331);
            this.btnRemoverPessoa.Name = "btnRemoverPessoa";
            this.btnRemoverPessoa.Size = new System.Drawing.Size(203, 64);
            this.btnRemoverPessoa.TabIndex = 4;
            this.btnRemoverPessoa.Text = "Remover pessoa";
            this.btnRemoverPessoa.UseVisualStyleBackColor = true;
            this.btnRemoverPessoa.Click += new System.EventHandler(this.btnRemoverPessoa_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 421);
            this.Controls.Add(this.btnRemoverPessoa);
            this.Controls.Add(this.btnEditarPessoa);
            this.Controls.Add(this.btnBuscarPessoa);
            this.Controls.Add(this.btnAdicionarPessoa);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.construirBanco_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarPessoa;
        private System.Windows.Forms.Button btnBuscarPessoa;
        private System.Windows.Forms.Button btnEditarPessoa;
        private System.Windows.Forms.Button btnRemoverPessoa;
    }
}