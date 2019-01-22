using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QLBH
{
    class Connecting
    {
        public SqlConnection ketnoi = new SqlConnection("Data Source=DESKTOP-D4U9M24\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        public void connect()
        {
            ketnoi.Open();
        }
        public void closeconnect()
        {
            ketnoi.Close();
        }
        public DataTable taobang(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, ketnoi);
            da.Fill(tb);
            return (tb);
        }
        internal DataTable taobang()
        {
            throw new NotImplementedException();
        }

        #region NHÂN VIÊN
        public void themnv(string manv, string hoten, string gioitinh, string ngaysinh, string diachi, string sdt, string ngayvaolam, string mucluong, string macv)
        {
            string sql = "Insert into NHANVIEN(MANV,HOTENNV,GIOITINH,NGAYSINH,DIACHI,SODT,NGAYVL,MUCLUONG,MACV)" +
                "values('" + manv + "',N'" + hoten + "',N'" + gioitinh + "',N'" + ngaysinh + "',N'" + diachi + "',N'" + sdt + "',N'" + ngayvaolam + "',N'" + mucluong + "',N'" + macv + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void suanv(string manv,string hoten, string gioitinh, string ngaysinh, string diachi, string sdt, string ngayvaolam, string mucluong, string macv,string chon)
        {
            string sql = "UPDATE NHANVIEN SET MANV=N'"+manv+"', HOTENNV=N'" + hoten + "',GIOITINH=N'" + gioitinh + "',NGAYSINH='" + ngaysinh + "',DIACHI=N'" + diachi + "',SODT='" + sdt + "',NGAYVL=N'" + ngayvaolam + "',MUCLUONG=N'" + mucluong + "',MACV=N'" + macv + "' WHERE MANV=N'" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoanv(string manv)
        {
            string sql = "DELETE FROM NHANVIEN WHERE MANV='" + manv + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        #endregion

        #region ĐĂNG KÝ
        public void themdk(string tendangnhap, string matkhau, string hoten, string sodt, string ngaysinh, string diachi, string cmnd)
        {
            string sql = "Insert into DANGKY(Username,password,hoten,sodt,ngaysinh,diachi,cmnd)" + "values(N'" + tendangnhap + "',N'" + matkhau + "',N'" + hoten + "',N'" + sodt + "',N'" + ngaysinh + "',N'" + diachi + "',N'" + cmnd + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion

        #region CẬP NHẬT THÔNG TIN TÀI KHOẢN
        public void updatetk(string username ,string hoten, string sodt, string ngaysinh, string diachi, string cmnd)
        {
            string sql = "update DANGKY set hoten=N'"+hoten+"',sodt=N'"+sodt+"',ngaysinh=N'"+ngaysinh+"',diachi=N'"+diachi+"',cmnd=N'"+cmnd+"' where username='"+username+"'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion

        #region ĐỔI MẬT KHẨU
        public void doimk(string tendangnhap, string matkhau)
        {
            string sql = "UPDATE DANGKY SET password=N'" + matkhau + "' WHERE username='" + tendangnhap + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        #endregion

        #region CHỨC VỤ

        public void themcv(string macv, string tencv)
        {
            string sql = "Insert into CHUCVU(MACV,TENCV)" + "values('" + macv + "',N'" + tencv + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void suacv(string chon, string macv, string tencv)
        {
            string sql = "UPDATE CHUCVU SET MACV=N'" + macv + "', TENCV=N'" + tencv + "' WHERE MACV=N'" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoacv(string macv)
        {
            string sql = "DELETE FROM CHUCVU WHERE MACV=N'" + macv + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion

        #region KHÁCH HÀNG

        public void themkh(string makh, string tenkh, string diachi, string sdt)
        {
            string sql = "Insert into KHACHHANG(MAKH,TENKH,DIACHI,DIENTHOAI)" + "values('" + makh + "',N'" + tenkh + "',N'" + diachi + "',N'" + sdt + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void suakh(string chon, string makh, string tenkh, string diachi, string sdt)
        {
            string sql = "UPDATE KHACHHANG SET MAKH=N'" + makh + "', TENKH=N'" + tenkh + "', DIACHI=N'" + diachi + "', DIENTHOAI=N'" + sdt + "' WHERE MAKH=N'" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoakh(string makh)
        {
            string sql = "DELETE FROM KHACHHANG WHERE MAKH=N'" + makh + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion

        #region SẢN PHẨM

        public void themsp(string masp, string tensp, string dvt, string nuocsx, string dongia)
        {
            string sql = "Insert into SANPHAM(MASP,TENSP,DVT,NUOCSX,DONGIA)" + "values('" + masp + "',N'" + tensp + "',N'" + dvt + "',N'" + nuocsx + "','" + dongia + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void suasp(string chon, string masp, string tensp, string dvt, string nuocsx, string dongia)
        {
            string sql = "UPDATE SANPHAM SET MASP='"+ masp +"',TENSP=N'"+tensp+"' ,DVT=N'"+dvt+"',NUOCSX=N'"+nuocsx+"',DONGIA='"+dongia+"' WHERE MASP=N'" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoasp(string masp)
        {
            string sql = "DELETE FROM SANPHAM WHERE MASP=N'" + masp + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion

        #region HOÁ ĐƠN

        public void themhd(string sohd, string makh, string manv, string ngaylaphoadon)
        {
            string sql = "Insert into hoadon(sohd,makh,manv,ngaylaphd)" + "values('" + sohd + "',N'" + makh + "',N'" + manv + "',N'" + ngaylaphoadon+"')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void suahd(string chon, string sohd, string makh, string manv, string ngaylaphoadon)
        {
            string sql = "UPDATE hoadon SET sohd='" + sohd + "',makh=N'" + makh + "' ,manv=N'" + manv + "',ngaylaphd=N'" + ngaylaphoadon + "' WHERE sohd=N'" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoahd(string sohd)
        {
            string sql = "DELETE FROM hoadon WHERE sohd=N'" + sohd + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion

        #region HOÁ ĐƠN CHI TIẾT

        public void themhdct(string sohd, string masp, string soluong)
        {
            string sql = "Insert into hoadonct(sohd,masp,soluong)" + "values('" + sohd + "',N'" + masp + "',N'" + soluong + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void suahdct(string chon, string sohd, string masp, string soluong)
        {
            string sql = "UPDATE hoadonct SET sohd='" + sohd + "',masp=N'" + masp + "' ,soluong=N'" + soluong + "' WHERE sohd=N'" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoahdct(string sohd)
        {
            string sql = "DELETE FROM hoadonct WHERE sohd=N'" + sohd + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion
    }
}
