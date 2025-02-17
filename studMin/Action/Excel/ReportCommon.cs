﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace studMin.Action.Excel
{
    internal abstract class ReportCommon : CommonExcel
    {
        private const int StartColumnIndex = 1;
        private const int StartRowIndex = 6;
        protected string locationSemester;
        protected string locationSchoolYear;
        protected string locationTitle = "A1";
        protected string title;
        List<Item> data = null;

        protected (string, string) HocKy(int num)
        {
            return (locationSemester, String.Format("Học kỳ: {0}", Methods.Semester(num)));
        }

        protected (string, string) NamHoc(string msg)
        {
            if (msg == "Mọi năm học")
            {
                return (locationSchoolYear, String.Format("Năm học: {0}", msg));
            }
            return (locationSchoolYear, String.Format("Năm học: {0} - {1}", msg, int.Parse(msg) + 1));
        }

        public class Item
        {
            private string className;
            private int quantity;
            private int passQuantity;

            public string Lop
            {
                get { return className; }
                set { className = value; }
            }

            public int SiSo
            {
                get { return quantity; }
                set { quantity = value; }
            }

            public int SoLuongDat
            {
                get { return passQuantity; }
                set { passQuantity = value; }
            }

            public double TiLeDat
            {
                get { return Math.Round(100.0 * SoLuongDat / SiSo, 2); }
            }
        }

        public ReportCommon()
        {
            template = StoragePath.TemplateReport;
            data = new List<Item>();
            InitExcel();
        }

        public override void InsertItem(dynamic item)
        {
            Item clone = item as Item;
            try
            {
                if (item == null) return;

                int indexColumn = StartColumnIndex;
                int lastRow = FindLastRowUsed() + 1;
                int No = lastRow - StartRowIndex + 1;

                string columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = No;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.Lop;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Value = clone.SiSo;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Formula = clone.SoLuongDat;

                columnName = GetExcelColumnName(indexColumn++);
                sheet.get_Range(columnName + lastRow.ToString()).Formula = String.Format("{0}%", clone.TiLeDat);
            }
            catch
            {
                throw new Exception();
            }
        }

        public override object SelectInfo()
        {
            return null;
        }

        public override object SelectItem(object argument)
        {
            return null;
        }
    }
}
