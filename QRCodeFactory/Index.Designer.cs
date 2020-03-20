namespace QRCodeFactory
{
    partial class Index
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
            this.txt_codes = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_path = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.lab_alert = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_excelPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_codes
            // 
            this.txt_codes.Location = new System.Drawing.Point(26, 46);
            this.txt_codes.Multiline = true;
            this.txt_codes.Name = "txt_codes";
            this.txt_codes.Size = new System.Drawing.Size(436, 266);
            this.txt_codes.TabIndex = 0;
            this.txt_codes.TextChanged += new System.EventHandler(this.txt_codes_TextChanged);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(99, 486);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(252, 55);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始生成";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "请在此粘贴待生成的内容（若多个请以英文逗号分隔）";
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(375, 442);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(87, 23);
            this.btn_path.TabIndex = 3;
            this.btn_path.Text = "选择导出位置";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(28, 444);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(339, 21);
            this.txt_path.TabIndex = 4;
            // 
            // lab_alert
            // 
            this.lab_alert.AutoSize = true;
            this.lab_alert.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_alert.ForeColor = System.Drawing.Color.Red;
            this.lab_alert.Location = new System.Drawing.Point(12, 565);
            this.lab_alert.Name = "lab_alert";
            this.lab_alert.Size = new System.Drawing.Size(0, 19);
            this.lab_alert.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "或者导入excel（若两者都填，只操作上方文本里面的）";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "选择excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "============================================================";
            // 
            // txt_excelPath
            // 
            this.txt_excelPath.Location = new System.Drawing.Point(26, 355);
            this.txt_excelPath.Name = "txt_excelPath";
            this.txt_excelPath.Size = new System.Drawing.Size(341, 21);
            this.txt_excelPath.TabIndex = 9;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 605);
            this.Controls.Add(this.txt_excelPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_alert);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_codes);
            this.Name = "Index";
            this.Text = "二维码批量生成工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codes;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label lab_alert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_excelPath;
    }
}