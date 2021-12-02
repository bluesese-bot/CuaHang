﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuaHang.DataAccess;
using CuaHang.Business.EntitiesClass;
using System.Windows.Forms;

namespace CuaHang.Business.Component
{
    class E_tb_NCC
    {
        SQL_tb_NCC nccsql = new SQL_tb_NCC();
        public void themoincc(EC_tb_NCC ncc)
        {
            if (!nccsql.kiemtrancc(ncc.Mancc))
            {
                nccsql.themmoincc(ncc);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suancc(EC_tb_NCC ncc)
        {
            nccsql.suancc(ncc);
        }
        public void xoancc(EC_tb_NCC ncc)
        {
            nccsql.xoancc(ncc);
        }
    }
}