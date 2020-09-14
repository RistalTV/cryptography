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
            this.RadButMethod_5 = new System.Windows.Forms.RadioButton();
            this.RadButMethod_4 = new System.Windows.Forms.RadioButton();
            this.RadButMethod_3 = new System.Windows.Forms.RadioButton();
            this.RadButMethod_2 = new System.Windows.Forms.RadioButton();
            this.RadButMethod_1 = new System.Windows.Forms.RadioButton();
            this.l1_panelMainLeft = new System.Windows.Forms.Label();
            this.panelMainRight = new System.Windows.Forms.Panel();
            this.l1_panelMainRight = new System.Windows.Forms.Label();
            this.panelMainLeft.SuspendLayout();
            this.panelMainRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainLeft
            // 
            this.panelMainLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMainLeft.Controls.Add(this.buttonAcceptMainLeft);
            this.panelMainLeft.Controls.Add(this.RadButMethod_5);
            this.panelMainLeft.Controls.Add(this.RadButMethod_4);
            this.panelMainLeft.Controls.Add(this.RadButMethod_3);
            this.panelMainLeft.Controls.Add(this.RadButMethod_2);
            this.panelMainLeft.Controls.Add(this.RadButMethod_1);
            this.panelMainLeft.Controls.Add(this.l1_panelMainLeft);
            this.panelMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMainLeft.Name = "panelMainLeft";
            this.panelMainLeft.Size = new System.Drawing.Size(334, 530);
            this.panelMainLeft.TabIndex = 0;
            // 
            // buttonAcceptMainLeft
            // 
            this.buttonAcceptMainLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAcceptMainLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcceptMainLeft.Location = new System.Drawing.Point(0, 436);
            this.buttonAcceptMainLeft.Name = "buttonAcceptMainLeft";
            this.buttonAcceptMainLeft.Size = new System.Drawing.Size(334, 94);
            this.buttonAcceptMainLeft.TabIndex = 2;
            this.buttonAcceptMainLeft.Text = "Выбрать";
            this.buttonAcceptMainLeft.UseVisualStyleBackColor = true;
            // 
            // RadButMethod_5
            // 
            this.RadButMethod_5.AutoSize = true;
            this.RadButMethod_5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_5.Location = new System.Drawing.Point(17, 258);
            this.RadButMethod_5.Name = "RadButMethod_5";
            this.RadButMethod_5.Size = new System.Drawing.Size(309, 28);
            this.RadButMethod_5.TabIndex = 1;
            this.RadButMethod_5.TabStop = true;
            this.RadButMethod_5.Text = "Шифр двойной перестановки";
            this.RadButMethod_5.UseVisualStyleBackColor = true;
            // 
            // RadButMethod_4
            // 
            this.RadButMethod_4.AutoSize = true;
            this.RadButMethod_4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_4.Location = new System.Drawing.Point(17, 224);
            this.RadButMethod_4.Name = "RadButMethod_4";
            this.RadButMethod_4.Size = new System.Drawing.Size(314, 28);
            this.RadButMethod_4.TabIndex = 1;
            this.RadButMethod_4.TabStop = true;
            this.RadButMethod_4.Text = "Биграммный шифр Плейфера";
            this.RadButMethod_4.UseVisualStyleBackColor = true;
            // 
            // RadButMethod_3
            // 
            this.RadButMethod_3.AutoSize = true;
            this.RadButMethod_3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_3.Location = new System.Drawing.Point(17, 166);
            this.RadButMethod_3.Name = "RadButMethod_3";
            this.RadButMethod_3.Size = new System.Drawing.Size(308, 52);
            this.RadButMethod_3.TabIndex = 1;
            this.RadButMethod_3.TabStop = true;
            this.RadButMethod_3.Text = "Шифр\r\n\"Двойной квадрат  Уитстона\"";
            this.RadButMethod_3.UseVisualStyleBackColor = true;
            // 
            // RadButMethod_2
            // 
            this.RadButMethod_2.AutoSize = true;
            this.RadButMethod_2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadButMethod_2.Location = new System.Drawing.Point(17, 108);
            this.RadButMethod_2.Name = "RadButMethod_2";
            this.RadButMethod_2.Size = new System.Drawing.Size(230, 52);
            this.RadButMethod_2.TabIndex = 1;
            this.RadButMethod_2.TabStop = true;
            this.RadButMethod_2.Text = "Аффиная система \r\n подстановок цезаря";
            this.RadButMethod_2.UseVisualStyleBackColor = true;
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
            // 
            // l1_panelMainLeft
            // 
            this.l1_panelMainLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l1_panelMainLeft.AutoSize = true;
            this.l1_panelMainLeft.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1_panelMainLeft.Location = new System.Drawing.Point(34, 9);
            this.l1_panelMainLeft.Name = "l1_panelMainLeft";
            this.l1_panelMainLeft.Size = new System.Drawing.Size(250, 26);
            this.l1_panelMainLeft.TabIndex = 0;
            this.l1_panelMainLeft.Text = "Выберите нужный метод:";
            // 
            // panelMainRight
            // 
            this.panelMainRight.Controls.Add(this.l1_panelMainRight);
            this.panelMainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainRight.Location = new System.Drawing.Point(334, 0);
            this.panelMainRight.MaximumSize = new System.Drawing.Size(816, 530);
            this.panelMainRight.MinimumSize = new System.Drawing.Size(816, 530);
            this.panelMainRight.Name = "panelMainRight";
            this.panelMainRight.Size = new System.Drawing.Size(816, 530);
            this.panelMainRight.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(1150, 530);
            this.Controls.Add(this.panelMainRight);
            this.Controls.Add(this.panelMainLeft);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelMainLeft.ResumeLayout(false);
            this.panelMainLeft.PerformLayout();
            this.panelMainRight.ResumeLayout(false);
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
        private System.Windows.Forms.Label l1_panelMainLeft;
        private System.Windows.Forms.Panel panelMainRight;
        private System.Windows.Forms.Label l1_panelMainRight;
    }
}

