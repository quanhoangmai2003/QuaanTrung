using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class KYLUAT
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_KYLUAT getItem(string soQD)
        {
            return db.tb_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
        }
        public List<KYLUAT_DTO> getItemFull(string soQD)
        {
            List<tb_KHENTHUONG_KYLUAT> lstKT = db.tb_KHENTHUONG_KYLUAT.Where(x => x.SOQUYETDINH == soQD).ToList();
            List<KYLUAT_DTO> lstDTO = new List<KYLUAT_DTO>();
            KYLUAT_DTO kl;
            foreach (var item in lstKT)
            {
                kl = new KYLUAT_DTO();
                kl.SOQUYETDINH = item.SOQUYETDINH;
                kl.TUNGAY = item.TUNGAY;
                kl.DENNGAY = item.DENNGAY;
                kl.NOIDUNG = item.NOIDUNG;
                kl.LOAI = item.LOAI;
                kl.NGAY = " Ngày " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(6);
                kl.LYDO = item.LYDO;
                kl.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kl.HOTEN = nv.HOTEN;
                //kl.CHUCVU = item.CHUCVU;
                //kl.PHONGBAN = item.PHONGBAN;
                kl.CREATED_BY = item.CREATED_BY;
                kl.CREATED_DATE = item.CREATED_DATE;
                kl.UPDATED_BY = item.UPDATED_BY;
                kl.UPDATED_DATE = item.UPDATED_DATE;
                kl.DELETED_BY = item.DELETED_BY;
                kl.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(kl);
            }
            return lstDTO;

        }
        public List<tb_KYLUAT> getList()
        {
            return db.tb_KYLUAT.ToList();
        }
        public List<KYLUAT_DTO> getListFull()
        {
            List<tb_KYLUAT> lstKT = db.tb_KYLUAT.ToList();
            List<KYLUAT_DTO> lstDTO = new List<KYLUAT_DTO>();
            KYLUAT_DTO kl;
            foreach (var item in lstKT)
            {
                kl = new KYLUAT_DTO();
                kl.SOQUYETDINH = item.SOQUYETDINH;
                kl.TUNGAY = item.TUNGAY;
                kl.DENNGAY = item.DENNGAY;
                kl.NOIDUNG = item.NOIDUNG;
                kl.LOAI = item.LOAI;
                kl.NGAY = " Ngày " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(6);
                kl.LYDO = item.LYDO;              
                kl.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kl.HOTEN = nv.HOTEN;
                kl.CREATED_BY = item.CREATED_BY;
                kl.CREATED_DATE = item.CREATED_DATE;
                kl.UPDATED_BY = item.UPDATED_BY;
                kl.UPDATED_DATE = item.UPDATED_DATE;
                kl.DELETED_BY = item.DELETED_BY;
                kl.DELETED_DATE = item.DELETED_DATE;
                
                //kl.IDCV = item.IDCV;
                //var cv = db.tb_CHUCVU.FirstOrDefault(c => c.IDCV == item.IDCV);
                //kl.TENCV = cv.TENCV;
                
                //kl.IDPB = item.IDPB;
                //var pb = db.tb_PHONGBAN.FirstOrDefault(p => p.IDPB == item.IDPB);
                //kl.TENPB = pb.TENPB;
                
                lstDTO.Add(kl);
            }
            return lstDTO;

        }
        public tb_KYLUAT Add(tb_KYLUAT kt)
        {
            try
            {
                db.tb_KYLUAT.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tb_KYLUAT Update(tb_KYLUAT kt)
        {
            try
            {
                tb_KYLUAT _kt = db.tb_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == kt.SOQUYETDINH);
                _kt.NGAY = kt.NGAY;
                _kt.TUNGAY = kt.TUNGAY;
                _kt.DENNGAY = kt.DENNGAY;
                _kt.LYDO = kt.LYDO;
                _kt.NOIDUNG = kt.NOIDUNG;
                _kt.IDPB = kt.IDPB;
                _kt.IDCV = kt.IDCV;
                _kt.LOAI = kt.LOAI;
                _kt.MANV = kt.MANV;
                _kt.UPDATED_BY = kt.UPDATED_BY;
                _kt.UPDATED_DATE = kt.UPDATED_DATE;
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soQD, int maNV)
        {
            try
            {
                tb_KYLUAT _kt = db.tb_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
                _kt.DELETED_BY = maNV;
                _kt.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _hd = db.tb_KYLUAT.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQUYETDINH;
            }
            else
                return "00000";
        }

        public KYLUAT getItemFull(object soQD)
        {
            throw new NotImplementedException();
        }
    }
}

