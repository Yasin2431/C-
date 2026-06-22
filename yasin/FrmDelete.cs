using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yasin
{
    public partial class FrmDelete : Form
    {
        public FrmDelete()
        {
            InitializeComponent();
        }

        private void txt_Nationalcode_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
            Bimaran patientToDelete = Bimar.FirstOrDefault(x => x.NationalCode == txt_Nationalcode.Text.Trim());


            if (patientToDelete != null)
            {
                Bimar.Remove(patientToDelete);
                MessageBox.Show("بیمار با موفقیت از لیست حذف شد.");
            }
            else
            {
                
                MessageBox.Show("بیماری با این کد ملی در لیست یافت نشد!");
            }
        }

    }

}
