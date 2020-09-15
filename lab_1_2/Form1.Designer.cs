using System.Windows.Forms;

namespace lab_1_2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainLeft = new System.Windows.Forms.Panel();
            this.buttonAcceptMainLeft = new System.Windows.Forms.Button();
            this.rbNoFill = new System.Windows.Forms.RadioButton();
            this.RadButMethod_5 = new System.Windows.Forms.RadioButton();
            this.RadButMethod_4 = new System.Windows.Forms.RadioButton();
            this.RadButMethod_3 = new System.Windows.Forms.RadioButton();
            this.RadButMethod_2 = new System.Windows.Forms.RadioButton();
            this.RadButMethod_1 = new System.Windows.Forms.RadioButton();
            this.l1_panelMainLeft = new System.Windows.Forms.Label();
            this.panelMainRight = new System.Windows.Forms.Panel();
            this.panelMethod_5 = new System.Windows.Forms.Panel();
            this.panelMethod_4 = new System.Windows.Forms.Panel();
            this.panelMethod_3 = new System.Windows.Forms.Panel();
            this.panelMethod_2 = new System.Windows.Forms.Panel();
            this.panelMethod_1 = new System.Windows.Forms.Panel();
            this.panelMethod_1_btn_encrypt = new System.Windows.Forms.Button();
            this.panelMethod_1_rbEN = new System.Windows.Forms.RadioButton();
            this.panelMethod_1_rbRU = new System.Windows.Forms.RadioButton();
            this.panelMethod_1_textBox_out = new System.Windows.Forms.TextBox();
            this.panelMethod_1_textBox_in = new System.Windows.Forms.TextBox();
            this.panelMethod_1_l5 = new System.Windows.Forms.Label();
            this.panelMethod_1_textBox_k = new System.Windows.Forms.TextBox();
            this.panelMethod_1_l4 = new System.Windows.Forms.Label();
            this.panelMethod_1_l2 = new System.Windows.Forms.Label();
            this.panelMethod_1_l3 = new System.Windows.Forms.Label();
            this.l1_panelMethod_1 = new System.Windows.Forms.Label();
            this.l1_panelMainRight = new System.Windows.Forms.Label();
            this.panelMainLeft.SuspendLayout();
            this.panelMainRight.SuspendLayout();
            this.panelMethod_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainLeft
            // 
            this.panelMainLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMainLeft.Controls.Add(this.buttonAcceptMainLeft);
            this.panelMainLeft.Controls.Add(this.rbNoFill);
            this.panelMainLeft.Controls.Add(this.RadButMethod_5);
            this.panelMainLeft.Controls.Add(this.RadButMethod_4);
            this.panelMainLeft.Controls.Add(this.RadButMethod_3);
            this.panelMainLeft.Controls.Add(this.RadButMethod_2);
            this.panelMainLeft.Controls.Add(this.RadButMethod_1);
            this.panelMainLeft.Controls.Add(this.l1_panelMainLeft);
            this.panelMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMainLeft.Name = "panelMainLeft";
            this.panelMainLeft.Size = new System.Drawing.Size(334, 531);
            this.panelMainLeft.TabIndex = 0;
            // 
            // buttonAcceptMainLeft
            // 
            this.buttonAcceptMainLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAcceptMainLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcceptMainLeft.Location = new System.Drawing.Point(0, 437);
            this.buttonAcceptMainLeft.Name = "buttonAcceptMainLeft";
            this.buttonAcceptMainLeft.Size = new System.Drawing.Size(334, 94);
            this.buttonAcceptMainLeft.TabIndex = 6;
            this.buttonAcceptMainLeft.Text = "Выбрать";
            this.buttonAcceptMainLeft.UseVisualStyleBackColor = true;
            this.buttonAcceptMainLeft.Click += new System.EventHandler(this.buttonAcceptMainLeft_Click);
            // 
            // rbNoFill
            // 
            this.rbNoFill.AutoSize = true;
            this.rbNoFill.Checked = true;
            this.rbNoFill.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbNoFill.Location = new System.Drawing.Point(17, 292);
            this.rbNoFill.Name = "rbNoFill";
            this.rbNoFill.Padding = new System.Windows.Forms.Padding(0, 230, 0, 0);
            this.rbNoFill.Size = new System.Drawing.Size(32, 261);
            this.rbNoFill.TabIndex = 0;
            this.rbNoFill.TabStop = true;
            this.rbNoFill.Text = ".";
            this.rbNoFill.UseCompatibleTextRendering = true;
            this.rbNoFill.UseVisualStyleBackColor = true;
            // 
            // RadButMethod_5
            // 
            this.RadButMethod_5.AutoSize = true;
            this.RadButMethod_5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_5.Location = new System.Drawing.Point(17, 258);
            this.RadButMethod_5.Name = "RadButMethod_5";
            this.RadButMethod_5.Size = new System.Drawing.Size(309, 28);
            this.RadButMethod_5.TabIndex = 5;
            this.RadButMethod_5.TabStop = true;
            this.RadButMethod_5.Text = "Шифр двойной перестановки";
            this.RadButMethod_5.UseVisualStyleBackColor = true;
            this.RadButMethod_5.Click += new System.EventHandler(this.RadButMethod_5_Click);
            // 
            // RadButMethod_4
            // 
            this.RadButMethod_4.AutoSize = true;
            this.RadButMethod_4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_4.Location = new System.Drawing.Point(17, 224);
            this.RadButMethod_4.Name = "RadButMethod_4";
            this.RadButMethod_4.Size = new System.Drawing.Size(314, 28);
            this.RadButMethod_4.TabIndex = 4;
            this.RadButMethod_4.TabStop = true;
            this.RadButMethod_4.Text = "Биграммный шифр Плейфера";
            this.RadButMethod_4.UseVisualStyleBackColor = true;
            this.RadButMethod_4.Click += new System.EventHandler(this.RadButMethod_4_Click);
            // 
            // RadButMethod_3
            // 
            this.RadButMethod_3.AutoSize = true;
            this.RadButMethod_3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_3.Location = new System.Drawing.Point(17, 166);
            this.RadButMethod_3.Name = "RadButMethod_3";
            this.RadButMethod_3.Size = new System.Drawing.Size(308, 52);
            this.RadButMethod_3.TabIndex = 3;
            this.RadButMethod_3.TabStop = true;
            this.RadButMethod_3.Text = "Шифр\r\n\"Двойной квадрат  Уитстона\"";
            this.RadButMethod_3.UseVisualStyleBackColor = true;
            this.RadButMethod_3.Click += new System.EventHandler(this.RadButMethod_3_Click);
            // 
            // RadButMethod_2
            // 
            this.RadButMethod_2.AutoSize = true;
            this.RadButMethod_2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_2.Location = new System.Drawing.Point(17, 108);
            this.RadButMethod_2.Name = "RadButMethod_2";
            this.RadButMethod_2.Size = new System.Drawing.Size(230, 52);
            this.RadButMethod_2.TabIndex = 2;
            this.RadButMethod_2.TabStop = true;
            this.RadButMethod_2.Text = "Аффиная система \r\n подстановок цезаря";
            this.RadButMethod_2.UseVisualStyleBackColor = true;
            this.RadButMethod_2.Click += new System.EventHandler(this.RadButMethod_2_Click);
            // 
            // RadButMethod_1
            // 
            this.RadButMethod_1.AutoSize = true;
            this.RadButMethod_1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_1.Location = new System.Drawing.Point(17, 50);
            this.RadButMethod_1.Name = "RadButMethod_1";
            this.RadButMethod_1.Size = new System.Drawing.Size(225, 52);
            this.RadButMethod_1.TabIndex = 1;
            this.RadButMethod_1.TabStop = true;
            this.RadButMethod_1.Text = "Система Цезаря \r\n с ключевым словом";
            this.RadButMethod_1.UseVisualStyleBackColor = true;
            this.RadButMethod_1.Click += new System.EventHandler(this.RadButMethod_1_Click);
            // 
            // l1_panelMainLeft
            // 
            this.l1_panelMainLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.l1_panelMainLeft.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1_panelMainLeft.Location = new System.Drawing.Point(0, 0);
            this.l1_panelMainLeft.Name = "l1_panelMainLeft";
            this.l1_panelMainLeft.Size = new System.Drawing.Size(334, 26);
            this.l1_panelMainLeft.TabIndex = 0;
            this.l1_panelMainLeft.Text = "Выберите нужный метод:";
            this.l1_panelMainLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMainRight
            // 
            this.panelMainRight.Controls.Add(this.panelMethod_5);
            this.panelMainRight.Controls.Add(this.panelMethod_4);
            this.panelMainRight.Controls.Add(this.panelMethod_3);
            this.panelMainRight.Controls.Add(this.panelMethod_2);
            this.panelMainRight.Controls.Add(this.panelMethod_1);
            this.panelMainRight.Controls.Add(this.l1_panelMainRight);
            this.panelMainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainRight.Location = new System.Drawing.Point(334, 0);
            this.panelMainRight.MaximumSize = new System.Drawing.Size(816, 530);
            this.panelMainRight.MinimumSize = new System.Drawing.Size(816, 530);
            this.panelMainRight.Name = "panelMainRight";
            this.panelMainRight.Size = new System.Drawing.Size(816, 530);
            this.panelMainRight.TabIndex = 1;
            // 
            // panelMethod_5
            // 
            this.panelMethod_5.Location = new System.Drawing.Point(900, 0);
            this.panelMethod_5.MaximumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_5.MinimumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_5.Name = "panelMethod_5";
            this.panelMethod_5.Size = new System.Drawing.Size(816, 530);
            this.panelMethod_5.TabIndex = 1;
            // 
            // panelMethod_4
            // 
            this.panelMethod_4.Location = new System.Drawing.Point(900, 0);
            this.panelMethod_4.MaximumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_4.MinimumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_4.Name = "panelMethod_4";
            this.panelMethod_4.Size = new System.Drawing.Size(816, 530);
            this.panelMethod_4.TabIndex = 1;
            // 
            // panelMethod_3
            // 
            this.panelMethod_3.Location = new System.Drawing.Point(900, 0);
            this.panelMethod_3.MaximumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_3.MinimumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_3.Name = "panelMethod_3";
            this.panelMethod_3.Size = new System.Drawing.Size(816, 530);
            this.panelMethod_3.TabIndex = 1;
            // 
            // panelMethod_2
            // 
            this.panelMethod_2.Location = new System.Drawing.Point(900, 0);
            this.panelMethod_2.MaximumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_2.MinimumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_2.Name = "panelMethod_2";
            this.panelMethod_2.Size = new System.Drawing.Size(816, 530);
            this.panelMethod_2.TabIndex = 1;
            // 
            // panelMethod_1
            // 
            this.panelMethod_1.Controls.Add(this.panelMethod_1_btn_encrypt);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_rbEN);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_rbRU);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_textBox_out);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_textBox_in);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_l5);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_textBox_k);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_l4);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_l2);
            this.panelMethod_1.Controls.Add(this.panelMethod_1_l3);
            this.panelMethod_1.Controls.Add(this.l1_panelMethod_1);
            this.panelMethod_1.Enabled = false;
            this.panelMethod_1.Location = new System.Drawing.Point(0, 900);
            this.panelMethod_1.MaximumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_1.MinimumSize = new System.Drawing.Size(816, 530);
            this.panelMethod_1.Name = "panelMethod_1";
            this.panelMethod_1.Size = new System.Drawing.Size(816, 530);
            this.panelMethod_1.TabIndex = 1;
            this.panelMethod_1.Visible = false;
            // 
            // panelMethod_1_btn_encrypt
            // 
            this.panelMethod_1_btn_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panelMethod_1_btn_encrypt.Location = new System.Drawing.Point(6, 332);
            this.panelMethod_1_btn_encrypt.Name = "panelMethod_1_btn_encrypt";
            this.panelMethod_1_btn_encrypt.Size = new System.Drawing.Size(802, 57);
            this.panelMethod_1_btn_encrypt.TabIndex = 4;
            this.panelMethod_1_btn_encrypt.Text = "Зашифровать";
            this.panelMethod_1_btn_encrypt.UseVisualStyleBackColor = true;
            this.panelMethod_1_btn_encrypt.Click += new System.EventHandler(this.panelMethod_1_btn_encrypt_Click);
            // 
            // panelMethod_1_rbEN
            // 
            this.panelMethod_1_rbEN.AutoSize = true;
            this.panelMethod_1_rbEN.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMethod_1_rbEN.Location = new System.Drawing.Point(32, 106);
            this.panelMethod_1_rbEN.Name = "panelMethod_1_rbEN";
            this.panelMethod_1_rbEN.Size = new System.Drawing.Size(121, 28);
            this.panelMethod_1_rbEN.TabIndex = 3;
            this.panelMethod_1_rbEN.Text = "Латиница";
            this.panelMethod_1_rbEN.UseVisualStyleBackColor = true;
            this.panelMethod_1_rbEN.Click += new System.EventHandler(this.panelMethod_1_rbEN_Click);
            // 
            // panelMethod_1_rbRU
            // 
            this.panelMethod_1_rbRU.AutoSize = true;
            this.panelMethod_1_rbRU.Checked = true;
            this.panelMethod_1_rbRU.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_1_rbRU.Location = new System.Drawing.Point(32, 72);
            this.panelMethod_1_rbRU.Name = "panelMethod_1_rbRU";
            this.panelMethod_1_rbRU.Size = new System.Drawing.Size(130, 28);
            this.panelMethod_1_rbRU.TabIndex = 3;
            this.panelMethod_1_rbRU.TabStop = true;
            this.panelMethod_1_rbRU.Text = "Кириллица";
            this.panelMethod_1_rbRU.UseVisualStyleBackColor = true;
            this.panelMethod_1_rbRU.Click += new System.EventHandler(this.panelMethod_1_rbRU_Click);
            // 
            // panelMethod_1_textBox_out
            // 
            this.panelMethod_1_textBox_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelMethod_1_textBox_out.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMethod_1_textBox_out.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMethod_1_textBox_out.Location = new System.Drawing.Point(0, 437);
            this.panelMethod_1_textBox_out.MaxLength = 9999;
            this.panelMethod_1_textBox_out.Multiline = true;
            this.panelMethod_1_textBox_out.Name = "panelMethod_1_textBox_out";
            this.panelMethod_1_textBox_out.Size = new System.Drawing.Size(816, 93);
            this.panelMethod_1_textBox_out.TabIndex = 2;
            // 
            // panelMethod_1_textBox_in
            // 
            this.panelMethod_1_textBox_in.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMethod_1_textBox_in.Location = new System.Drawing.Point(0, 220);
            this.panelMethod_1_textBox_in.MaxLength = 9999;
            this.panelMethod_1_textBox_in.Multiline = true;
            this.panelMethod_1_textBox_in.Name = "panelMethod_1_textBox_in";
            this.panelMethod_1_textBox_in.Size = new System.Drawing.Size(816, 93);
            this.panelMethod_1_textBox_in.TabIndex = 2;
            this.panelMethod_1_textBox_in.Enter += new System.EventHandler(this.panelMethod_1_textBox_in_Enter);
            this.panelMethod_1_textBox_in.Leave += new System.EventHandler(this.panelMethod_1_textBox_in_Leave);
            // 
            // panelMethod_1_l5
            // 
            this.panelMethod_1_l5.AutoSize = true;
            this.panelMethod_1_l5.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_1_l5.Location = new System.Drawing.Point(7, 401);
            this.panelMethod_1_l5.Name = "panelMethod_1_l5";
            this.panelMethod_1_l5.Size = new System.Drawing.Size(96, 23);
            this.panelMethod_1_l5.TabIndex = 1;
            this.panelMethod_1_l5.Text = "Результат";
            // 
            // panelMethod_1_textBox_k
            // 
            this.panelMethod_1_textBox_k.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMethod_1_textBox_k.Location = new System.Drawing.Point(485, 72);
            this.panelMethod_1_textBox_k.MaxLength = 2;
            this.panelMethod_1_textBox_k.Name = "panelMethod_1_textBox_k";
            this.panelMethod_1_textBox_k.Size = new System.Drawing.Size(319, 32);
            this.panelMethod_1_textBox_k.TabIndex = 2;
            this.panelMethod_1_textBox_k.Leave += new System.EventHandler(this.panelMethod_1_textBox_k_Leave);
            // 
            // panelMethod_1_l4
            // 
            this.panelMethod_1_l4.AutoSize = true;
            this.panelMethod_1_l4.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_1_l4.Location = new System.Drawing.Point(7, 195);
            this.panelMethod_1_l4.Name = "panelMethod_1_l4";
            this.panelMethod_1_l4.Size = new System.Drawing.Size(228, 23);
            this.panelMethod_1_l4.TabIndex = 1;
            this.panelMethod_1_l4.Text = "Введите ключевое слово:";
            // 
            // panelMethod_1_l2
            // 
            this.panelMethod_1_l2.AutoSize = true;
            this.panelMethod_1_l2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_1_l2.Location = new System.Drawing.Point(7, 46);
            this.panelMethod_1_l2.Name = "panelMethod_1_l2";
            this.panelMethod_1_l2.Size = new System.Drawing.Size(202, 23);
            this.panelMethod_1_l2.TabIndex = 1;
            this.panelMethod_1_l2.Text = "Выберите расскладку:";
            // 
            // panelMethod_1_l3
            // 
            this.panelMethod_1_l3.AutoSize = true;
            this.panelMethod_1_l3.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_1_l3.Location = new System.Drawing.Point(481, 46);
            this.panelMethod_1_l3.Name = "panelMethod_1_l3";
            this.panelMethod_1_l3.Size = new System.Drawing.Size(323, 23);
            this.panelMethod_1_l3.TabIndex = 1;
            this.panelMethod_1_l3.Text = "Введите число(смещение) от 0 до 33:";
            // 
            // l1_panelMethod_1
            // 
            this.l1_panelMethod_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.l1_panelMethod_1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1_panelMethod_1.Location = new System.Drawing.Point(0, 0);
            this.l1_panelMethod_1.Name = "l1_panelMethod_1";
            this.l1_panelMethod_1.Size = new System.Drawing.Size(816, 46);
            this.l1_panelMethod_1.TabIndex = 0;
            this.l1_panelMethod_1.Text = "Система Цезаря  с ключевым словом";
            this.l1_panelMethod_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l1_panelMainRight
            // 
            this.l1_panelMainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l1_panelMainRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1_panelMainRight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l1_panelMainRight.Location = new System.Drawing.Point(0, 0);
            this.l1_panelMainRight.Name = "l1_panelMainRight";
            this.l1_panelMainRight.Size = new System.Drawing.Size(816, 530);
            this.l1_panelMainRight.TabIndex = 0;
            this.l1_panelMainRight.Text = "Лабораторная работа №1-2\r\n\r\nподготовили: Кутузов Л., Чернуцкая Е., Скребнев Л.\r\n\r" +
    "\n\r\n\r\n\r\n\r\nДля начала работы выберите нужный метод из списка";
            this.l1_panelMainRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1150, 531);
            this.Controls.Add(this.panelMainRight);
            this.Controls.Add(this.panelMainLeft);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelMainLeft.ResumeLayout(false);
            this.panelMainLeft.PerformLayout();
            this.panelMainRight.ResumeLayout(false);
            this.panelMethod_1.ResumeLayout(false);
            this.panelMethod_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainLeft;
        private System.Windows.Forms.Button buttonAcceptMainLeft;
        private System.Windows.Forms.RadioButton RadButMethod_5;
        private System.Windows.Forms.RadioButton RadButMethod_4;
        private System.Windows.Forms.RadioButton RadButMethod_3;
        private System.Windows.Forms.RadioButton RadButMethod_2;
        private System.Windows.Forms.RadioButton RadButMethod_1;
        private System.Windows.Forms.RadioButton rbNoFill;
        private System.Windows.Forms.Label l1_panelMainLeft;
        private System.Windows.Forms.Panel panelMainRight;
        private System.Windows.Forms.Label l1_panelMainRight;
        private System.Windows.Forms.Panel panelMethod_5;
        private System.Windows.Forms.Panel panelMethod_4;
        private System.Windows.Forms.Panel panelMethod_3;
        private System.Windows.Forms.Panel panelMethod_2;
        private System.Windows.Forms.Panel panelMethod_1;
        private RadioButton panelMethod_1_rbEN;
        private RadioButton panelMethod_1_rbRU;
        private TextBox panelMethod_1_textBox_out;
        private TextBox panelMethod_1_textBox_in;
        private Label panelMethod_1_l5;
        private TextBox panelMethod_1_textBox_k;
        private Label panelMethod_1_l4;
        private Label panelMethod_1_l2;
        private Label panelMethod_1_l3;
        private Label l1_panelMethod_1;
        private Button panelMethod_1_btn_encrypt;
    }
}

