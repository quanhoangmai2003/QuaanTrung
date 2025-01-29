using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class KHENTHUONG_KYLUAT
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        public tb_KHENTHUONG_KYLUAT getItem(string soQD)
        {
            return db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x=>x.SOQUYETDINH==soQD);
        }
        public List<KHENTHUONG_KYLUAT_DTO> getItemFull(string soQD )
        {
            List<tb_KHENTHUONG_KYLUAT> lstKT = db.tb_KHENTHUONG_KYLUAT.Where(x=>x.SOQUYETDINH==soQD).ToList();
            List<KHENTHUONG_KYLUAT_DTO> lstDTO = new List<KHENTHUONG_KYLUAT_DTO>();
            KHENTHUONG_KYLUAT_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KHENTHUONG_KYLUAT_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                kt.TUNGAY = item.TUNGAY;
                kt.DENNGAY = item.DENNGAY;
                kt.NOIDUNG = item.NOIDUNG;
                kt.LOAI = item.LOAI;
                kt.NGAY = " Ngày " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(6); 
                kt.LYDO = item.LYDO;
                kt.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;
                kt.CREATED_BY = item.CREATED_BY;
                kt.CREATED_DATE = item.CREATED_DATE;
                kt.UPDATED_BY = item.UPDATED_BY;
                kt.UPDATED_DATE = item.UPDATED_DATE;
                kt.DELETED_BY = item.DELETED_BY;
                kt.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(kt);
            }
            return lstDTO;

        }
        public List<tb_KHENTHUONG_KYLUAT> getList()
        {
            return db.tb_KHENTHUONG_KYLUAT.ToList();
        }
        public List<KHENTHUONG_KYLUAT_DTO> getListFull()
        {
            List<tb_KHENTHUONG_KYLUAT> lstKT = db.tb_KHENTHUONG_KYLUAT.ToList();
            List<KHENTHUONG_KYLUAT_DTO> lstDTO = new List<KHENTHUONG_KYLUAT_DTO>();
            KHENTHUONG_KYLUAT_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KHENTHUONG_KYLUAT_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                kt.TUNGAY = item.TUNGAY;
                kt.DENNGAY = item.DENNGAY;        
                kt.NOIDUNG = item.NOIDUNG;
                kt.LOAI = item.LOAI;
                kt.NGAY = " Ngày " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAY.Value.ToString("dd/MM/yyyy").Substring(6); 
                kt.LYDO = item.LYDO;
                kt.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;               
                kt.CREATED_BY = item.CREATED_BY;
                kt.CREATED_DATE = item.CREATED_DATE;
                kt.UPDATED_BY = item.UPDATED_BY;
                kt.UPDATED_DATE = item.UPDATED_DATE;
                kt.DELETED_BY = item.DELETED_BY;
                kt.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(kt);
            }
            return lstDTO;

        }
            
        public tb_KHENTHUONG_KYLUAT Add(tb_KHENTHUONG_KYLUAT kt)
        {
            try
            {
                db.tb_KHENTHUONG_KYLUAT.Add(kt);
                db.SaveChanges();
                return kt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tb_KHENTHUONG_KYLUAT Update(tb_KHENTHUONG_KYLUAT kt)
        {
            try
            {
                tb_KHENTHUONG_KYLUAT _kt = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == kt.SOQUYETDINH);
                _kt.NGAY = kt.NGAY;
                _kt.TUNGAY = kt.TUNGAY;
                _kt.DENNGAY = kt.DENNGAY;
                _kt.LYDO = kt.LYDO;
                _kt.NOIDUNG = kt.NOIDUNG;
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
                tb_KHENTHUONG_KYLUAT _kt = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);               
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
            var _hd = db.tb_KHENTHUONG_KYLUAT.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQUYETDINH;
            }
            else
                return "00000";
        }

        public KHENTHUONG_KYLUAT getItemFull(object soQD)
        {
            throw new NotImplementedException();
        }
    }
}
