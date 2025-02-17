﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin.Action.Excel
{
    internal class ReportSemester: ReportCommon
    {
        public class Info
        {
            private int semester;
            private string schoolYear;

            public int HocKy
            {
                get { return semester; }
                set { semester = value; }
            }

            public string NamHoc
            {
                get { return schoolYear; }
                set { schoolYear = value; }
            }
        }

        public ReportSemester(string sheetNamePrimary = "")
        {
            locationSemester = "B2";
            locationSchoolYear = "C2";
            title = "BẢNG BÁO CÁO TỔNG KẾT HỌC KỲ";

            if (!String.IsNullOrEmpty(sheetNamePrimary)) sheet.Name = sheetNamePrimary;
        }

        public override void InsertInfo(dynamic info)
        {
            try
            {
                if (info == null)
                {
                    throw new Exception();
                };

                Info clone = info as Info;

                (string, string) Info_HocKy = HocKy(clone.HocKy);
                (string, string) Info_NamHoc = NamHoc(clone.NamHoc);

                sheet.get_Range(locationTitle).Value = title;
                sheet.get_Range(Info_HocKy.Item1).Value = Info_HocKy.Item2;
                sheet.get_Range(Info_NamHoc.Item1).Value = Info_NamHoc.Item2;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
