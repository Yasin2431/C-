namespace yasin
{
    partial class FrmAdd
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
            txt_FirstName = new TextBox();
            txt_LastName = new TextBox();
            txt_NationalCode = new TextBox();
            txt_NumberPhone = new TextBox();
            btn_Add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(219, 113);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(125, 27);
            txt_FirstName.TabIndex = 0;
            txt_FirstName.TextChanged += txt_FirstName_TextChanged;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(219, 146);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(125, 27);
            txt_LastName.TabIndex = 1;
            txt_LastName.TextChanged += txt_LastName_TextChanged;
            // 
            // txt_NationalCode
            // 
            txt_NationalCode.Location = new Point(219, 179);
            txt_NationalCode.Name = "txt_NationalCode";
            txt_NationalCode.Size = new Size(125, 27);
            txt_NationalCode.TabIndex = 2;
            txt_NationalCode.TextChanged += txt_NationalCode_TextChanged;
            // 
            // txt_NumberPhone
            // 
            txt_NumberPhone.Location = new Point(219, 212);
            txt_NumberPhone.Name = "txt_NumberPhone";
            txt_NumberPhone.Size = new Size(125, 27);
            txt_NumberPhone.TabIndex = 3;
            txt_NumberPhone.TextChanged += txt_NumberPhone_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(219, 245);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(122, 29);
            btn_Add.TabIndex = 4;
            btn_Add.Text = "ذخیره";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(219, 113);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 5;
            label1.Text = "نام ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(219, 149);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 6;
            label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(219, 182);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 7;
            label3.Text = "کدملی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(219, 215);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 8;
            label4.Text = "شماره تلفن";
            // 
            // FrmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 438);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Add);
            Controls.Add(txt_NumberPhone);
            Controls.Add(txt_NationalCode);
            Controls.Add(txt_LastName);
            Controls.Add(txt_FirstName);
            Name = "FrmAdd";
            Text = "FrmAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_FirstName;
        private TextBox txt_LastName;
        private TextBox txt_NationalCode;
        private TextBox txt_NumberPhone;
        private Button btn_Add;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}