using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DatHang_GiaoHang
{
    public partial class form_CHITIETDONHANG : Form
    {
        string maDonCanXem;
        public form_CHITIETDONHANG(string madon)
        {
           
            InitializeComponent();
            maDonCanXem = madon;
            LoadData();
        }

        void LoadData()
        { 
            dataGridView1.Refresh();
            string query = "select * from CHITIET_DONHANG where MA_DON = '" + maDonCanXem + "'";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
    }
}
