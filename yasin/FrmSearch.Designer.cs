namespace yasin
{
    partial class FrmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Search = new TextBox();
            btn_Search = new Button();
            label1 = new Label();
            dgv_Bimaran = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Bimaran).BeginInit();
            SuspendLayout();
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(266, 109);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(125, 27);
            txt_Search.TabIndex = 0;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(266, 141);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(125, 29);
            btn_Search.TabIndex = 1;
            btn_Search.Text = "سرچ ";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(266, 112);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "کدملی";
            // 
            // dgv_Bimaran
            // 
            dgv_Bimaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bimaran.Location = new Point(175, 213);
            dgv_Bimaran.Name = "dgv_Bimaran";
            dgv_Bimaran.RowHeadersWidth = 51;
            dgv_Bimaran.Size = new Size(300, 188);
            dgv_Bimaran.TabIndex = 3;
            // 
            // FrmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Bimaran);
            Controls.Add(label1);
            Controls.Add(btn_Search);
            Controls.Add(txt_Search);
            Name = "FrmSearch";
            Text = "FrmSearch";
            ((System.ComponentModel.ISupportInitialize)dgv_Bimaran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Search;
        private Button btn_Search;
        private Label label1;
        private DataGridView dgv_Bimaran;
    }
}