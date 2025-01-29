using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;

namespace BusinessLayer
{
    public class UNGLUONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_UNGLUONG getItem(int id)
        {
            return db.tb_UNGLUONG.FirstOrDefault(x=>x.ID==id);  
        }
        public List<UNGLUONG_DTO> getListFull()
        {
            var lst = db.tb_UNGLUONG.ToList();
            List<UNGLUONG_DTO> lstDTO = new List<UNGLUONG_DTO>();
            UNGLUONG_DTO dto;
            foreach (var item in lst)
            {
                dto = new UNGLUONG_DTO();
                dto.ID = item.ID;
                dto.NAM = item.NAM;
                dto.THANG = item.THANG;
                dto.NGAY = item.NGAY;
                dto.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n=>n.MANV==item.MANV);
                dto.HOTEN = nv.HOTEN;
                dto.SOTIEN = item.SOTIEN;
                dto.GHICHU = item.GHICHU;
                dto.CREATED_BY = item.CREATED_BY;
                dto.CREATED_DATE = item.CREATED_DATE;
                dto.UPDATED_BY = item.UPDATED_BY;
                dto.UPDATED_DATE = item.UPDATED_DATE;
                dto.DELETED_BY = item.DELETED_BY;
                dto.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }
        public tb_UNGLUONG Add(tb_UNGLUONG ul)
        {
            try
            {
                db.tb_UNGLUONG.Add(ul);
                db.SaveChanges();
                return ul;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
        }
        public tb_UNGLUONG Update(tb_UNGLUONG ul)
        {
            try
            {
                var _ul = db.tb_UNGLUONG.FirstOrDefault(x => x.ID == ul.ID);
                _ul.NAM = ul.NAM;
                _ul.THANG = ul.THANG;
                _ul.NGAY = ul.NGAY;
                _ul.MANV = ul.MANV;
                _ul.SOTIEN = ul.SOTIEN;
                _ul.GHICHU = ul.GHICHU;
                _ul.UPDATED_BY = ul.UPDATED_BY;
                _ul.UPDATED_DATE = ul.UPDATED_DATE;
                db.SaveChanges();
                return ul;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id, int UserID)
        {
            try
            {
                var _ul = db.tb_UNGLUONG.FirstOrDefault(x => x.ID == id);
                _ul.DELETED_BY = UserID;
                _ul.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
        }
    }
}
