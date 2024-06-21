namespace WS
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPressao = new System.Windows.Forms.DataGridView();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtSistole = new System.Windows.Forms.TextBox();
            this.txtDiastole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSistole = new System.Windows.Forms.Label();
            this.lblDiastole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPressao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPressao
            // 
            this.dgvPressao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPressao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPressao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPressao.Location = new System.Drawing.Point(386, 3);
            this.dgvPressao.Name = "dgvPressao";
            this.dgvPressao.Size = new System.Drawing.Size(410, 444);
            this.dgvPressao.TabIndex = 0;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(165, 24);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(178, 65);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(9, 20);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(55, 16);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Sístole";
            // 
            // txtSistole
            // 
            this.txtSistole.Location = new System.Drawing.Point(12, 47);
            this.txtSistole.Name = "txtSistole";
            this.txtSistole.Size = new System.Drawing.Size(100, 20);
            this.txtSistole.TabIndex = 3;
            // 
            // txtDiastole
            // 
            this.txtDiastole.Location = new System.Drawing.Point(12, 108);
            this.txtDiastole.Name = "txtDiastole";
            this.txtDiastole.Size = new System.Drawing.Size(100, 20);
            this.txtDiastole.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Diástole";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(120, 167);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(112, 31);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Sístole:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Diástole:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(85, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 10);
            this.panel1.TabIndex = 8;
            // 
            // lblSistole
            // 
            this.lblSistole.AutoSize = true;
            this.lblSistole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSistole.Location = new System.Drawing.Point(149, 207);
            this.lblSistole.Name = "lblSistole";
            this.lblSistole.Size = new System.Drawing.Size(0, 24);
            this.lblSistole.TabIndex = 9;
            // 
            // lblDiastole
            // 
            this.lblDiastole.AutoSize = true;
            this.lblDiastole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiastole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiastole.Location = new System.Drawing.Point(149, 308);
            this.lblDiastole.Name = "lblDiastole";
            this.lblDiastole.Size = new System.Drawing.Size(0, 24);
            this.lblDiastole.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDiastole);
            this.Controls.Add(this.lblSistole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtDiastole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSistole);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dgvPressao);
            this.Name = "FrmPrincipal";
            this.Text = "Formulário Pressão";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPressao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPressao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtSistole;
        private System.Windows.Forms.TextBox txtDiastole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSistole;
        private System.Windows.Forms.Label lblDiastole;
    }
}

