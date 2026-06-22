using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yasin
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }
            private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Search.Text.Trim()))
            {
                dgv_Bimaran.DataSource = null;
                dgv_Bimaran.DataSource = Bimar;
            }
            else
            {
               
                var filteredList = Bimar.Where(x => x.FirstName.Contains(txt_Search.Text.Trim(), StringComparison.OrdinalIgnoreCase) ||
                                                    x.LastName.Contains(txt_Search.Text.Trim(), StringComparison.OrdinalIgnoreCase) ||
                                                    x.NationalCode.Contains(txt_Search.Text.Trim())).ToList();

               
                dgv_Bimaran.DataSource = null;
                dgv_Bimaran.DataSource = filteredList;
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
