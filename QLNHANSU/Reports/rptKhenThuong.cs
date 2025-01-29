using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;

namespace QLNHANSU.Reports
{
    public partial class rptKhenThuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKhenThuong()
        {
            InitializeComponent();
        }
        public rptKhenThuong(List<KHENTHUONG_KYLUAT_DTO> lstKT)
        {
            InitializeComponent();
            this._lstKT = lstKT;
            this.DataSource = _lstKT;
        }
        List<KHENTHUONG_KYLUAT_DTO> _lstKT;
        void loadData()
        {
            lblSOQUYETDINH.DataBindings.Add("Text", _lstKT, "SOQUYETDINH");
        }
    }
}
