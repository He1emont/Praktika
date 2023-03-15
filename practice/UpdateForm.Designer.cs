
namespace practice
{
    partial class UpdateForm
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.cb_Pol = new System.Windows.Forms.ComboBox();
            this.nud_Ves = new System.Windows.Forms.NumericUpDown();
            this.nud_Vozrast = new System.Windows.Forms.NumericUpDown();
            this.tb_Otchestvo = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Familiya = new System.Windows.Forms.TextBox();
            this.tb_znak = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vozrast)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Update.Location = new System.Drawing.Point(101, 270);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 29);
            this.btn_Update.TabIndex = 31;
            this.btn_Update.Text = "Изменить";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cb_Pol
            // 
            this.cb_Pol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Pol.FormattingEnabled = true;
            this.cb_Pol.Location = new System.Drawing.Point(156, 140);
            this.cb_Pol.Name = "cb_Pol";
            this.cb_Pol.Size = new System.Drawing.Size(149, 28);
            this.cb_Pol.TabIndex = 30;
            // 
            // nud_Ves
            // 
            this.nud_Ves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nud_Ves.Location = new System.Drawing.Point(156, 206);
            this.nud_Ves.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nud_Ves.Name = "nud_Ves";
            this.nud_Ves.Size = new System.Drawing.Size(149, 26);
            this.nud_Ves.TabIndex = 29;
            // 
            // nud_Vozrast
            // 
            this.nud_Vozrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nud_Vozrast.Location = new System.Drawing.Point(156, 174);
            this.nud_Vozrast.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nud_Vozrast.Name = "nud_Vozrast";
            this.nud_Vozrast.Size = new System.Drawing.Size(149, 26);
            this.nud_Vozrast.TabIndex = 28;
            // 
            // tb_Otchestvo
            // 
            this.tb_Otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Otchestvo.Location = new System.Drawing.Point(156, 108);
            this.tb_Otchestvo.Name = "tb_Otchestvo";
            this.tb_Otchestvo.Size = new System.Drawing.Size(149, 26);
            this.tb_Otchestvo.TabIndex = 27;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Name.Location = new System.Drawing.Point(156, 76);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(149, 26);
            this.tb_Name.TabIndex = 26;
            // 
            // tb_Familiya
            // 
            this.tb_Familiya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Familiya.Location = new System.Drawing.Point(156, 44);
            this.tb_Familiya.Name = "tb_Familiya";
            this.tb_Familiya.Size = new System.Drawing.Size(149, 26);
            this.tb_Familiya.TabIndex = 25;
            // 
            // tb_znak
            // 
            this.tb_znak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_znak.Location = new System.Drawing.Point(156, 238);
            this.tb_znak.Name = "tb_znak";
            this.tb_znak.Size = new System.Drawing.Size(149, 26);
            this.tb_znak.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(12, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Знак зодиака";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(12, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Вес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Изменение клиента";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 309);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cb_Pol);
            this.Controls.Add(this.nud_Ves);
            this.Controls.Add(this.nud_Vozrast);
            this.Controls.Add(this.tb_Otchestvo);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Familiya);
            this.Controls.Add(this.tb_znak);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vozrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cb_Pol;
        private System.Windows.Forms.NumericUpDown nud_Ves;
        private System.Windows.Forms.NumericUpDown nud_Vozrast;
        private System.Windows.Forms.TextBox tb_Otchestvo;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Familiya;
        private System.Windows.Forms.TextBox tb_znak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}