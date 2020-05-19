﻿namespace GameZone
{
    partial class Userlist
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respectsPositiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeofLastMessageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeofLastVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.respectsPositiveDataGridViewTextBoxColumn,
            this.messageCountDataGridViewTextBoxColumn,
            this.timeofLastMessageDataGridViewTextBoxColumn,
            this.timeofLastVisitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(GameZone.User);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // respectsPositiveDataGridViewTextBoxColumn
            // 
            this.respectsPositiveDataGridViewTextBoxColumn.DataPropertyName = "RespectsPositive";
            this.respectsPositiveDataGridViewTextBoxColumn.FillWeight = 50F;
            this.respectsPositiveDataGridViewTextBoxColumn.HeaderText = "Уважение";
            this.respectsPositiveDataGridViewTextBoxColumn.Name = "respectsPositiveDataGridViewTextBoxColumn";
            this.respectsPositiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageCountDataGridViewTextBoxColumn
            // 
            this.messageCountDataGridViewTextBoxColumn.DataPropertyName = "MessageCount";
            this.messageCountDataGridViewTextBoxColumn.FillWeight = 50F;
            this.messageCountDataGridViewTextBoxColumn.HeaderText = "Сообщений";
            this.messageCountDataGridViewTextBoxColumn.Name = "messageCountDataGridViewTextBoxColumn";
            this.messageCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeofLastMessageDataGridViewTextBoxColumn
            // 
            this.timeofLastMessageDataGridViewTextBoxColumn.DataPropertyName = "TimeofLastMessage";
            this.timeofLastMessageDataGridViewTextBoxColumn.HeaderText = "Последнее сообщение";
            this.timeofLastMessageDataGridViewTextBoxColumn.Name = "timeofLastMessageDataGridViewTextBoxColumn";
            this.timeofLastMessageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeofLastVisitDataGridViewTextBoxColumn
            // 
            this.timeofLastVisitDataGridViewTextBoxColumn.DataPropertyName = "TimeofLastVisit";
            this.timeofLastVisitDataGridViewTextBoxColumn.HeaderText = "Был";
            this.timeofLastVisitDataGridViewTextBoxColumn.Name = "timeofLastVisitDataGridViewTextBoxColumn";
            this.timeofLastVisitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Userlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 374);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Userlist";
            this.Text = "Userlist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respectsPositiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeofLastMessageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeofLastVisitDataGridViewTextBoxColumn;
    }
}