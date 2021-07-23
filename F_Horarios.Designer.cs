
namespace Ale_Academia
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idHorario = new System.Windows.Forms.TextBox();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.tb_dscHorario = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novoH = new System.Windows.Forms.Button();
            this.btn_salvarH = new System.Windows.Forms.Button();
            this.btn_excluirH = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário";
            // 
            // tb_idHorario
            // 
            this.tb_idHorario.Location = new System.Drawing.Point(15, 25);
            this.tb_idHorario.Name = "tb_idHorario";
            this.tb_idHorario.ReadOnly = true;
            this.tb_idHorario.Size = new System.Drawing.Size(57, 20);
            this.tb_idHorario.TabIndex = 2;
            this.tb_idHorario.TabStop = false;
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(12, 51);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(385, 366);
            this.dgv_horarios.TabIndex = 4;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // tb_dscHorario
            // 
            this.tb_dscHorario.Location = new System.Drawing.Point(83, 25);
            this.tb_dscHorario.Mask = "99:99 \\até 99:99";
            this.tb_dscHorario.Name = "tb_dscHorario";
            this.tb_dscHorario.Size = new System.Drawing.Size(100, 20);
            this.tb_dscHorario.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluirH);
            this.panel1.Controls.Add(this.btn_salvarH);
            this.panel1.Controls.Add(this.btn_novoH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 30);
            this.panel1.TabIndex = 6;
            // 
            // btn_novoH
            // 
            this.btn_novoH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoH.Location = new System.Drawing.Point(3, 3);
            this.btn_novoH.Name = "btn_novoH";
            this.btn_novoH.Size = new System.Drawing.Size(96, 23);
            this.btn_novoH.TabIndex = 0;
            this.btn_novoH.Text = "Novo horário";
            this.btn_novoH.UseVisualStyleBackColor = true;
            this.btn_novoH.Click += new System.EventHandler(this.btn_novoH_Click);
            // 
            // btn_salvarH
            // 
            this.btn_salvarH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarH.Location = new System.Drawing.Point(105, 3);
            this.btn_salvarH.Name = "btn_salvarH";
            this.btn_salvarH.Size = new System.Drawing.Size(96, 23);
            this.btn_salvarH.TabIndex = 1;
            this.btn_salvarH.Text = "Salvar horário";
            this.btn_salvarH.UseVisualStyleBackColor = true;
            this.btn_salvarH.Click += new System.EventHandler(this.btn_salvarH_Click);
            // 
            // btn_excluirH
            // 
            this.btn_excluirH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirH.Location = new System.Drawing.Point(207, 3);
            this.btn_excluirH.Name = "btn_excluirH";
            this.btn_excluirH.Size = new System.Drawing.Size(96, 23);
            this.btn_excluirH.TabIndex = 2;
            this.btn_excluirH.Text = "Excluir horário";
            this.btn_excluirH.UseVisualStyleBackColor = true;
            this.btn_excluirH.Click += new System.EventHandler(this.btn_excluirH_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(309, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(96, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_dscHorario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.tb_idHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idHorario;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.MaskedTextBox tb_dscHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluirH;
        private System.Windows.Forms.Button btn_salvarH;
        private System.Windows.Forms.Button btn_novoH;
    }
}