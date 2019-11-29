namespace _1129_GC
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
            this.dtg_datagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_newpokemon = new System.Windows.Forms.Button();
            this.bt_deleteSelected = new System.Windows.Forms.Button();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_datagrid
            // 
            this.dtg_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nev,
            this.tipus});
            this.dtg_datagrid.Location = new System.Drawing.Point(12, 12);
            this.dtg_datagrid.Name = "dtg_datagrid";
            this.dtg_datagrid.Size = new System.Drawing.Size(481, 197);
            this.dtg_datagrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(197, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Típus:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_newpokemon
            // 
            this.bt_newpokemon.Location = new System.Drawing.Point(12, 290);
            this.bt_newpokemon.Name = "bt_newpokemon";
            this.bt_newpokemon.Size = new System.Drawing.Size(323, 50);
            this.bt_newpokemon.TabIndex = 3;
            this.bt_newpokemon.Text = "Új pokemon";
            this.bt_newpokemon.UseVisualStyleBackColor = true;
            this.bt_newpokemon.Click += new System.EventHandler(this.Bt_newpokemon_Click);
            // 
            // bt_deleteSelected
            // 
            this.bt_deleteSelected.Location = new System.Drawing.Point(341, 215);
            this.bt_deleteSelected.Name = "bt_deleteSelected";
            this.bt_deleteSelected.Size = new System.Drawing.Size(152, 125);
            this.bt_deleteSelected.TabIndex = 4;
            this.bt_deleteSelected.Text = "Kijelölt törlése";
            this.bt_deleteSelected.UseVisualStyleBackColor = true;
            this.bt_deleteSelected.Click += new System.EventHandler(this.Bt_deleteSelected_Click);
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(12, 264);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(159, 20);
            this.tb_nev.TabIndex = 5;
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(177, 264);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(158, 20);
            this.tb_tipus.TabIndex = 6;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            // 
            // tipus
            // 
            this.tipus.HeaderText = "Típus";
            this.tipus.Name = "tipus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 352);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.bt_deleteSelected);
            this.Controls.Add(this.bt_newpokemon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_datagrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_newpokemon;
        private System.Windows.Forms.Button bt_deleteSelected;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
    }
}

