﻿namespace studMin
{
    partial class ClassInfor_SubTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewExport_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SchoolYear_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Filter_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Class_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataTable_Info = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Search_Button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewExport_Button
            // 
            this.DataGridViewExport_Button.Animated = true;
            this.DataGridViewExport_Button.BackColor = System.Drawing.Color.Transparent;
            this.DataGridViewExport_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DataGridViewExport_Button.BorderRadius = 5;
            this.DataGridViewExport_Button.CheckedState.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridViewExport_Button.CustomImages.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DataGridViewExport_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewExport_Button.ForeColor = System.Drawing.Color.White;
            this.DataGridViewExport_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.DataGridViewExport_Button.HoverState.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Location = new System.Drawing.Point(1029, 39);
            this.DataGridViewExport_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewExport_Button.Name = "DataGridViewExport_Button";
            this.DataGridViewExport_Button.ShadowDecoration.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Size = new System.Drawing.Size(191, 44);
            this.DataGridViewExport_Button.TabIndex = 22;
            this.DataGridViewExport_Button.Text = "XUẤT DANH SÁCH";
            this.DataGridViewExport_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.DataGridViewExport_Button.Click += new System.EventHandler(this.DataGridViewExport_Button_Click);
            // 
            // SchoolYear_ComboBox
            // 
            this.SchoolYear_ComboBox.Animated = true;
            this.SchoolYear_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SchoolYear_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.SchoolYear_ComboBox.BorderRadius = 5;
            this.SchoolYear_ComboBox.BorderThickness = 2;
            this.SchoolYear_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SchoolYear_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SchoolYear_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchoolYear_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_ComboBox.FocusedState.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SchoolYear_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SchoolYear_ComboBox.FormattingEnabled = true;
            this.SchoolYear_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_ComboBox.HoverState.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.ItemHeight = 30;
            this.SchoolYear_ComboBox.Items.AddRange(new object[] {
            "Mọi niên khóa"});
            this.SchoolYear_ComboBox.ItemsAppearance.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Location = new System.Drawing.Point(194, 39);
            this.SchoolYear_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SchoolYear_ComboBox.Name = "SchoolYear_ComboBox";
            this.SchoolYear_ComboBox.ShadowDecoration.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Size = new System.Drawing.Size(185, 36);
            this.SchoolYear_ComboBox.StartIndex = 0;
            this.SchoolYear_ComboBox.TabIndex = 20;
            this.SchoolYear_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // Filter_ComboBox
            // 
            this.Filter_ComboBox.Animated = true;
            this.Filter_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Filter_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Filter_ComboBox.BorderRadius = 5;
            this.Filter_ComboBox.BorderThickness = 2;
            this.Filter_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filter_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Filter_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Filter_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Filter_ComboBox.FocusedState.Parent = this.Filter_ComboBox;
            this.Filter_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Filter_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Filter_ComboBox.FormattingEnabled = true;
            this.Filter_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Filter_ComboBox.HoverState.Parent = this.Filter_ComboBox;
            this.Filter_ComboBox.ItemHeight = 30;
            this.Filter_ComboBox.Items.AddRange(new object[] {
            "Danh sách lớp học",
            "Danh sách học sinh",
            "Giáo viên phụ trách"});
            this.Filter_ComboBox.ItemsAppearance.Parent = this.Filter_ComboBox;
            this.Filter_ComboBox.Location = new System.Drawing.Point(387, 39);
            this.Filter_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Filter_ComboBox.Name = "Filter_ComboBox";
            this.Filter_ComboBox.ShadowDecoration.Parent = this.Filter_ComboBox;
            this.Filter_ComboBox.Size = new System.Drawing.Size(248, 36);
            this.Filter_ComboBox.StartIndex = 0;
            this.Filter_ComboBox.TabIndex = 19;
            this.Filter_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.Filter_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_ComboBox_SelectedIndexChanged);
            // 
            // Class_ComboBox
            // 
            this.Class_ComboBox.Animated = true;
            this.Class_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Class_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Class_ComboBox.BorderRadius = 5;
            this.Class_ComboBox.BorderThickness = 2;
            this.Class_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Class_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Class_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_ComboBox.FocusedState.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Class_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Class_ComboBox.FormattingEnabled = true;
            this.Class_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_ComboBox.HoverState.Parent = this.Class_ComboBox;
            this.Class_ComboBox.ItemHeight = 30;
            this.Class_ComboBox.Items.AddRange(new object[] {
            "Mọi lớp"});
            this.Class_ComboBox.ItemsAppearance.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Location = new System.Drawing.Point(13, 39);
            this.Class_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Class_ComboBox.Name = "Class_ComboBox";
            this.Class_ComboBox.ShadowDecoration.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Size = new System.Drawing.Size(173, 36);
            this.Class_ComboBox.StartIndex = 0;
            this.Class_ComboBox.TabIndex = 18;
            this.Class_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // DataTable_Info
            // 
            this.DataTable_Info.AllowDrop = true;
            this.DataTable_Info.AllowUserToAddRows = false;
            this.DataTable_Info.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataTable_Info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable_Info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataTable_Info.BackgroundColor = System.Drawing.Color.White;
            this.DataTable_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable_Info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataTable_Info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable_Info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable_Info.ColumnHeadersHeight = 25;
            this.DataTable_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataTable_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable_Info.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataTable_Info.EnableHeadersVisualStyles = false;
            this.DataTable_Info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable_Info.Location = new System.Drawing.Point(0, 105);
            this.DataTable_Info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTable_Info.Name = "DataTable_Info";
            this.DataTable_Info.ReadOnly = true;
            this.DataTable_Info.RowHeadersVisible = false;
            this.DataTable_Info.RowHeadersWidth = 51;
            this.DataTable_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable_Info.Size = new System.Drawing.Size(1232, 742);
            this.DataTable_Info.TabIndex = 15;
            this.DataTable_Info.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataTable_Info.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataTable_Info.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataTable_Info.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataTable_Info.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataTable_Info.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataTable_Info.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataTable_Info.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable_Info.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable_Info.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataTable_Info.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataTable_Info.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.DataTable_Info.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataTable_Info.ThemeStyle.HeaderStyle.Height = 25;
            this.DataTable_Info.ThemeStyle.ReadOnly = true;
            this.DataTable_Info.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.DataTable_Info.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataTable_Info.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataTable_Info.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable_Info.ThemeStyle.RowsStyle.Height = 22;
            this.DataTable_Info.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.DataTable_Info.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            // 
            // Search_Button
            // 
            this.Search_Button.Animated = true;
            this.Search_Button.BackColor = System.Drawing.Color.White;
            this.Search_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Search_Button.BorderRadius = 5;
            this.Search_Button.BorderThickness = 2;
            this.Search_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Search_Button.CheckedState.Parent = this.Search_Button;
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.CustomImages.Parent = this.Search_Button;
            this.Search_Button.FillColor = System.Drawing.Color.White;
            this.Search_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Search_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Search_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.Search_Button.HoverState.Parent = this.Search_Button;
            this.Search_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Search_Button.Location = new System.Drawing.Point(831, 39);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.PressedDepth = 20;
            this.Search_Button.ShadowDecoration.Parent = this.Search_Button;
            this.Search_Button.Size = new System.Drawing.Size(191, 44);
            this.Search_Button.TabIndex = 23;
            this.Search_Button.Text = "TÌM KIẾM";
            this.Search_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // ClassInfor_SubTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.DataGridViewExport_Button);
            this.Controls.Add(this.SchoolYear_ComboBox);
            this.Controls.Add(this.Filter_ComboBox);
            this.Controls.Add(this.Class_ComboBox);
            this.Controls.Add(this.DataTable_Info);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClassInfor_SubTab";
            this.Size = new System.Drawing.Size(1232, 847);
            this.Load += new System.EventHandler(this.ClassInfor_SubTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button DataGridViewExport_Button;
        private Guna.UI2.WinForms.Guna2ComboBox SchoolYear_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox Filter_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox Class_ComboBox;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable_Info;
        private Guna.UI2.WinForms.Guna2Button Search_Button;
    }
}
