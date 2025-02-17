﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin
{
    using Database.Models;
    public partial class ClassManage_SubTab : UserControl
    {
        private BackgroundWorker backgroundWorker = null;
        private GUI.LoadingWindow loadingWindow = null;

        public ClassManage_SubTab()
        {
            InitializeComponent();
            this.Load += ClassManage_SubTab_Load;
        }

        private void ClassManage_SubTab_Load(object sender, EventArgs e)
        {
            BindingClass();
        }

        private void AddClass_Button_Click(object sender, EventArgs e)
        {
            AddClass_Form addClass_Form = new AddClass_Form(this);
            addClass_Form.ShowDialog();
        }

        private void ChangeAgeRange_Button_Click(object sender, EventArgs e)
        {
            ChangeAgeRange_Form changeAgeRange_Form = new ChangeAgeRange_Form();
            changeAgeRange_Form.ShowDialog();
        }

        public void BindingClass()
        {
            cLASSBindingSource.DataSource = Database.ClassServices.Instance.GetClasss();
            foreach (DataGridViewRow row in GridView.Rows)
            {
                CLASS selected = row.DataBoundItem as CLASS;
                if (selected != null)
                {
                    row.Cells["ClassId"].Value = selected.ID.ToString().Substring(0, 8).ToUpper();
                    row.Cells["NameClassHeadTeacher"].Value = selected.TEACHER.INFOR.FIRSTNAME + " " + selected.TEACHER.INFOR.LASTNAME;
                    row.Cells["Quantity"].Value = Database.ClassServices.Instance.GetQuantityOfClass(selected);
                }
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            var listClass = Database.ClassServices.Instance.GetClasss().Select(item => new { item.CLASSNAME, item.SCHOOLYEAR });
            if (listClass.Count() != listClass.Distinct().Count())
            {
                MessageBox.Show("Tên lớp đã tồn tại!");

                //if (backgroundWorker == null)
                //{
                //    backgroundWorker = new BackgroundWorker();
                //}
                //else if (!backgroundWorker.IsBusy)
                //{
                //    backgroundWorker.Dispose();
                //    backgroundWorker = new BackgroundWorker();
                //}
                //else
                //{
                //    MessageBox.Show("Đang nhập danh sách, vui lòng đợi!");
                //    return;
                //}

                //if (loadingWindow == null) loadingWindow = new GUI.LoadingWindow(this.ParentForm);

                //backgroundWorker.DoWork += ReloadDatabase_DoWork;
                //backgroundWorker.RunWorkerCompleted += ReloadDatabase_RunrWorkerCompleted;
                //backgroundWorker.RunWorkerAsync();
                //loadingWindow.ShowDialog();
                RefreshAll();
                BindingClass();
                return;
            }
            Database.DataProvider.Instance.Database.SaveChanges();
        }

        private void ReloadDatabase_RunrWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingWindow.Close();
        }

        private void ReloadDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshAll();
            cLASSBindingSource.ResetBindings(false);
        }

        public void RefreshAll()
        {
            foreach (var entity in Database.DataProvider.Instance.Database.CLASSes)
            {
                Database.DataProvider.Instance.Database.Entry(entity).Reload();
            }
        }

        private void changeClassMaxCapacity_Button_Click(object sender, EventArgs e)
        {
            ChangeClassMaxCapacity_Form changeClassMaxCapacity_Form = new ChangeClassMaxCapacity_Form();
            changeClassMaxCapacity_Form.ShowDialog();
        }
    }
}
