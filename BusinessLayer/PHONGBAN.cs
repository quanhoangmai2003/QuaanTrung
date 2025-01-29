using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PHONGBAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        public tb_PHONGBAN getItem(int id)
        {
            return db.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
        }
        public List<tb_PHONGBAN> getList()
        {
            return db.tb_PHONGBAN.ToList();
        }
        public tb_PHONGBAN Add(tb_PHONGBAN dt)
        {
            try
            {
                db.tb_PHONGBAN.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_PHONGBAN Update(tb_PHONGBAN dt)
        {
            try
            {
                var _dt = db.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == dt.IDPB);
                _dt.TENPB = dt.TENPB;
                db.SaveChanges();
                return _dt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _dt = db.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
                if (_dt == null)
                {
                    throw new Exception("Entry not found.");
                }
                db.tb_PHONGBAN.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the inner exception for more details
                throw new Exception("Lỗi: " + ex.Message, ex);
            }
        }



    }
}
