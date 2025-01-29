namespace QLNHANSU
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhenthuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiViec = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTangCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUngLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiDB = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnCongTy = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoPhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKyLuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfig = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.btnNhanVien,
            this.btnPhongBan,
            this.btnHopDong,
            this.btnKhenthuong,
            this.btnDieuChuyen,
            this.btnThoiViec,
            this.btnLoaiCa,
            this.btnLoaiCong,
            this.btnPhuCap,
            this.btnTangCa,
            this.btnUngLuong,
            this.btnBangCong,
            this.btnBangLuong,
            this.btnDoiMatKhau,
            this.btnBackup,
            this.btnPhucHoiDB,
            this.btnThoat,
            this.btnCongTy,
            this.btnBoPhan,
            this.btnChucVu,
            this.btnKyLuat,
            this.btnQuanLyLuong,
            this.btnConfig});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 27;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1216, 193);
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân tộc";
            this.btnDanToc.Id = 1;
            this.btnDanToc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanToc.ImageOptions.LargeImage")));
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanToc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanToc_ItemClick);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTonGiao.ImageOptions.LargeImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTonGiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonGiao_ItemClick);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình độ";
            this.btnTrinhDo.Id = 3;
            this.btnTrinhDo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrinhDo.ImageOptions.LargeImage")));
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTrinhDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrinhDo_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng ban";
            this.btnPhongBan.Id = 5;
            this.btnPhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhongBan.ImageOptions.SvgImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Caption = "Hợp đồng";
            this.btnHopDong.Id = 6;
            this.btnHopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHopDong.ImageOptions.SvgImage")));
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHopDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHopDong_ItemClick);
            // 
            // btnKhenthuong
            // 
            this.btnKhenthuong.Caption = "Khen thưởng ";
            this.btnKhenthuong.Id = 7;
            this.btnKhenthuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhenthuong.ImageOptions.SvgImage")));
            this.btnKhenthuong.Name = "btnKhenthuong";
            this.btnKhenthuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhenthuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenthuong_ItemClick);
            // 
            // btnDieuChuyen
            // 
            this.btnDieuChuyen.Caption = "Điều chuyển";
            this.btnDieuChuyen.Id = 8;
            this.btnDieuChuyen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDieuChuyen.ImageOptions.SvgImage")));
            this.btnDieuChuyen.Name = "btnDieuChuyen";
            this.btnDieuChuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDieuChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDieuChuyen_ItemClick);
            // 
            // btnThoiViec
            // 
            this.btnThoiViec.Caption = "Thôi việc";
            this.btnThoiViec.Id = 9;
            this.btnThoiViec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoiViec.ImageOptions.SvgImage")));
            this.btnThoiViec.Name = "btnThoiViec";
            this.btnThoiViec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoiViec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoiViec_ItemClick);
            // 
            // btnLoaiCa
            // 
            this.btnLoaiCa.Caption = "Loại ca ";
            this.btnLoaiCa.Id = 10;
            this.btnLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCa.ImageOptions.SvgImage")));
            this.btnLoaiCa.Name = "btnLoaiCa";
            this.btnLoaiCa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiCa_ItemClick);
            // 
            // btnLoaiCong
            // 
            this.btnLoaiCong.Caption = "Loại công";
            this.btnLoaiCong.Id = 11;
            this.btnLoaiCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCong.ImageOptions.SvgImage")));
            this.btnLoaiCong.Name = "btnLoaiCong";
            this.btnLoaiCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLoaiCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiCong_ItemClick);
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.Caption = "Phụ cấp";
            this.btnPhuCap.Id = 12;
            this.btnPhuCap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhuCap.ImageOptions.SvgImage")));
            this.btnPhuCap.Name = "btnPhuCap";
            this.btnPhuCap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhuCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuCap_ItemClick);
            // 
            // btnTangCa
            // 
            this.btnTangCa.Caption = "Tăng ca";
            this.btnTangCa.Id = 13;
            this.btnTangCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTangCa.ImageOptions.SvgImage")));
            this.btnTangCa.Name = "btnTangCa";
            this.btnTangCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTangCa_ItemClick);
            // 
            // btnUngLuong
            // 
            this.btnUngLuong.Caption = "Ứng lương";
            this.btnUngLuong.Id = 14;
            this.btnUngLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUngLuong.ImageOptions.SvgImage")));
            this.btnUngLuong.Name = "btnUngLuong";
            this.btnUngLuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUngLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUngLuong_ItemClick);
            // 
            // btnBangCong
            // 
            this.btnBangCong.Caption = "Bảng công";
            this.btnBangCong.Id = 15;
            this.btnBangCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangCong.ImageOptions.SvgImage")));
            this.btnBangCong.Name = "btnBangCong";
            this.btnBangCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBangCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangCong_ItemClick);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Caption = "Bảng lương";
            this.btnBangLuong.Id = 16;
            this.btnBangLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangLuong.ImageOptions.SvgImage")));
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBangLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangLuong_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 17;
            this.btnDoiMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiMatKhau.ImageOptions.SvgImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu dữ liệu";
            this.btnBackup.Id = 18;
            this.btnBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBackup.ImageOptions.SvgImage")));
            this.btnBackup.Name = "btnBackup";
            // 
            // btnPhucHoiDB
            // 
            this.btnPhucHoiDB.Caption = "Phục hồi dữ liệu";
            this.btnPhucHoiDB.Id = 19;
            this.btnPhucHoiDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiDB.ImageOptions.SvgImage")));
            this.btnPhucHoiDB.Name = "btnPhucHoiDB";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 20;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnCongTy
            // 
            this.btnCongTy.Caption = "Công ty";
            this.btnCongTy.Id = 21;
            this.btnCongTy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCongTy.ImageOptions.SvgImage")));
            this.btnCongTy.Name = "btnCongTy";
            this.btnCongTy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCongTy_ItemClick);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Caption = "Bộ phận";
            this.btnBoPhan.Id = 22;
            this.btnBoPhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBoPhan.ImageOptions.SvgImage")));
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoPhan_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 23;
            this.btnChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChucVu.ImageOptions.SvgImage")));
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.Caption = "Kỷ luật";
            this.btnKyLuat.Id = 24;
            this.btnKyLuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKyLuat.ImageOptions.SvgImage")));
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKyLuat_ItemClick);
            // 
            // btnQuanLyLuong
            // 
            this.btnQuanLyLuong.Caption = "Lương";
            this.btnQuanLyLuong.Id = 25;
            this.btnQuanLyLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQuanLyLuong.ImageOptions.SvgImage")));
            this.btnQuanLyLuong.Name = "btnQuanLyLuong";
            this.btnQuanLyLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyLuong_ItemClick);
            // 
            // btnConfig
            // 
            this.btnConfig.Caption = "Cài đặt";
            this.btnConfig.Id = 26;
            this.btnConfig.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnConfig.ImageOptions.SvgImage")));
            this.btnConfig.Name = "btnConfig";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nhân sự";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanToc, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonGiao, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrinhDo, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongBan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCongTy, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBoPhan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChucVu, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục dùng chung";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHopDong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhenthuong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLyLuong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKyLuat, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDieuChuyen, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThoiViec, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nghiệp vụ";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Chấm công";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaiCa, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaiCong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhuCap, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTangCa, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUngLuong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangCong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangLuong, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý chấm công";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 668);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Phần mềm quản lý nhân sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnPhongBan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnHopDong;
        private DevExpress.XtraBars.BarButtonItem btnKhenthuong;
        private DevExpress.XtraBars.BarButtonItem btnDieuChuyen;
        private DevExpress.XtraBars.BarButtonItem btnThoiViec;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCong;
        private DevExpress.XtraBars.BarButtonItem btnPhuCap;
        private DevExpress.XtraBars.BarButtonItem btnTangCa;
        private DevExpress.XtraBars.BarButtonItem btnUngLuong;
        private DevExpress.XtraBars.BarButtonItem btnBangCong;
        private DevExpress.XtraBars.BarButtonItem btnBangLuong;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiDB;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnCongTy;
        private DevExpress.XtraBars.BarButtonItem btnBoPhan;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.BarButtonItem btnKyLuat;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyLuong;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.BarButtonItem btnConfig;
    }
}

