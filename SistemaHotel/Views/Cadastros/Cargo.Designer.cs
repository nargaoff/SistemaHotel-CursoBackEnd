namespace SistemaHotel.Cadastros
{
    partial class FrmCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargo));
            btnExcluir = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnNovo = new System.Windows.Forms.Button();
            grid = new System.Windows.Forms.DataGridView();
            txtNome = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExcluir.Enabled = false;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExcluir.Image = (System.Drawing.Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new System.Drawing.Point(362, 348);
            btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(82, 75);
            btnExcluir.TabIndex = 76;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Image = (System.Drawing.Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new System.Drawing.Point(362, 254);
            btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(82, 75);
            btnEditar.TabIndex = 75;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSalvar.Enabled = false;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalvar.Image = (System.Drawing.Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new System.Drawing.Point(362, 159);
            btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(82, 75);
            btnSalvar.TabIndex = 74;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNovo.Image = (System.Drawing.Image)resources.GetObject("btnNovo.Image");
            btnNovo.Location = new System.Drawing.Point(362, 77);
            btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new System.Drawing.Size(82, 75);
            btnNovo.TabIndex = 73;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += BtnNovo_Click;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.GridColor = System.Drawing.SystemColors.Control;
            grid.Location = new System.Drawing.Point(29, 77);
            grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new System.Drawing.Size(308, 346);
            grid.TabIndex = 72;
            grid.CellClick += Grid_CellClick;
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new System.Drawing.Point(77, 27);
            txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(134, 23);
            txtNome.TabIndex = 69;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 30);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 71;
            label2.Text = "Cargo:";
            // 
            // FrmCargo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(474, 464);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grid);
            Controls.Add(txtNome);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmCargo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cadastro de Cargos";
            Load += FrmCargo_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
    }
}