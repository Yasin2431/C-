namespace yasin
{
    partial class FrmDelete
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
            txt_Nationalcode = new TextBox();
            btn_Delete = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_Nationalcode
            // 
            txt_Nationalcode.Location = new Point(249, 101);
            txt_Nationalcode.Name = "txt_Nationalcode";
            txt_Nationalcode.Size = new Size(125, 27);
            txt_Nationalcode.TabIndex = 0;
            txt_Nationalcode.TextChanged += txt_Nationalcode_TextChanged;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(249, 134);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(125, 37);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "حذف";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(249, 104);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "کدملی";
            // 
            // FrmDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_Delete);
            Controls.Add(txt_Nationalcode);
            Name = "FrmDelete";
            Text = "FrmDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nationalcode;
        private Button btn_Delete;
        private Label label1;
    }
}