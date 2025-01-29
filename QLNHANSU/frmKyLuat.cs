using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.DTO;
using BusinessLayer;
using DevExpress.XtraEditors;
using QLNHANSU.Reports;
using DataLayer;
using DevExpress.XtraReports.UI;

namespace QLNHANSU
{
    public partial class frmKyLuat : DevExpress.XtraEditors.XtraForm
    {
        public frmKyLuat()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        private CHUCVU _chucvu;
        private PHONGBAN _phongban;
        KYLUAT _kl;
        NHANVIEN _nhanvien;
        List<KYLUAT_DTO> _lstKL;
        private void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnSua.Enabled = kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            gcDanhSach.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtIDCV.Enabled = !kt;
            txtIDPB.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;          
            slkNhanVien.Enabled = !kt;
        }
        private void reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            //dtNgayBatDau.Value = DateTime.Now;
            //dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);            
        }
        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        private void loadData()
        {
            gcDanhSach.DataSource = _kl.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            _kl = new KYLUAT();
            _nhanvien = new NHANVIEN();
            _them = false;
            _chucvu = new CHUCVU();
            _phongban = new PHONGBAN();
            showHide(true);
            loadData();
            loadNhanVien();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = false;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _kl.Delete(_soQD, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            showHide(true);
            _them = false;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            _them = true;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lstKL = _kl.getItemFull(_soQD);
            rptKyLuat rpt = new rptKyLuat(_lstKL);
            rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void SaveData()
        {
            if (_them)
            {
                //số hđ có dạng: 00000/2024/HĐLĐ
                var maxSoQD = _kl.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tb_KYLUAT kt = new tb_KYLUAT();
                kt.SOQUYETDINH = so.ToString("00000") + @"/2024/QĐKT";
                //hd.NGAYBATDAU = dtNgayBatDau.Value;
                //hd.NGAYKETTHUC = dtNgayKetThuc.Value;
                kt.LYDO = txtLyDo.Text;
                kt.NGAY = dtNgay.Value;
                kt.NOIDUNG = txtNoiDung.Text;
                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.LOAI = 1;
                kt.CREATED_BY = 17;
                kt.CREATED_DATE = DateTime.Now;
                _kl.Add(kt);
            }
            else
            {
                var kt = _kl.getItem(_soQD);
                //hd.NGAYBATDAU = dtNgayBatDau.Value;
                //hd.NGAYKETTHUC = dtNgayKetThuc.Value;
                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.NGAY = dtNgay.Value;
                kt.LYDO = txtLyDo.Text;
                kt.NOIDUNG = txtNoiDung.Text;
                kt.UPDATED_BY = 17;
                kt.UPDATED_DATE = DateTime.Now;
                _kl.Update(kt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var kt = _kl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                //dtNgayBatDau.Value = hd.NGAYBATDAU.Value;
                //dtNgayKetThuc.Value = hd.NGAYKETTHUC.Value;
                dtNgay.Value = kt.NGAY.Value;
                txtNoiDung.Text = kt.NOIDUNG;
                slkNhanVien.EditValue = kt.MANV;
                txtLyDo.Text = kt.LYDO;
                _lstKL = _kl.getItemFull(_soQD);
            }
        }
    }
}