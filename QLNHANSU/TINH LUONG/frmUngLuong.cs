using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;

namespace QLNHANSU.TINH_LUONG
{
    public partial class frmUngLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmUngLuong()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        UNGLUONG _ungluong;
        bool _them;
        int _id;
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnSua.Enabled = kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            txtNoiDung.Enabled = !kt;
            spSoTien.Enabled = !kt;
            lkNhanVien.Enabled = !kt;
        }
        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getlistFull();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }

        
        void loadData()
        {
            gcDanhSach.DataSource = _ungluong.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUngLuong_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new NHANVIEN();
            _ungluong = new UNGLUONG();
            showHide(true);
            loadData();
            loadNhanVien();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
            lkNhanVien.EditValue = 0;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ungluong.Delete(_id, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            showHide(true);
            _them = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            _them = true;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_UNGLUONG ul = new tb_UNGLUONG();
                ul.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                ul.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                ul.GHICHU = txtNoiDung.Text;
                ul.NGAY = DateTime.Now.Day;
                ul.THANG = DateTime.Now.Month;
                ul.NAM = DateTime.Now.Year;
                ul.CREATED_BY = 1;
                ul.CREATED_DATE = DateTime.Now;
                _ungluong.Add(ul);
            }
            else
            {
                var ul = _ungluong.getItem(_id);
                ul.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                ul.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                ul.GHICHU = txtNoiDung.Text;
                ul.NGAY = DateTime.Now.Day;
                ul.THANG = DateTime.Now.Month;
                ul.NAM = DateTime.Now.Year;
                ul.UPDATED_BY = 1;
                ul.UPDATED_DATE = DateTime.Now;
                _ungluong.Update(ul);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                spSoTien.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN");
                lkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.DeleteRed;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}