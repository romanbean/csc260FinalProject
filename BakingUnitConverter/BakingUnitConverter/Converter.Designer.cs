namespace BakingUnitConverter
{
    partial class Converter
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
            this.rtb_Main = new System.Windows.Forms.RichTextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.cb_PrevUnit = new System.Windows.Forms.ComboBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.lbl_EnterWhatYouWantToConvert = new System.Windows.Forms.Label();
            this.btn_download = new System.Windows.Forms.Button();
            this.cb_NewUnit = new System.Windows.Forms.ComboBox();
            this.tb_NewNum = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.tb_PrevNum = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_NewUnit = new System.Windows.Forms.Label();
            this.rb_US = new System.Windows.Forms.RadioButton();
            this.rb_Metric = new System.Windows.Forms.RadioButton();
            this.lbl_WhatSystem = new System.Windows.Forms.Label();
            this.btn_swap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_Main
            // 
            this.rtb_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Main.Location = new System.Drawing.Point(12, 38);
            this.rtb_Main.Name = "rtb_Main";
            this.rtb_Main.ReadOnly = true;
            this.rtb_Main.Size = new System.Drawing.Size(229, 379);
            this.rtb_Main.TabIndex = 0;
            this.rtb_Main.Text = "";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(68, 22);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(129, 13);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Upload Your Recipe Here";
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(12, 423);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(229, 23);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // cb_PrevUnit
            // 
            this.cb_PrevUnit.FormattingEnabled = true;
            this.cb_PrevUnit.Items.AddRange(new object[] {
            "cup",
            "cups",
            "g",
            "mL",
            "quart",
            "quarts",
            "ounces",
            "oz"});
            this.cb_PrevUnit.Location = new System.Drawing.Point(327, 165);
            this.cb_PrevUnit.Name = "cb_PrevUnit";
            this.cb_PrevUnit.Size = new System.Drawing.Size(85, 21);
            this.cb_PrevUnit.TabIndex = 6;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(256, 288);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(156, 23);
            this.btn_convert.TabIndex = 8;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // lbl_EnterWhatYouWantToConvert
            // 
            this.lbl_EnterWhatYouWantToConvert.AutoSize = true;
            this.lbl_EnterWhatYouWantToConvert.Location = new System.Drawing.Point(247, 113);
            this.lbl_EnterWhatYouWantToConvert.Name = "lbl_EnterWhatYouWantToConvert";
            this.lbl_EnterWhatYouWantToConvert.Size = new System.Drawing.Size(168, 13);
            this.lbl_EnterWhatYouWantToConvert.TabIndex = 9;
            this.lbl_EnterWhatYouWantToConvert.Text = "Enter What You Want To Convert";
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(256, 423);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(156, 23);
            this.btn_download.TabIndex = 12;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // cb_NewUnit
            // 
            this.cb_NewUnit.FormattingEnabled = true;
            this.cb_NewUnit.Items.AddRange(new object[] {
            "cup",
            "cups",
            "g",
            "mL",
            "quart",
            "quarts",
            "ounces",
            "oz"});
            this.cb_NewUnit.Location = new System.Drawing.Point(327, 232);
            this.cb_NewUnit.Name = "cb_NewUnit";
            this.cb_NewUnit.Size = new System.Drawing.Size(85, 21);
            this.cb_NewUnit.TabIndex = 13;
            // 
            // tb_NewNum
            // 
            this.tb_NewNum.Location = new System.Drawing.Point(256, 232);
            this.tb_NewNum.Name = "tb_NewNum";
            this.tb_NewNum.ReadOnly = true;
            this.tb_NewNum.Size = new System.Drawing.Size(65, 20);
            this.tb_NewNum.TabIndex = 15;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(256, 259);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(156, 23);
            this.btn_Calculate.TabIndex = 16;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // tb_PrevNum
            // 
            this.tb_PrevNum.Location = new System.Drawing.Point(256, 165);
            this.tb_PrevNum.Name = "tb_PrevNum";
            this.tb_PrevNum.Size = new System.Drawing.Size(65, 20);
            this.tb_PrevNum.TabIndex = 17;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(265, 149);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 18;
            this.lbl_Amount.Text = "Amount";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Location = new System.Drawing.Point(352, 149);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(26, 13);
            this.lbl_Unit.TabIndex = 19;
            this.lbl_Unit.Text = "Unit";
            // 
            // lbl_NewUnit
            // 
            this.lbl_NewUnit.AutoSize = true;
            this.lbl_NewUnit.Location = new System.Drawing.Point(352, 216);
            this.lbl_NewUnit.Name = "lbl_NewUnit";
            this.lbl_NewUnit.Size = new System.Drawing.Size(26, 13);
            this.lbl_NewUnit.TabIndex = 21;
            this.lbl_NewUnit.Text = "Unit";
            // 
            // rb_US
            // 
            this.rb_US.AutoSize = true;
            this.rb_US.Location = new System.Drawing.Point(272, 48);
            this.rb_US.Name = "rb_US";
            this.rb_US.Size = new System.Drawing.Size(46, 17);
            this.rb_US.TabIndex = 22;
            this.rb_US.TabStop = true;
            this.rb_US.Text = "U.S.";
            this.rb_US.UseVisualStyleBackColor = true;
            // 
            // rb_Metric
            // 
            this.rb_Metric.AutoSize = true;
            this.rb_Metric.Location = new System.Drawing.Point(331, 48);
            this.rb_Metric.Name = "rb_Metric";
            this.rb_Metric.Size = new System.Drawing.Size(81, 17);
            this.rb_Metric.TabIndex = 23;
            this.rb_Metric.TabStop = true;
            this.rb_Metric.Text = "Metric (U.K)";
            this.rb_Metric.UseVisualStyleBackColor = true;
            // 
            // lbl_WhatSystem
            // 
            this.lbl_WhatSystem.AutoSize = true;
            this.lbl_WhatSystem.Location = new System.Drawing.Point(269, 22);
            this.lbl_WhatSystem.Name = "lbl_WhatSystem";
            this.lbl_WhatSystem.Size = new System.Drawing.Size(143, 13);
            this.lbl_WhatSystem.TabIndex = 24;
            this.lbl_WhatSystem.Text = "What System Is Your Recipe";
            // 
            // btn_swap
            // 
            this.btn_swap.Location = new System.Drawing.Point(308, 195);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(32, 23);
            this.btn_swap.TabIndex = 25;
            this.btn_swap.Text = "⇅";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(424, 458);
            this.Controls.Add(this.btn_swap);
            this.Controls.Add(this.lbl_WhatSystem);
            this.Controls.Add(this.rb_Metric);
            this.Controls.Add(this.rb_US);
            this.Controls.Add(this.lbl_NewUnit);
            this.Controls.Add(this.lbl_Unit);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.tb_PrevNum);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.tb_NewNum);
            this.Controls.Add(this.cb_NewUnit);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.lbl_EnterWhatYouWantToConvert);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.cb_PrevUnit);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.rtb_Main);
            this.Name = "Converter";
            this.Text = "Baking Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.ComboBox cb_PrevUnit;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.RichTextBox rtb_Main;
        private System.Windows.Forms.Label lbl_EnterWhatYouWantToConvert;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.ComboBox cb_NewUnit;
        private System.Windows.Forms.TextBox tb_NewNum;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox tb_PrevNum;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Label lbl_NewUnit;
        private System.Windows.Forms.RadioButton rb_US;
        private System.Windows.Forms.RadioButton rb_Metric;
        private System.Windows.Forms.Label lbl_WhatSystem;
        private System.Windows.Forms.Button btn_swap;
    }
}

