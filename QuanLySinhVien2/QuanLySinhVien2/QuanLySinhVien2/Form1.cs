using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien2
{
    public partial class Form1 : Form
    {
        Form formConDangMo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            if (formConDangMo != null)
            {
                formConDangMo.Close();
            }

            FormSinhVien formSinhVien = new FormSinhVien();
            formConDangMo = formSinhVien;
            formSinhVien.MdiParent = this;
            formSinhVien.Show();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (formConDangMo != null)
            {
                formConDangMo.Close();
            }

            FormKhoa formKhoa = new FormKhoa();
            formConDangMo = formKhoa;
            formKhoa.MdiParent = this;
            formKhoa.Show();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            if (formConDangMo != null)
            {
                formConDangMo.Close();
            }

            FormMonHoc formMonHoc = new FormMonHoc();
            formConDangMo = formMonHoc;
            formMonHoc.MdiParent = this;
            formMonHoc.Show();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (formConDangMo != null)
            {
                formConDangMo.Close();
            }

            FormNhapDiem formNhapDiem = new FormNhapDiem();
            formConDangMo = formNhapDiem;
            formNhapDiem.MdiParent = this;
            formNhapDiem.Show();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (formConDangMo != null)
            {
                formConDangMo.Close();
            }

            FormXemDiem formXemDiem = new FormXemDiem();
            formConDangMo = formXemDiem;
            formXemDiem.MdiParent = this;
            formXemDiem.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (formConDangMo != null)
            {
                formConDangMo.Close();
            }

            FormThongKe formThongKe = new FormThongKe();
            formConDangMo = formThongKe;
            formThongKe.MdiParent = this;
            formThongKe.Show();
        }
    }
}
