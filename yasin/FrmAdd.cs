using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace yasin
{
    public partial class FrmAdd : Form
    {
       public List<Bimaran> Bimar = new List<Bimaran>();
        public FrmAdd()
        {
            InitializeComponent();
        }
        private void txt_FirstName_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void txt_LastName_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void txt_NationalCode_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void txt_NumberPhone_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                string.IsNullOrWhiteSpace(txt_NationalCode.Text) ||
                string.IsNullOrWhiteSpace(txt_NumberPhone.Text))
            {
                MessageBox.Show("لطفاً تمامی فیلدها را پر کنید!");
                return;
            }

            
            bool isDuplicate = Bimar.Any(x => x.NationalCode == txt_NationalCode.Text.Trim());

            if (isDuplicate)
            {
                MessageBox.Show("خطا: این کد ملی قبلاً ثبت شده است!");
            }
            else
            {
                Bimaran a = new Bimaran();
                a.FirstName = txt_FirstName.Text.Trim();
                a.LastName = txt_LastName.Text.Trim();
                a.NationalCode = txt_NationalCode.Text.Trim();
                a.NumberPhone = txt_NumberPhone.Text.Trim();

                Bimar.Add(a);
                MessageBox.Show("بیمار با موفقیت اضافه شد");
            }

        }

    
    }
}
