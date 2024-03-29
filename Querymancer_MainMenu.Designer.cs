﻿
namespace Querymancer
{
    partial class Querymancer_MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Querymancer_MainMenu));
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Right_Border = new System.Windows.Forms.Panel();
            this.Left_Border = new System.Windows.Forms.Panel();
            this.Top_Border = new System.Windows.Forms.Panel();
            this.Bottom_Border = new System.Windows.Forms.Panel();
            this.Query_DataGridView = new System.Windows.Forms.DataGridView();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteSQLQuery_Button = new System.Windows.Forms.Button();
            this.Minimize_PictureBox = new System.Windows.Forms.PictureBox();
            this.Exit_PictureBox = new System.Windows.Forms.PictureBox();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.querymancerDataSet = new Querymancer.QuerymancerDataSet();
            this.queryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.query_TableTableAdapter = new Querymancer.QuerymancerDataSetTableAdapters.Query_TableTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mid_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Query_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querymancerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Mid_Panel.Controls.Add(this.ExecuteSQLQuery_Button);
            this.Mid_Panel.Controls.Add(this.QueryTextBox);
            this.Mid_Panel.Controls.Add(this.Query_DataGridView);
            this.Mid_Panel.Controls.Add(this.Minimize_PictureBox);
            this.Mid_Panel.Controls.Add(this.Exit_PictureBox);
            this.Mid_Panel.Controls.Add(this.Logo_PictureBox);
            this.Mid_Panel.Controls.Add(this.Bottom_Border);
            this.Mid_Panel.Controls.Add(this.Top_Border);
            this.Mid_Panel.Controls.Add(this.Left_Border);
            this.Mid_Panel.Controls.Add(this.Right_Border);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(800, 500);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Right_Border
            // 
            this.Right_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Right_Border.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_Border.Location = new System.Drawing.Point(798, 0);
            this.Right_Border.Name = "Right_Border";
            this.Right_Border.Size = new System.Drawing.Size(2, 500);
            this.Right_Border.TabIndex = 0;
            // 
            // Left_Border
            // 
            this.Left_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Left_Border.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Border.Location = new System.Drawing.Point(0, 0);
            this.Left_Border.Name = "Left_Border";
            this.Left_Border.Size = new System.Drawing.Size(2, 500);
            this.Left_Border.TabIndex = 1;
            // 
            // Top_Border
            // 
            this.Top_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Top_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Border.Location = new System.Drawing.Point(2, 0);
            this.Top_Border.Name = "Top_Border";
            this.Top_Border.Size = new System.Drawing.Size(796, 2);
            this.Top_Border.TabIndex = 2;
            // 
            // Bottom_Border
            // 
            this.Bottom_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Bottom_Border.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Border.Location = new System.Drawing.Point(2, 498);
            this.Bottom_Border.Name = "Bottom_Border";
            this.Bottom_Border.Size = new System.Drawing.Size(796, 2);
            this.Bottom_Border.TabIndex = 3;
            // 
            // Query_DataGridView
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.Query_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Query_DataGridView.AutoGenerateColumns = false;
            this.Query_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Query_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Query_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Query_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Query_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userSurnameDataGridViewTextBoxColumn,
            this.userAgeDataGridViewTextBoxColumn,
            this.userBloodGroupDataGridViewTextBoxColumn,
            this.userFieldDataGridViewTextBoxColumn});
            this.Query_DataGridView.DataSource = this.queryTableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Query_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Query_DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Query_DataGridView.Location = new System.Drawing.Point(2, 230);
            this.Query_DataGridView.Name = "Query_DataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Query_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Query_DataGridView.Size = new System.Drawing.Size(796, 268);
            this.Query_DataGridView.TabIndex = 7;
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.QueryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.QueryTextBox.Location = new System.Drawing.Point(25, 129);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(751, 27);
            this.QueryTextBox.TabIndex = 8;
            this.QueryTextBox.Text = "  Enter Query:";
            this.QueryTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QueryTextBox_MouseClick);
            // 
            // ExecuteSQLQuery_Button
            // 
            this.ExecuteSQLQuery_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.ExecuteSQLQuery_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteSQLQuery_Button.FlatAppearance.BorderSize = 0;
            this.ExecuteSQLQuery_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.ExecuteSQLQuery_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.ExecuteSQLQuery_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteSQLQuery_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExecuteSQLQuery_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.ExecuteSQLQuery_Button.Image = global::Querymancer.Properties.Resources.Querymancer_ExecuteIcon;
            this.ExecuteSQLQuery_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExecuteSQLQuery_Button.Location = new System.Drawing.Point(25, 175);
            this.ExecuteSQLQuery_Button.Name = "ExecuteSQLQuery_Button";
            this.ExecuteSQLQuery_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.ExecuteSQLQuery_Button.Size = new System.Drawing.Size(751, 35);
            this.ExecuteSQLQuery_Button.TabIndex = 9;
            this.ExecuteSQLQuery_Button.Text = "Execute SQL Query";
            this.ExecuteSQLQuery_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecuteSQLQuery_Button.UseVisualStyleBackColor = false;
            this.ExecuteSQLQuery_Button.Click += new System.EventHandler(this.ExecuteSQLQuery_Button_Click);
            // 
            // Minimize_PictureBox
            // 
            this.Minimize_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_PictureBox.Image = global::Querymancer.Properties.Resources.Querymancer_MinimizeIcon;
            this.Minimize_PictureBox.Location = new System.Drawing.Point(697, 27);
            this.Minimize_PictureBox.Name = "Minimize_PictureBox";
            this.Minimize_PictureBox.Size = new System.Drawing.Size(52, 32);
            this.Minimize_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Minimize_PictureBox.TabIndex = 6;
            this.Minimize_PictureBox.TabStop = false;
            this.Minimize_PictureBox.Click += new System.EventHandler(this.Minimize_PictureBox_Click);
            // 
            // Exit_PictureBox
            // 
            this.Exit_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_PictureBox.Image = global::Querymancer.Properties.Resources.Querymance_ExitIcon;
            this.Exit_PictureBox.Location = new System.Drawing.Point(740, 5);
            this.Exit_PictureBox.Name = "Exit_PictureBox";
            this.Exit_PictureBox.Size = new System.Drawing.Size(52, 55);
            this.Exit_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Exit_PictureBox.TabIndex = 5;
            this.Exit_PictureBox.TabStop = false;
            this.Exit_PictureBox.Click += new System.EventHandler(this.Exit_PictureBox_Click);
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_PictureBox.Image = global::Querymancer.Properties.Resources.Querymancer_Logo;
            this.Logo_PictureBox.Location = new System.Drawing.Point(2, 2);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(796, 109);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo_PictureBox.TabIndex = 4;
            this.Logo_PictureBox.TabStop = false;
            // 
            // querymancerDataSet
            // 
            this.querymancerDataSet.DataSetName = "QuerymancerDataSet";
            this.querymancerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queryTableBindingSource
            // 
            this.queryTableBindingSource.DataMember = "Query_Table";
            this.queryTableBindingSource.DataSource = this.querymancerDataSet;
            // 
            // query_TableTableAdapter
            // 
            this.query_TableTableAdapter.ClearBeforeFill = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userSurnameDataGridViewTextBoxColumn
            // 
            this.userSurnameDataGridViewTextBoxColumn.DataPropertyName = "User_Surname";
            this.userSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.userSurnameDataGridViewTextBoxColumn.Name = "userSurnameDataGridViewTextBoxColumn";
            // 
            // userAgeDataGridViewTextBoxColumn
            // 
            this.userAgeDataGridViewTextBoxColumn.DataPropertyName = "User_Age";
            this.userAgeDataGridViewTextBoxColumn.HeaderText = "Age";
            this.userAgeDataGridViewTextBoxColumn.Name = "userAgeDataGridViewTextBoxColumn";
            // 
            // userBloodGroupDataGridViewTextBoxColumn
            // 
            this.userBloodGroupDataGridViewTextBoxColumn.DataPropertyName = "User_BloodGroup";
            this.userBloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood Group";
            this.userBloodGroupDataGridViewTextBoxColumn.Name = "userBloodGroupDataGridViewTextBoxColumn";
            // 
            // userFieldDataGridViewTextBoxColumn
            // 
            this.userFieldDataGridViewTextBoxColumn.DataPropertyName = "User_Field";
            this.userFieldDataGridViewTextBoxColumn.HeaderText = "Field";
            this.userFieldDataGridViewTextBoxColumn.Name = "userFieldDataGridViewTextBoxColumn";
            // 
            // Querymancer_MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Querymancer_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Querymancer";
            this.Load += new System.EventHandler(this.Querymancer_MainMenu_Load);
            this.Mid_Panel.ResumeLayout(false);
            this.Mid_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Query_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querymancerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.PictureBox Minimize_PictureBox;
        private System.Windows.Forms.PictureBox Exit_PictureBox;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Panel Bottom_Border;
        private System.Windows.Forms.Panel Top_Border;
        private System.Windows.Forms.Panel Left_Border;
        private System.Windows.Forms.Panel Right_Border;
        private System.Windows.Forms.DataGridView Query_DataGridView;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button ExecuteSQLQuery_Button;
        private QuerymancerDataSet querymancerDataSet;
        private System.Windows.Forms.BindingSource queryTableBindingSource;
        private QuerymancerDataSetTableAdapters.Query_TableTableAdapter query_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFieldDataGridViewTextBoxColumn;
    }
}

