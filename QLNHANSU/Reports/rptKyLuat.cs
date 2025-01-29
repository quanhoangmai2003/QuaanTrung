using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;

namespace QLNHANSU.Reports
{
    public partial class rptKyLuat : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKyLuat()
        {
            InitializeComponent();
        }
        public rptKyLuat(List<KYLUAT_DTO> lstKL)
        {
            InitializeComponent();
            this._lstKL = lstKL;
            this.DataSource = _lstKL;
        }
        List<KYLUAT_DTO> _lstKL;
    }
}
