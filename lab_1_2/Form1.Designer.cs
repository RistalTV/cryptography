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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMainLeft = new System.Windows.Forms.Panel();
            this.panelMainLeft_btn_Accept = new System.Windows.Forms.Button();
            this.panelMainLeft_rb_NoFill = new System.Windows.Forms.RadioButton();
            this.panelMainLeft_rb_Method_5 = new System.Windows.Forms.RadioButton();
            this.panelMainLeft_rb_Method_4 = new System.Windows.Forms.RadioButton();
            this.panelMainLeft_rb_Method_3 = new System.Windows.Forms.RadioButton();
            this.panelMainLeft_rb_Method_2 = new System.Windows.Forms.RadioButton();
            this.panelMainLeft_rb_Method_1 = new System.Windows.Forms.RadioButton();
            this.panelMainLeft_l1 = new System.Windows.Forms.Label();
            this.panelMainRight = new System.Windows.Forms.Panel();
            this.panelMethod_5 = new System.Windows.Forms.Panel();
            this.panelMethod_4 = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_table = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_table_dataGrid = new System.Windows.Forms.DataGridView();
            this.panelMethod_4_p_table_dataGrid_Column_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_4_p_table_dataGrid_Column_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_4_p_table_dataGrid_Column_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_4_p_table_dataGrid_Column_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_4_p_table_dataGrid_Column_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_4_p_encrypt = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_encrypt_in = new System.Windows.Forms.TextBox();
            this.panelMethod_4_p_encrypt_btn = new System.Windows.Forms.Button();
            this.panelMethod_4_p_encrypt_out = new System.Windows.Forms.TextBox();
            this.panelMethod_4_p_generate_table = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_p_Method_otions = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3 = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb = new System.Windows.Forms.TextBox();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed = new System.Windows.Forms.Label();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2 = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset = new System.Windows.Forms.TextBox();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1 = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key = new System.Windows.Forms.TextBox();
            this.panelMethod_4_p_generate_table_p_Method_generate = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize = new System.Windows.Forms.RadioButton();
            this.panelMethod_4_p_generate_table_p_Method_generate_offset = new System.Windows.Forms.RadioButton();
            this.panelMethod_4_p_generate_table_p_Method_generate_key = new System.Windows.Forms.RadioButton();
            this.panelMethod_4_p_generate_table_p_Method_generate_label = new System.Windows.Forms.Label();
            this.panelMethod_4_p_generate_table_p_lang = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_p_lang_RU = new System.Windows.Forms.RadioButton();
            this.panelMethod_4_p_generate_table_p_lang_EN = new System.Windows.Forms.RadioButton();
            this.panelMethod_4_p_generate_table_p_lang_label = new System.Windows.Forms.Label();
            this.panelMethod_4_p_generate_table_p_button = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_En_options = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_generate_table_En_options_q = new System.Windows.Forms.RadioButton();
            this.panelMethod_4_p_generate_table_En_options_i_and_j = new System.Windows.Forms.RadioButton();
            this.panelMethod_4_p_generate_table_En_options_label = new System.Windows.Forms.Label();
            this.panelMethod_4_p_generate_table_GenerateBTN = new System.Windows.Forms.Button();
            this.panelMethod_4_p_label = new System.Windows.Forms.Panel();
            this.panelMethod_4_p_label_text = new System.Windows.Forms.Label();
            this.panelMethod_3 = new System.Windows.Forms.Panel();
            this.panelMethod_3_p5_input_and_table = new System.Windows.Forms.Panel();
            this.panelMethod_3_p6 = new System.Windows.Forms.Panel();
            this.panelMethod_3_rb_EN_2 = new System.Windows.Forms.RadioButton();
            this.panelMethod_3_l4 = new System.Windows.Forms.Label();
            this.panelMethod_3_rb_EN_1 = new System.Windows.Forms.RadioButton();
            this.panelMethod_3_p7_inout = new System.Windows.Forms.Panel();
            this.panelMethod_3_p7_inout_encrypt = new System.Windows.Forms.Button();
            this.panelMethod_3_p7_inout_out = new System.Windows.Forms.TextBox();
            this.panelMethod_3_p7_inout_in = new System.Windows.Forms.TextBox();
            this.panelMethod_3_p6_table = new System.Windows.Forms.Panel();
            this.panelMethod_3_p6_table_datagrid = new System.Windows.Forms.DataGridView();
            this.panelMethod_3_p6_table_datagrid_с1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p6_table_datagrid_с13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_3_p1 = new System.Windows.Forms.Panel();
            this.panelMethod_3_Generate_Tables = new System.Windows.Forms.Button();
            this.panelMethod_3_p4_rotation = new System.Windows.Forms.Panel();
            this.panelMethod_3_rb_rotation_Gorizont_2 = new System.Windows.Forms.RadioButton();
            this.panelMethod_3_rb_rotation_Vertic_1 = new System.Windows.Forms.RadioButton();
            this.panelMethod_3_l3 = new System.Windows.Forms.Label();
            this.panelMethod_3_p3_lang = new System.Windows.Forms.Panel();
            this.panelMethod_3_rb_lang_RU_2 = new System.Windows.Forms.RadioButton();
            this.panelMethod_3_rb_lang_EN_1 = new System.Windows.Forms.RadioButton();
            this.panelMethod_3_l2 = new System.Windows.Forms.Label();
            this.panelMethod_3_p2_keys = new System.Windows.Forms.Panel();
            this.panelMethod_3_textBox_key_2 = new System.Windows.Forms.TextBox();
            this.panelMethod_3_textBox_key_1 = new System.Windows.Forms.TextBox();
            this.panelMethod_3_l1 = new System.Windows.Forms.Label();
            this.panelMethod_2 = new System.Windows.Forms.Panel();
            this.panelMethod_2_btn_encrypt = new System.Windows.Forms.Button();
            this.panelMethod_2_dataGridView = new System.Windows.Forms.DataGridView();
            this.panelMethod_2_lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMethod_2_p3 = new System.Windows.Forms.Panel();
            this.panelMethod_2_l5 = new System.Windows.Forms.Label();
            this.panelMethod_2_l4 = new System.Windows.Forms.Label();
            this.panelMethod_2_l6 = new System.Windows.Forms.Label();
            this.panelMethod_2_textBox_out = new System.Windows.Forms.TextBox();
            this.panelMethod_2_textBox_in = new System.Windows.Forms.TextBox();
            this.panelMethod_2_l7 = new System.Windows.Forms.Label();
            this.panelMethod_2_input_data_textbox = new System.Windows.Forms.Panel();
            this.panelMethod_2_pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.panelMethod_2_textBox_B = new System.Windows.Forms.TextBox();
            this.panelMethod_2_textBox_A = new System.Windows.Forms.TextBox();
            this.panelMethod_2_input_data_text = new System.Windows.Forms.Panel();
            this.panelMethod_2_l3 = new System.Windows.Forms.Label();
            this.panelMethod_2_l2 = new System.Windows.Forms.Label();
            this.panelMethod_2_l9_stata = new System.Windows.Forms.Label();
            this.panelMethod_2_l8 = new System.Windows.Forms.Label();
            this.panelMethod_2_l1 = new System.Windows.Forms.Label();
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
            this.panelMethod_1_l1 = new System.Windows.Forms.Label();
            this.panelMainRight_l1 = new System.Windows.Forms.Label();
            this.panelMainLeft.SuspendLayout();
            this.panelMainRight.SuspendLayout();
            this.panelMethod_4.SuspendLayout();
            this.panelMethod_4_p_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMethod_4_p_table_dataGrid)).BeginInit();
            this.panelMethod_4_p_encrypt.SuspendLayout();
            this.panelMethod_4_p_generate_table.SuspendLayout();
            this.panelMethod_4_p_generate_table_p_Method_otions.SuspendLayout();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.SuspendLayout();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.SuspendLayout();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.SuspendLayout();
            this.panelMethod_4_p_generate_table_p_Method_generate.SuspendLayout();
            this.panelMethod_4_p_generate_table_p_lang.SuspendLayout();
            this.panelMethod_4_p_generate_table_p_button.SuspendLayout();
            this.panelMethod_4_p_generate_table_En_options.SuspendLayout();
            this.panelMethod_4_p_label.SuspendLayout();
            this.panelMethod_3.SuspendLayout();
            this.panelMethod_3_p5_input_and_table.SuspendLayout();
            this.panelMethod_3_p6.SuspendLayout();
            this.panelMethod_3_p7_inout.SuspendLayout();
            this.panelMethod_3_p6_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMethod_3_p6_table_datagrid)).BeginInit();
            this.panelMethod_3_p1.SuspendLayout();
            this.panelMethod_3_p4_rotation.SuspendLayout();
            this.panelMethod_3_p3_lang.SuspendLayout();
            this.panelMethod_3_p2_keys.SuspendLayout();
            this.panelMethod_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMethod_2_dataGridView)).BeginInit();
            this.panelMethod_2_p3.SuspendLayout();
            this.panelMethod_2_input_data_textbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMethod_2_pictureBoxHelp)).BeginInit();
            this.panelMethod_2_input_data_text.SuspendLayout();
            this.panelMethod_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainLeft
            // 
            this.panelMainLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMainLeft.Controls.Add(this.panelMainLeft_btn_Accept);
            this.panelMainLeft.Controls.Add(this.panelMainLeft_rb_NoFill);
            this.panelMainLeft.Controls.Add(this.panelMainLeft_rb_Method_5);
            this.panelMainLeft.Controls.Add(this.panelMainLeft_rb_Method_4);
            this.panelMainLeft.Controls.Add(this.panelMainLeft_rb_Method_3);
            this.panelMainLeft.Controls.Add(this.panelMainLeft_rb_Method_2);
            this.panelMainLeft.Controls.Add(this.panelMainLeft_rb_Method_1);
            this.panelMainLeft.Controls.Add(this.panelMainLeft_l1);
            this.panelMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMainLeft.Name = "panelMainLeft";
            this.panelMainLeft.Size = new System.Drawing.Size(334, 531);
            this.panelMainLeft.TabIndex = 0;
            // 
            // panelMainLeft_btn_Accept
            // 
            this.panelMainLeft_btn_Accept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainLeft_btn_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panelMainLeft_btn_Accept.Location = new System.Drawing.Point(0, 437);
            this.panelMainLeft_btn_Accept.Name = "panelMainLeft_btn_Accept";
            this.panelMainLeft_btn_Accept.Size = new System.Drawing.Size(334, 94);
            this.panelMainLeft_btn_Accept.TabIndex = 6;
            this.panelMainLeft_btn_Accept.Text = "Выбрать";
            this.panelMainLeft_btn_Accept.UseVisualStyleBackColor = true;
            this.panelMainLeft_btn_Accept.Click += new System.EventHandler(this.ButtonAcceptMainLeft_Click);
            // 
            // panelMainLeft_rb_NoFill
            // 
            this.panelMainLeft_rb_NoFill.AutoSize = true;
            this.panelMainLeft_rb_NoFill.Checked = true;
            this.panelMainLeft_rb_NoFill.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMainLeft_rb_NoFill.Location = new System.Drawing.Point(17, 292);
            this.panelMainLeft_rb_NoFill.Name = "panelMainLeft_rb_NoFill";
            this.panelMainLeft_rb_NoFill.Padding = new System.Windows.Forms.Padding(0, 230, 0, 0);
            this.panelMainLeft_rb_NoFill.Size = new System.Drawing.Size(32, 261);
            this.panelMainLeft_rb_NoFill.TabIndex = 0;
            this.panelMainLeft_rb_NoFill.TabStop = true;
            this.panelMainLeft_rb_NoFill.Text = ".";
            this.panelMainLeft_rb_NoFill.UseCompatibleTextRendering = true;
            this.panelMainLeft_rb_NoFill.UseVisualStyleBackColor = true;
            // 
            // panelMainLeft_rb_Method_5
            // 
            this.panelMainLeft_rb_Method_5.AutoSize = true;
            this.panelMainLeft_rb_Method_5.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMainLeft_rb_Method_5.Location = new System.Drawing.Point(17, 258);
            this.panelMainLeft_rb_Method_5.Name = "panelMainLeft_rb_Method_5";
            this.panelMainLeft_rb_Method_5.Size = new System.Drawing.Size(309, 28);
            this.panelMainLeft_rb_Method_5.TabIndex = 5;
            this.panelMainLeft_rb_Method_5.TabStop = true;
            this.panelMainLeft_rb_Method_5.Text = "Шифр двойной перестановки";
            this.panelMainLeft_rb_Method_5.UseVisualStyleBackColor = true;
            this.panelMainLeft_rb_Method_5.Click += new System.EventHandler(this.RadButMethod_5_Click);
            // 
            // panelMainLeft_rb_Method_4
            // 
            this.panelMainLeft_rb_Method_4.AutoSize = true;
            this.panelMainLeft_rb_Method_4.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMainLeft_rb_Method_4.Location = new System.Drawing.Point(17, 224);
            this.panelMainLeft_rb_Method_4.Name = "panelMainLeft_rb_Method_4";
            this.panelMainLeft_rb_Method_4.Size = new System.Drawing.Size(314, 28);
            this.panelMainLeft_rb_Method_4.TabIndex = 4;
            this.panelMainLeft_rb_Method_4.TabStop = true;
            this.panelMainLeft_rb_Method_4.Text = "Биграммный шифр Плейфера";
            this.panelMainLeft_rb_Method_4.UseVisualStyleBackColor = true;
            this.panelMainLeft_rb_Method_4.Click += new System.EventHandler(this.RadButMethod_4_Click);
            // 
            // panelMainLeft_rb_Method_3
            // 
            this.panelMainLeft_rb_Method_3.AutoSize = true;
            this.panelMainLeft_rb_Method_3.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMainLeft_rb_Method_3.Location = new System.Drawing.Point(17, 166);
            this.panelMainLeft_rb_Method_3.Name = "panelMainLeft_rb_Method_3";
            this.panelMainLeft_rb_Method_3.Size = new System.Drawing.Size(308, 52);
            this.panelMainLeft_rb_Method_3.TabIndex = 3;
            this.panelMainLeft_rb_Method_3.TabStop = true;
            this.panelMainLeft_rb_Method_3.Text = "Шифр\r\n\"Двойной квадрат  Уитстона\"";
            this.panelMainLeft_rb_Method_3.UseVisualStyleBackColor = true;
            this.panelMainLeft_rb_Method_3.Click += new System.EventHandler(this.RadButMethod_3_Click);
            // 
            // panelMainLeft_rb_Method_2
            // 
            this.panelMainLeft_rb_Method_2.AutoSize = true;
            this.panelMainLeft_rb_Method_2.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMainLeft_rb_Method_2.Location = new System.Drawing.Point(17, 108);
            this.panelMainLeft_rb_Method_2.Name = "panelMainLeft_rb_Method_2";
            this.panelMainLeft_rb_Method_2.Size = new System.Drawing.Size(234, 52);
            this.panelMainLeft_rb_Method_2.TabIndex = 2;
            this.panelMainLeft_rb_Method_2.TabStop = true;
            this.panelMainLeft_rb_Method_2.Text = "Аффиная система \r\n подстановок Цезаря";
            this.panelMainLeft_rb_Method_2.UseVisualStyleBackColor = true;
            this.panelMainLeft_rb_Method_2.Click += new System.EventHandler(this.RadButMethod_2_Click);
            // 
            // panelMainLeft_rb_Method_1
            // 
            this.panelMainLeft_rb_Method_1.AutoSize = true;
            this.panelMainLeft_rb_Method_1.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMainLeft_rb_Method_1.Location = new System.Drawing.Point(17, 50);
            this.panelMainLeft_rb_Method_1.Name = "panelMainLeft_rb_Method_1";
            this.panelMainLeft_rb_Method_1.Size = new System.Drawing.Size(225, 52);
            this.panelMainLeft_rb_Method_1.TabIndex = 1;
            this.panelMainLeft_rb_Method_1.TabStop = true;
            this.panelMainLeft_rb_Method_1.Text = "Система Цезаря \r\n с ключевым словом";
            this.panelMainLeft_rb_Method_1.UseVisualStyleBackColor = true;
            this.panelMainLeft_rb_Method_1.Click += new System.EventHandler(this.RadButMethod_1_Click);
            // 
            // panelMainLeft_l1
            // 
            this.panelMainLeft_l1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainLeft_l1.Font = new System.Drawing.Font("Impact", 15.75F);
            this.panelMainLeft_l1.Location = new System.Drawing.Point(0, 0);
            this.panelMainLeft_l1.Name = "panelMainLeft_l1";
            this.panelMainLeft_l1.Size = new System.Drawing.Size(334, 26);
            this.panelMainLeft_l1.TabIndex = 0;
            this.panelMainLeft_l1.Text = "Выберите нужный метод:";
            this.panelMainLeft_l1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMainRight
            // 
            this.panelMainRight.Controls.Add(this.panelMethod_5);
            this.panelMainRight.Controls.Add(this.panelMethod_4);
            this.panelMainRight.Controls.Add(this.panelMethod_3);
            this.panelMainRight.Controls.Add(this.panelMethod_2);
            this.panelMainRight.Controls.Add(this.panelMethod_1);
            this.panelMainRight.Controls.Add(this.panelMainRight_l1);
            this.panelMainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainRight.Location = new System.Drawing.Point(334, 0);
            this.panelMainRight.MaximumSize = new System.Drawing.Size(1100, 530);
            this.panelMainRight.MinimumSize = new System.Drawing.Size(1100, 530);
            this.panelMainRight.Name = "panelMainRight";
            this.panelMainRight.Size = new System.Drawing.Size(1100, 530);
            this.panelMainRight.TabIndex = 1;
            // 
            // panelMethod_5
            // 
            this.panelMethod_5.Enabled = false;
            this.panelMethod_5.Location = new System.Drawing.Point(2000, 0);
            this.panelMethod_5.MaximumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_5.MinimumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_5.Name = "panelMethod_5";
            this.panelMethod_5.Size = new System.Drawing.Size(1100, 530);
            this.panelMethod_5.TabIndex = 1;
            this.panelMethod_5.Visible = false;
            // 
            // panelMethod_4
            // 
            this.panelMethod_4.Controls.Add(this.panelMethod_4_p_table);
            this.panelMethod_4.Controls.Add(this.panelMethod_4_p_encrypt);
            this.panelMethod_4.Controls.Add(this.panelMethod_4_p_generate_table);
            this.panelMethod_4.Controls.Add(this.panelMethod_4_p_label);
            this.panelMethod_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4.Enabled = false;
            this.panelMethod_4.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4.MaximumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_4.MinimumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_4.Name = "panelMethod_4";
            this.panelMethod_4.Size = new System.Drawing.Size(1100, 530);
            this.panelMethod_4.TabIndex = 1;
            this.panelMethod_4.Visible = false;
            // 
            // panelMethod_4_p_table
            // 
            this.panelMethod_4_p_table.Controls.Add(this.panelMethod_4_p_table_dataGrid);
            this.panelMethod_4_p_table.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMethod_4_p_table.Location = new System.Drawing.Point(841, 46);
            this.panelMethod_4_p_table.Name = "panelMethod_4_p_table";
            this.panelMethod_4_p_table.Size = new System.Drawing.Size(259, 484);
            this.panelMethod_4_p_table.TabIndex = 3;
            // 
            // panelMethod_4_p_table_dataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panelMethod_4_p_table_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.panelMethod_4_p_table_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelMethod_4_p_table_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.panelMethod_4_p_table_dataGrid_Column_1,
            this.panelMethod_4_p_table_dataGrid_Column_2,
            this.panelMethod_4_p_table_dataGrid_Column_3,
            this.panelMethod_4_p_table_dataGrid_Column_4,
            this.panelMethod_4_p_table_dataGrid_Column_5});
            this.panelMethod_4_p_table_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_table_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_table_dataGrid.Name = "panelMethod_4_p_table_dataGrid";
            this.panelMethod_4_p_table_dataGrid.Size = new System.Drawing.Size(259, 484);
            this.panelMethod_4_p_table_dataGrid.TabIndex = 1;
            // 
            // panelMethod_4_p_table_dataGrid_Column_1
            // 
            this.panelMethod_4_p_table_dataGrid_Column_1.Frozen = true;
            this.panelMethod_4_p_table_dataGrid_Column_1.HeaderText = "1";
            this.panelMethod_4_p_table_dataGrid_Column_1.MinimumWidth = 40;
            this.panelMethod_4_p_table_dataGrid_Column_1.Name = "panelMethod_4_p_table_dataGrid_Column_1";
            this.panelMethod_4_p_table_dataGrid_Column_1.ReadOnly = true;
            this.panelMethod_4_p_table_dataGrid_Column_1.Width = 40;
            // 
            // panelMethod_4_p_table_dataGrid_Column_2
            // 
            this.panelMethod_4_p_table_dataGrid_Column_2.Frozen = true;
            this.panelMethod_4_p_table_dataGrid_Column_2.HeaderText = "2";
            this.panelMethod_4_p_table_dataGrid_Column_2.MinimumWidth = 40;
            this.panelMethod_4_p_table_dataGrid_Column_2.Name = "panelMethod_4_p_table_dataGrid_Column_2";
            this.panelMethod_4_p_table_dataGrid_Column_2.ReadOnly = true;
            this.panelMethod_4_p_table_dataGrid_Column_2.Width = 40;
            // 
            // panelMethod_4_p_table_dataGrid_Column_3
            // 
            this.panelMethod_4_p_table_dataGrid_Column_3.Frozen = true;
            this.panelMethod_4_p_table_dataGrid_Column_3.HeaderText = "3";
            this.panelMethod_4_p_table_dataGrid_Column_3.MinimumWidth = 40;
            this.panelMethod_4_p_table_dataGrid_Column_3.Name = "panelMethod_4_p_table_dataGrid_Column_3";
            this.panelMethod_4_p_table_dataGrid_Column_3.ReadOnly = true;
            this.panelMethod_4_p_table_dataGrid_Column_3.Width = 40;
            // 
            // panelMethod_4_p_table_dataGrid_Column_4
            // 
            this.panelMethod_4_p_table_dataGrid_Column_4.Frozen = true;
            this.panelMethod_4_p_table_dataGrid_Column_4.HeaderText = "4";
            this.panelMethod_4_p_table_dataGrid_Column_4.MinimumWidth = 40;
            this.panelMethod_4_p_table_dataGrid_Column_4.Name = "panelMethod_4_p_table_dataGrid_Column_4";
            this.panelMethod_4_p_table_dataGrid_Column_4.ReadOnly = true;
            this.panelMethod_4_p_table_dataGrid_Column_4.Width = 40;
            // 
            // panelMethod_4_p_table_dataGrid_Column_5
            // 
            this.panelMethod_4_p_table_dataGrid_Column_5.Frozen = true;
            this.panelMethod_4_p_table_dataGrid_Column_5.HeaderText = "5";
            this.panelMethod_4_p_table_dataGrid_Column_5.MinimumWidth = 40;
            this.panelMethod_4_p_table_dataGrid_Column_5.Name = "panelMethod_4_p_table_dataGrid_Column_5";
            this.panelMethod_4_p_table_dataGrid_Column_5.ReadOnly = true;
            this.panelMethod_4_p_table_dataGrid_Column_5.Width = 40;
            // 
            // panelMethod_4_p_encrypt
            // 
            this.panelMethod_4_p_encrypt.Controls.Add(this.panelMethod_4_p_encrypt_in);
            this.panelMethod_4_p_encrypt.Controls.Add(this.panelMethod_4_p_encrypt_btn);
            this.panelMethod_4_p_encrypt.Controls.Add(this.panelMethod_4_p_encrypt_out);
            this.panelMethod_4_p_encrypt.Location = new System.Drawing.Point(0, 242);
            this.panelMethod_4_p_encrypt.Name = "panelMethod_4_p_encrypt";
            this.panelMethod_4_p_encrypt.Size = new System.Drawing.Size(842, 288);
            this.panelMethod_4_p_encrypt.TabIndex = 2;
            // 
            // panelMethod_4_p_encrypt_in
            // 
            this.panelMethod_4_p_encrypt_in.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMethod_4_p_encrypt_in.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_encrypt_in.Location = new System.Drawing.Point(0, -5);
            this.panelMethod_4_p_encrypt_in.MaxLength = 25;
            this.panelMethod_4_p_encrypt_in.Multiline = true;
            this.panelMethod_4_p_encrypt_in.Name = "panelMethod_4_p_encrypt_in";
            this.panelMethod_4_p_encrypt_in.Size = new System.Drawing.Size(842, 125);
            this.panelMethod_4_p_encrypt_in.TabIndex = 7;
            this.panelMethod_4_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
            this.panelMethod_4_p_encrypt_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelMethod_4_p_encrypt_in.Enter += new System.EventHandler(this.PanelMethod_4_p_encrypt_in_Enter);
            this.panelMethod_4_p_encrypt_in.Leave += new System.EventHandler(this.PanelMethod_4_p_encrypt_in_Leave);
            // 
            // panelMethod_4_p_encrypt_btn
            // 
            this.panelMethod_4_p_encrypt_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMethod_4_p_encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panelMethod_4_p_encrypt_btn.Location = new System.Drawing.Point(0, 120);
            this.panelMethod_4_p_encrypt_btn.Name = "panelMethod_4_p_encrypt_btn";
            this.panelMethod_4_p_encrypt_btn.Size = new System.Drawing.Size(842, 52);
            this.panelMethod_4_p_encrypt_btn.TabIndex = 6;
            this.panelMethod_4_p_encrypt_btn.Text = "Зашифровать";
            this.panelMethod_4_p_encrypt_btn.UseVisualStyleBackColor = true;
            this.panelMethod_4_p_encrypt_btn.Click += new System.EventHandler(this.PanelMethod_4_p_encrypt_btn_Click);
            // 
            // panelMethod_4_p_encrypt_out
            // 
            this.panelMethod_4_p_encrypt_out.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMethod_4_p_encrypt_out.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_encrypt_out.ForeColor = System.Drawing.Color.Black;
            this.panelMethod_4_p_encrypt_out.Location = new System.Drawing.Point(0, 172);
            this.panelMethod_4_p_encrypt_out.MaxLength = 25;
            this.panelMethod_4_p_encrypt_out.Multiline = true;
            this.panelMethod_4_p_encrypt_out.Name = "panelMethod_4_p_encrypt_out";
            this.panelMethod_4_p_encrypt_out.Size = new System.Drawing.Size(842, 116);
            this.panelMethod_4_p_encrypt_out.TabIndex = 1;
            this.panelMethod_4_p_encrypt_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelMethod_4_p_generate_table
            // 
            this.panelMethod_4_p_generate_table.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_otions);
            this.panelMethod_4_p_generate_table.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_generate);
            this.panelMethod_4_p_generate_table.Controls.Add(this.panelMethod_4_p_generate_table_p_lang);
            this.panelMethod_4_p_generate_table.Controls.Add(this.panelMethod_4_p_generate_table_p_button);
            this.panelMethod_4_p_generate_table.Location = new System.Drawing.Point(0, 46);
            this.panelMethod_4_p_generate_table.Name = "panelMethod_4_p_generate_table";
            this.panelMethod_4_p_generate_table.Size = new System.Drawing.Size(842, 190);
            this.panelMethod_4_p_generate_table.TabIndex = 1;
            // 
            // panelMethod_4_p_generate_table_p_Method_otions
            // 
            this.panelMethod_4_p_generate_table_p_Method_otions.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_otions_Method_3);
            this.panelMethod_4_p_generate_table_p_Method_otions.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_otions_Method_2);
            this.panelMethod_4_p_generate_table_p_Method_otions.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_otions_Method_1);
            this.panelMethod_4_p_generate_table_p_Method_otions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_4_p_generate_table_p_Method_otions.Location = new System.Drawing.Point(586, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions.MaximumSize = new System.Drawing.Size(252, 114);
            this.panelMethod_4_p_generate_table_p_Method_otions.Name = "panelMethod_4_p_generate_table_p_Method_otions";
            this.panelMethod_4_p_generate_table_p_Method_otions.Size = new System.Drawing.Size(252, 114);
            this.panelMethod_4_p_generate_table_p_Method_otions.TabIndex = 3;
            // 
            // panelMethod_4_p_generate_table_p_Method_otions_Method_3
            // 
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Enabled = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.MaximumSize = new System.Drawing.Size(252, 120);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Name = "panelMethod_4_p_generate_table_p_Method_otions_Method_3";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Size = new System.Drawing.Size(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.TabIndex = 4;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Visible = false;
            // 
            // panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb
            // 
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.MaxLength = 25;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Multiline = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Name = "panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Size = new System.Drawing.Size(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.TabIndex = 2;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text = "Введите число семени рандомайзера или не трогайте данное поле для генерации случа" +
    "йного семени";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Enter += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb_Enter);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Leave += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb_Leave);
            // 
            // panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed
            // 
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Location = new System.Drawing.Point(0, -24);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Name = "panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Size = new System.Drawing.Size(0, 24);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.TabIndex = 0;
            // 
            // panelMethod_4_p_generate_table_p_Method_otions_Method_2
            // 
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Enabled = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.MaximumSize = new System.Drawing.Size(252, 120);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Name = "panelMethod_4_p_generate_table_p_Method_otions_Method_2";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Size = new System.Drawing.Size(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.TabIndex = 4;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Visible = false;
            // 
            // panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset
            // 
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.MaxLength = 2;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Multiline = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Name = "panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Size = new System.Drawing.Size(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.TabIndex = 1;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Enter += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_otions_Method_2_offset_Enter);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Leave += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_otions_Method_2_offset_Leave);
            // 
            // panelMethod_4_p_generate_table_p_Method_otions_Method_1
            // 
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.MaximumSize = new System.Drawing.Size(252, 120);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Name = "panelMethod_4_p_generate_table_p_Method_otions_Method_1";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Size = new System.Drawing.Size(252, 114);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.TabIndex = 4;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Enter += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_otions_Method_1_Enter);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Leave += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_otions_Method_1_Leave);
            // 
            // panelMethod_4_p_generate_table_p_Method_otions_Method_1_key
            // 
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.MaxLength = 25;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Multiline = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Name = "panelMethod_4_p_generate_table_p_Method_otions_Method_1_key";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Size = new System.Drawing.Size(252, 114);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.TabIndex = 0;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "введите секретное слово";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelMethod_4_p_generate_table_p_Method_generate
            // 
            this.panelMethod_4_p_generate_table_p_Method_generate.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_generate_randomize);
            this.panelMethod_4_p_generate_table_p_Method_generate.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_generate_offset);
            this.panelMethod_4_p_generate_table_p_Method_generate.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_generate_key);
            this.panelMethod_4_p_generate_table_p_Method_generate.Controls.Add(this.panelMethod_4_p_generate_table_p_Method_generate_label);
            this.panelMethod_4_p_generate_table_p_Method_generate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_4_p_generate_table_p_Method_generate.Location = new System.Drawing.Point(226, 0);
            this.panelMethod_4_p_generate_table_p_Method_generate.MaximumSize = new System.Drawing.Size(600, 114);
            this.panelMethod_4_p_generate_table_p_Method_generate.Name = "panelMethod_4_p_generate_table_p_Method_generate";
            this.panelMethod_4_p_generate_table_p_Method_generate.Size = new System.Drawing.Size(360, 114);
            this.panelMethod_4_p_generate_table_p_Method_generate.TabIndex = 2;
            // 
            // panelMethod_4_p_generate_table_p_Method_generate_randomize
            // 
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.AutoSize = true;
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Location = new System.Drawing.Point(0, 78);
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Name = "panelMethod_4_p_generate_table_p_Method_generate_randomize";
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Size = new System.Drawing.Size(360, 27);
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.TabIndex = 2;
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Text = "Случайной растановки";
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.UseVisualStyleBackColor = true;
            this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Click += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_generate_randomize_Click);
            // 
            // panelMethod_4_p_generate_table_p_Method_generate_offset
            // 
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.AutoSize = true;
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.Location = new System.Drawing.Point(0, 51);
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.Name = "panelMethod_4_p_generate_table_p_Method_generate_offset";
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.Size = new System.Drawing.Size(360, 27);
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.TabIndex = 1;
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.Text = "Смещения";
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.UseVisualStyleBackColor = true;
            this.panelMethod_4_p_generate_table_p_Method_generate_offset.Click += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_generate_offset_Click);
            // 
            // panelMethod_4_p_generate_table_p_Method_generate_key
            // 
            this.panelMethod_4_p_generate_table_p_Method_generate_key.AutoSize = true;
            this.panelMethod_4_p_generate_table_p_Method_generate_key.Checked = true;
            this.panelMethod_4_p_generate_table_p_Method_generate_key.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_p_Method_generate_key.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_p_Method_generate_key.Location = new System.Drawing.Point(0, 24);
            this.panelMethod_4_p_generate_table_p_Method_generate_key.Name = "panelMethod_4_p_generate_table_p_Method_generate_key";
            this.panelMethod_4_p_generate_table_p_Method_generate_key.Size = new System.Drawing.Size(360, 27);
            this.panelMethod_4_p_generate_table_p_Method_generate_key.TabIndex = 1;
            this.panelMethod_4_p_generate_table_p_Method_generate_key.TabStop = true;
            this.panelMethod_4_p_generate_table_p_Method_generate_key.Text = "Секретны ключ";
            this.panelMethod_4_p_generate_table_p_Method_generate_key.UseVisualStyleBackColor = true;
            this.panelMethod_4_p_generate_table_p_Method_generate_key.Click += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_Method_generate_key_Click);
            // 
            // panelMethod_4_p_generate_table_p_Method_generate_label
            // 
            this.panelMethod_4_p_generate_table_p_Method_generate_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_p_Method_generate_label.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_4_p_generate_table_p_Method_generate_label.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_Method_generate_label.Name = "panelMethod_4_p_generate_table_p_Method_generate_label";
            this.panelMethod_4_p_generate_table_p_Method_generate_label.Size = new System.Drawing.Size(360, 24);
            this.panelMethod_4_p_generate_table_p_Method_generate_label.TabIndex = 0;
            this.panelMethod_4_p_generate_table_p_Method_generate_label.Text = "Выберите метод генерации таблицы:";
            // 
            // panelMethod_4_p_generate_table_p_lang
            // 
            this.panelMethod_4_p_generate_table_p_lang.Controls.Add(this.panelMethod_4_p_generate_table_p_lang_RU);
            this.panelMethod_4_p_generate_table_p_lang.Controls.Add(this.panelMethod_4_p_generate_table_p_lang_EN);
            this.panelMethod_4_p_generate_table_p_lang.Controls.Add(this.panelMethod_4_p_generate_table_p_lang_label);
            this.panelMethod_4_p_generate_table_p_lang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_4_p_generate_table_p_lang.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_lang.MaximumSize = new System.Drawing.Size(252, 114);
            this.panelMethod_4_p_generate_table_p_lang.Name = "panelMethod_4_p_generate_table_p_lang";
            this.panelMethod_4_p_generate_table_p_lang.Size = new System.Drawing.Size(226, 114);
            this.panelMethod_4_p_generate_table_p_lang.TabIndex = 1;
            // 
            // panelMethod_4_p_generate_table_p_lang_RU
            // 
            this.panelMethod_4_p_generate_table_p_lang_RU.AutoSize = true;
            this.panelMethod_4_p_generate_table_p_lang_RU.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_p_lang_RU.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_p_lang_RU.Location = new System.Drawing.Point(0, 51);
            this.panelMethod_4_p_generate_table_p_lang_RU.Name = "panelMethod_4_p_generate_table_p_lang_RU";
            this.panelMethod_4_p_generate_table_p_lang_RU.Size = new System.Drawing.Size(226, 27);
            this.panelMethod_4_p_generate_table_p_lang_RU.TabIndex = 1;
            this.panelMethod_4_p_generate_table_p_lang_RU.Text = "Кириллица";
            this.panelMethod_4_p_generate_table_p_lang_RU.UseVisualStyleBackColor = true;
            this.panelMethod_4_p_generate_table_p_lang_RU.Click += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_lang_RU_Click);
            // 
            // panelMethod_4_p_generate_table_p_lang_EN
            // 
            this.panelMethod_4_p_generate_table_p_lang_EN.AutoSize = true;
            this.panelMethod_4_p_generate_table_p_lang_EN.Checked = true;
            this.panelMethod_4_p_generate_table_p_lang_EN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_p_lang_EN.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_p_lang_EN.Location = new System.Drawing.Point(0, 24);
            this.panelMethod_4_p_generate_table_p_lang_EN.Name = "panelMethod_4_p_generate_table_p_lang_EN";
            this.panelMethod_4_p_generate_table_p_lang_EN.Size = new System.Drawing.Size(226, 27);
            this.panelMethod_4_p_generate_table_p_lang_EN.TabIndex = 1;
            this.panelMethod_4_p_generate_table_p_lang_EN.TabStop = true;
            this.panelMethod_4_p_generate_table_p_lang_EN.Text = "Латиница";
            this.panelMethod_4_p_generate_table_p_lang_EN.UseVisualStyleBackColor = true;
            this.panelMethod_4_p_generate_table_p_lang_EN.Click += new System.EventHandler(this.PanelMethod_4_p_generate_table_p_lang_EN_Click);
            // 
            // panelMethod_4_p_generate_table_p_lang_label
            // 
            this.panelMethod_4_p_generate_table_p_lang_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_p_lang_label.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_4_p_generate_table_p_lang_label.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_p_lang_label.Name = "panelMethod_4_p_generate_table_p_lang_label";
            this.panelMethod_4_p_generate_table_p_lang_label.Size = new System.Drawing.Size(226, 24);
            this.panelMethod_4_p_generate_table_p_lang_label.TabIndex = 0;
            this.panelMethod_4_p_generate_table_p_lang_label.Text = "Выберите расскладку:";
            // 
            // panelMethod_4_p_generate_table_p_button
            // 
            this.panelMethod_4_p_generate_table_p_button.Controls.Add(this.panelMethod_4_p_generate_table_En_options);
            this.panelMethod_4_p_generate_table_p_button.Controls.Add(this.panelMethod_4_p_generate_table_GenerateBTN);
            this.panelMethod_4_p_generate_table_p_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMethod_4_p_generate_table_p_button.Location = new System.Drawing.Point(0, 114);
            this.panelMethod_4_p_generate_table_p_button.Name = "panelMethod_4_p_generate_table_p_button";
            this.panelMethod_4_p_generate_table_p_button.Size = new System.Drawing.Size(842, 76);
            this.panelMethod_4_p_generate_table_p_button.TabIndex = 0;
            // 
            // panelMethod_4_p_generate_table_En_options
            // 
            this.panelMethod_4_p_generate_table_En_options.Controls.Add(this.panelMethod_4_p_generate_table_En_options_q);
            this.panelMethod_4_p_generate_table_En_options.Controls.Add(this.panelMethod_4_p_generate_table_En_options_i_and_j);
            this.panelMethod_4_p_generate_table_En_options.Controls.Add(this.panelMethod_4_p_generate_table_En_options_label);
            this.panelMethod_4_p_generate_table_En_options.Location = new System.Drawing.Point(429, 0);
            this.panelMethod_4_p_generate_table_En_options.Name = "panelMethod_4_p_generate_table_En_options";
            this.panelMethod_4_p_generate_table_En_options.Size = new System.Drawing.Size(406, 76);
            this.panelMethod_4_p_generate_table_En_options.TabIndex = 6;
            // 
            // panelMethod_4_p_generate_table_En_options_q
            // 
            this.panelMethod_4_p_generate_table_En_options_q.AutoSize = true;
            this.panelMethod_4_p_generate_table_En_options_q.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_En_options_q.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_En_options_q.Location = new System.Drawing.Point(0, 51);
            this.panelMethod_4_p_generate_table_En_options_q.Name = "panelMethod_4_p_generate_table_En_options_q";
            this.panelMethod_4_p_generate_table_En_options_q.Size = new System.Drawing.Size(406, 27);
            this.panelMethod_4_p_generate_table_En_options_q.TabIndex = 1;
            this.panelMethod_4_p_generate_table_En_options_q.Text = "Букву «Q» опустить";
            this.panelMethod_4_p_generate_table_En_options_q.UseVisualStyleBackColor = true;
            // 
            // panelMethod_4_p_generate_table_En_options_i_and_j
            // 
            this.panelMethod_4_p_generate_table_En_options_i_and_j.AutoSize = true;
            this.panelMethod_4_p_generate_table_En_options_i_and_j.Checked = true;
            this.panelMethod_4_p_generate_table_En_options_i_and_j.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_En_options_i_and_j.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_4_p_generate_table_En_options_i_and_j.Location = new System.Drawing.Point(0, 24);
            this.panelMethod_4_p_generate_table_En_options_i_and_j.Name = "panelMethod_4_p_generate_table_En_options_i_and_j";
            this.panelMethod_4_p_generate_table_En_options_i_and_j.Size = new System.Drawing.Size(406, 27);
            this.panelMethod_4_p_generate_table_En_options_i_and_j.TabIndex = 1;
            this.panelMethod_4_p_generate_table_En_options_i_and_j.TabStop = true;
            this.panelMethod_4_p_generate_table_En_options_i_and_j.Text = " Буквы «I» и «J» объединяются в одной клетке";
            this.panelMethod_4_p_generate_table_En_options_i_and_j.UseVisualStyleBackColor = true;
            // 
            // panelMethod_4_p_generate_table_En_options_label
            // 
            this.panelMethod_4_p_generate_table_En_options_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_generate_table_En_options_label.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_4_p_generate_table_En_options_label.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_En_options_label.Name = "panelMethod_4_p_generate_table_En_options_label";
            this.panelMethod_4_p_generate_table_En_options_label.Size = new System.Drawing.Size(406, 24);
            this.panelMethod_4_p_generate_table_En_options_label.TabIndex = 0;
            this.panelMethod_4_p_generate_table_En_options_label.Text = "Выберите:";
            // 
            // panelMethod_4_p_generate_table_GenerateBTN
            // 
            this.panelMethod_4_p_generate_table_GenerateBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_4_p_generate_table_GenerateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panelMethod_4_p_generate_table_GenerateBTN.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_generate_table_GenerateBTN.Name = "panelMethod_4_p_generate_table_GenerateBTN";
            this.panelMethod_4_p_generate_table_GenerateBTN.Size = new System.Drawing.Size(431, 76);
            this.panelMethod_4_p_generate_table_GenerateBTN.TabIndex = 5;
            this.panelMethod_4_p_generate_table_GenerateBTN.Text = "Сгенерировать таблицу";
            this.panelMethod_4_p_generate_table_GenerateBTN.UseVisualStyleBackColor = true;
            this.panelMethod_4_p_generate_table_GenerateBTN.Click += new System.EventHandler(this.PanelMethod_4_p_generate_table_GenerateBTN_Click);
            // 
            // panelMethod_4_p_label
            // 
            this.panelMethod_4_p_label.Controls.Add(this.panelMethod_4_p_label_text);
            this.panelMethod_4_p_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_label.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_label.Name = "panelMethod_4_p_label";
            this.panelMethod_4_p_label.Size = new System.Drawing.Size(1100, 46);
            this.panelMethod_4_p_label.TabIndex = 0;
            // 
            // panelMethod_4_p_label_text
            // 
            this.panelMethod_4_p_label_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_4_p_label_text.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold);
            this.panelMethod_4_p_label_text.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_4_p_label_text.Name = "panelMethod_4_p_label_text";
            this.panelMethod_4_p_label_text.Size = new System.Drawing.Size(1100, 34);
            this.panelMethod_4_p_label_text.TabIndex = 0;
            this.panelMethod_4_p_label_text.Text = "Биграммный шифр Плейфера";
            this.panelMethod_4_p_label_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMethod_3
            // 
            this.panelMethod_3.Controls.Add(this.panelMethod_3_p5_input_and_table);
            this.panelMethod_3.Controls.Add(this.panelMethod_3_p1);
            this.panelMethod_3.Controls.Add(this.panelMethod_3_l1);
            this.panelMethod_3.Enabled = false;
            this.panelMethod_3.Location = new System.Drawing.Point(2000, 0);
            this.panelMethod_3.MaximumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_3.MinimumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_3.Name = "panelMethod_3";
            this.panelMethod_3.Size = new System.Drawing.Size(1100, 530);
            this.panelMethod_3.TabIndex = 1;
            this.panelMethod_3.Visible = false;
            // 
            // panelMethod_3_p5_input_and_table
            // 
            this.panelMethod_3_p5_input_and_table.Controls.Add(this.panelMethod_3_p6);
            this.panelMethod_3_p5_input_and_table.Controls.Add(this.panelMethod_3_p7_inout);
            this.panelMethod_3_p5_input_and_table.Controls.Add(this.panelMethod_3_p6_table);
            this.panelMethod_3_p5_input_and_table.Location = new System.Drawing.Point(0, 134);
            this.panelMethod_3_p5_input_and_table.Name = "panelMethod_3_p5_input_and_table";
            this.panelMethod_3_p5_input_and_table.Size = new System.Drawing.Size(1100, 396);
            this.panelMethod_3_p5_input_and_table.TabIndex = 2;
            // 
            // panelMethod_3_p6
            // 
            this.panelMethod_3_p6.Controls.Add(this.panelMethod_3_rb_EN_2);
            this.panelMethod_3_p6.Controls.Add(this.panelMethod_3_l4);
            this.panelMethod_3_p6.Controls.Add(this.panelMethod_3_rb_EN_1);
            this.panelMethod_3_p6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_3_p6.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_p6.Name = "panelMethod_3_p6";
            this.panelMethod_3_p6.Size = new System.Drawing.Size(1100, 26);
            this.panelMethod_3_p6.TabIndex = 6;
            // 
            // panelMethod_3_rb_EN_2
            // 
            this.panelMethod_3_rb_EN_2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_rb_EN_2.Location = new System.Drawing.Point(528, 1);
            this.panelMethod_3_rb_EN_2.MinimumSize = new System.Drawing.Size(150, 27);
            this.panelMethod_3_rb_EN_2.Name = "panelMethod_3_rb_EN_2";
            this.panelMethod_3_rb_EN_2.Size = new System.Drawing.Size(193, 27);
            this.panelMethod_3_rb_EN_2.TabIndex = 4;
            this.panelMethod_3_rb_EN_2.Text = "Букву «Q» опустить";
            this.panelMethod_3_rb_EN_2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.panelMethod_3_rb_EN_2.UseVisualStyleBackColor = true;
            this.panelMethod_3_rb_EN_2.Click += new System.EventHandler(this.PanelMethod_3_rb_EN_2_Click);
            // 
            // panelMethod_3_l4
            // 
            this.panelMethod_3_l4.AutoSize = true;
            this.panelMethod_3_l4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_l4.Location = new System.Drawing.Point(3, 3);
            this.panelMethod_3_l4.Name = "panelMethod_3_l4";
            this.panelMethod_3_l4.Size = new System.Drawing.Size(108, 23);
            this.panelMethod_3_l4.TabIndex = 2;
            this.panelMethod_3_l4.Text = "Выберите:";
            this.panelMethod_3_l4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMethod_3_rb_EN_1
            // 
            this.panelMethod_3_rb_EN_1.Checked = true;
            this.panelMethod_3_rb_EN_1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_rb_EN_1.Location = new System.Drawing.Point(117, 1);
            this.panelMethod_3_rb_EN_1.Name = "panelMethod_3_rb_EN_1";
            this.panelMethod_3_rb_EN_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelMethod_3_rb_EN_1.Size = new System.Drawing.Size(405, 27);
            this.panelMethod_3_rb_EN_1.TabIndex = 3;
            this.panelMethod_3_rb_EN_1.TabStop = true;
            this.panelMethod_3_rb_EN_1.Text = " Буквы «I» и «J» объединяются в одной клетке";
            this.panelMethod_3_rb_EN_1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.panelMethod_3_rb_EN_1.UseVisualStyleBackColor = true;
            this.panelMethod_3_rb_EN_1.Click += new System.EventHandler(this.PanelMethod_3_rb_EN_1_Click);
            // 
            // panelMethod_3_p7_inout
            // 
            this.panelMethod_3_p7_inout.Controls.Add(this.panelMethod_3_p7_inout_encrypt);
            this.panelMethod_3_p7_inout.Controls.Add(this.panelMethod_3_p7_inout_out);
            this.panelMethod_3_p7_inout.Controls.Add(this.panelMethod_3_p7_inout_in);
            this.panelMethod_3_p7_inout.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMethod_3_p7_inout.Enabled = false;
            this.panelMethod_3_p7_inout.Location = new System.Drawing.Point(-1, 25);
            this.panelMethod_3_p7_inout.MaximumSize = new System.Drawing.Size(1100, 358);
            this.panelMethod_3_p7_inout.MinimumSize = new System.Drawing.Size(550, 203);
            this.panelMethod_3_p7_inout.Name = "panelMethod_3_p7_inout";
            this.panelMethod_3_p7_inout.Size = new System.Drawing.Size(550, 358);
            this.panelMethod_3_p7_inout.TabIndex = 5;
            this.panelMethod_3_p7_inout.Visible = false;
            // 
            // panelMethod_3_p7_inout_encrypt
            // 
            this.panelMethod_3_p7_inout_encrypt.Enabled = false;
            this.panelMethod_3_p7_inout_encrypt.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_p7_inout_encrypt.Location = new System.Drawing.Point(0, 149);
            this.panelMethod_3_p7_inout_encrypt.MaximumSize = new System.Drawing.Size(550, 203);
            this.panelMethod_3_p7_inout_encrypt.MinimumSize = new System.Drawing.Size(100, 60);
            this.panelMethod_3_p7_inout_encrypt.Name = "panelMethod_3_p7_inout_encrypt";
            this.panelMethod_3_p7_inout_encrypt.Size = new System.Drawing.Size(550, 60);
            this.panelMethod_3_p7_inout_encrypt.TabIndex = 2;
            this.panelMethod_3_p7_inout_encrypt.Text = "Зашифровать";
            this.panelMethod_3_p7_inout_encrypt.UseVisualStyleBackColor = true;
            this.panelMethod_3_p7_inout_encrypt.Click += new System.EventHandler(this.PanelMethod_3_p7_inout_encrypt_Click);
            // 
            // panelMethod_3_p7_inout_out
            // 
            this.panelMethod_3_p7_inout_out.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_3_p7_inout_out.Location = new System.Drawing.Point(0, 209);
            this.panelMethod_3_p7_inout_out.MaximumSize = new System.Drawing.Size(550, 203);
            this.panelMethod_3_p7_inout_out.MinimumSize = new System.Drawing.Size(500, 149);
            this.panelMethod_3_p7_inout_out.Multiline = true;
            this.panelMethod_3_p7_inout_out.Name = "panelMethod_3_p7_inout_out";
            this.panelMethod_3_p7_inout_out.Size = new System.Drawing.Size(550, 149);
            this.panelMethod_3_p7_inout_out.TabIndex = 0;
            // 
            // panelMethod_3_p7_inout_in
            // 
            this.panelMethod_3_p7_inout_in.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_3_p7_inout_in.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_p7_inout_in.MaximumSize = new System.Drawing.Size(550, 203);
            this.panelMethod_3_p7_inout_in.MinimumSize = new System.Drawing.Size(500, 149);
            this.panelMethod_3_p7_inout_in.Multiline = true;
            this.panelMethod_3_p7_inout_in.Name = "panelMethod_3_p7_inout_in";
            this.panelMethod_3_p7_inout_in.Size = new System.Drawing.Size(550, 149);
            this.panelMethod_3_p7_inout_in.TabIndex = 0;
            this.panelMethod_3_p7_inout_in.Text = "Введите текст";
            this.panelMethod_3_p7_inout_in.Enter += new System.EventHandler(this.PanelMethod_3_p7_inout_in_Enter);
            this.panelMethod_3_p7_inout_in.Leave += new System.EventHandler(this.PanelMethod_3_p7_inout_in_Leave);
            // 
            // panelMethod_3_p6_table
            // 
            this.panelMethod_3_p6_table.Controls.Add(this.panelMethod_3_p6_table_datagrid);
            this.panelMethod_3_p6_table.Enabled = false;
            this.panelMethod_3_p6_table.Location = new System.Drawing.Point(550, 25);
            this.panelMethod_3_p6_table.MaximumSize = new System.Drawing.Size(1100, 358);
            this.panelMethod_3_p6_table.MinimumSize = new System.Drawing.Size(550, 0);
            this.panelMethod_3_p6_table.Name = "panelMethod_3_p6_table";
            this.panelMethod_3_p6_table.Size = new System.Drawing.Size(550, 358);
            this.panelMethod_3_p6_table.TabIndex = 5;
            this.panelMethod_3_p6_table.Visible = false;
            // 
            // panelMethod_3_p6_table_datagrid
            // 
            this.panelMethod_3_p6_table_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelMethod_3_p6_table_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.panelMethod_3_p6_table_datagrid_с1,
            this.panelMethod_3_p6_table_datagrid_с2,
            this.panelMethod_3_p6_table_datagrid_с3,
            this.panelMethod_3_p6_table_datagrid_с4,
            this.panelMethod_3_p6_table_datagrid_с5,
            this.panelMethod_3_p6_table_datagrid_с6,
            this.panelMethod_3_p6_table_datagrid_с7,
            this.panelMethod_3_p6_table_datagrid_с8,
            this.panelMethod_3_p6_table_datagrid_с9,
            this.panelMethod_3_p6_table_datagrid_с10,
            this.panelMethod_3_p6_table_datagrid_с11,
            this.panelMethod_3_p6_table_datagrid_с12,
            this.panelMethod_3_p6_table_datagrid_с13});
            this.panelMethod_3_p6_table_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_3_p6_table_datagrid.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_p6_table_datagrid.Name = "panelMethod_3_p6_table_datagrid";
            this.panelMethod_3_p6_table_datagrid.Size = new System.Drawing.Size(550, 358);
            this.panelMethod_3_p6_table_datagrid.TabIndex = 0;
            // 
            // panelMethod_3_p6_table_datagrid_с1
            // 
            this.panelMethod_3_p6_table_datagrid_с1.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с1.HeaderText = "1";
            this.panelMethod_3_p6_table_datagrid_с1.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с1.Name = "panelMethod_3_p6_table_datagrid_с1";
            this.panelMethod_3_p6_table_datagrid_с1.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с1.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с2
            // 
            this.panelMethod_3_p6_table_datagrid_с2.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с2.HeaderText = "2";
            this.panelMethod_3_p6_table_datagrid_с2.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с2.Name = "panelMethod_3_p6_table_datagrid_с2";
            this.panelMethod_3_p6_table_datagrid_с2.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с2.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с3
            // 
            this.panelMethod_3_p6_table_datagrid_с3.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с3.HeaderText = "3";
            this.panelMethod_3_p6_table_datagrid_с3.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с3.Name = "panelMethod_3_p6_table_datagrid_с3";
            this.panelMethod_3_p6_table_datagrid_с3.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с3.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с4
            // 
            this.panelMethod_3_p6_table_datagrid_с4.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с4.HeaderText = "4";
            this.panelMethod_3_p6_table_datagrid_с4.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с4.Name = "panelMethod_3_p6_table_datagrid_с4";
            this.panelMethod_3_p6_table_datagrid_с4.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с4.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с5
            // 
            this.panelMethod_3_p6_table_datagrid_с5.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с5.HeaderText = "5";
            this.panelMethod_3_p6_table_datagrid_с5.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с5.Name = "panelMethod_3_p6_table_datagrid_с5";
            this.panelMethod_3_p6_table_datagrid_с5.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с5.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с6
            // 
            this.panelMethod_3_p6_table_datagrid_с6.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с6.HeaderText = "6";
            this.panelMethod_3_p6_table_datagrid_с6.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с6.Name = "panelMethod_3_p6_table_datagrid_с6";
            this.panelMethod_3_p6_table_datagrid_с6.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с6.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с7
            // 
            this.panelMethod_3_p6_table_datagrid_с7.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с7.HeaderText = "7";
            this.panelMethod_3_p6_table_datagrid_с7.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с7.Name = "panelMethod_3_p6_table_datagrid_с7";
            this.panelMethod_3_p6_table_datagrid_с7.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с7.Visible = false;
            this.panelMethod_3_p6_table_datagrid_с7.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с8
            // 
            this.panelMethod_3_p6_table_datagrid_с8.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с8.HeaderText = "8";
            this.panelMethod_3_p6_table_datagrid_с8.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с8.Name = "panelMethod_3_p6_table_datagrid_с8";
            this.panelMethod_3_p6_table_datagrid_с8.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с8.Visible = false;
            this.panelMethod_3_p6_table_datagrid_с8.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с9
            // 
            this.panelMethod_3_p6_table_datagrid_с9.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с9.HeaderText = "9";
            this.panelMethod_3_p6_table_datagrid_с9.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с9.Name = "panelMethod_3_p6_table_datagrid_с9";
            this.panelMethod_3_p6_table_datagrid_с9.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с9.Visible = false;
            this.panelMethod_3_p6_table_datagrid_с9.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с10
            // 
            this.panelMethod_3_p6_table_datagrid_с10.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с10.HeaderText = "10";
            this.panelMethod_3_p6_table_datagrid_с10.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с10.Name = "panelMethod_3_p6_table_datagrid_с10";
            this.panelMethod_3_p6_table_datagrid_с10.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с10.Visible = false;
            this.panelMethod_3_p6_table_datagrid_с10.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с11
            // 
            this.panelMethod_3_p6_table_datagrid_с11.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с11.HeaderText = "11";
            this.panelMethod_3_p6_table_datagrid_с11.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с11.Name = "panelMethod_3_p6_table_datagrid_с11";
            this.panelMethod_3_p6_table_datagrid_с11.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с11.Visible = false;
            this.panelMethod_3_p6_table_datagrid_с11.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с12
            // 
            this.panelMethod_3_p6_table_datagrid_с12.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с12.HeaderText = "12";
            this.panelMethod_3_p6_table_datagrid_с12.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с12.Name = "panelMethod_3_p6_table_datagrid_с12";
            this.panelMethod_3_p6_table_datagrid_с12.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с12.Visible = false;
            this.panelMethod_3_p6_table_datagrid_с12.Width = 30;
            // 
            // panelMethod_3_p6_table_datagrid_с13
            // 
            this.panelMethod_3_p6_table_datagrid_с13.Frozen = true;
            this.panelMethod_3_p6_table_datagrid_с13.HeaderText = "13";
            this.panelMethod_3_p6_table_datagrid_с13.MinimumWidth = 30;
            this.panelMethod_3_p6_table_datagrid_с13.Name = "panelMethod_3_p6_table_datagrid_с13";
            this.panelMethod_3_p6_table_datagrid_с13.ReadOnly = true;
            this.panelMethod_3_p6_table_datagrid_с13.Visible = false;
            this.panelMethod_3_p6_table_datagrid_с13.Width = 30;
            // 
            // panelMethod_3_p1
            // 
            this.panelMethod_3_p1.Controls.Add(this.panelMethod_3_Generate_Tables);
            this.panelMethod_3_p1.Controls.Add(this.panelMethod_3_p4_rotation);
            this.panelMethod_3_p1.Controls.Add(this.panelMethod_3_p3_lang);
            this.panelMethod_3_p1.Controls.Add(this.panelMethod_3_p2_keys);
            this.panelMethod_3_p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_3_p1.Location = new System.Drawing.Point(0, 34);
            this.panelMethod_3_p1.Name = "panelMethod_3_p1";
            this.panelMethod_3_p1.Size = new System.Drawing.Size(1100, 100);
            this.panelMethod_3_p1.TabIndex = 1;
            // 
            // panelMethod_3_Generate_Tables
            // 
            this.panelMethod_3_Generate_Tables.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_Generate_Tables.Location = new System.Drawing.Point(406, 12);
            this.panelMethod_3_Generate_Tables.Name = "panelMethod_3_Generate_Tables";
            this.panelMethod_3_Generate_Tables.Size = new System.Drawing.Size(288, 50);
            this.panelMethod_3_Generate_Tables.TabIndex = 2;
            this.panelMethod_3_Generate_Tables.Text = "Сгенерировать таблицы";
            this.panelMethod_3_Generate_Tables.UseVisualStyleBackColor = true;
            this.panelMethod_3_Generate_Tables.Click += new System.EventHandler(this.PanelMethod_3_Generate_Tables_Click);
            // 
            // panelMethod_3_p4_rotation
            // 
            this.panelMethod_3_p4_rotation.Controls.Add(this.panelMethod_3_rb_rotation_Gorizont_2);
            this.panelMethod_3_p4_rotation.Controls.Add(this.panelMethod_3_rb_rotation_Vertic_1);
            this.panelMethod_3_p4_rotation.Controls.Add(this.panelMethod_3_l3);
            this.panelMethod_3_p4_rotation.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMethod_3_p4_rotation.Location = new System.Drawing.Point(700, 0);
            this.panelMethod_3_p4_rotation.Name = "panelMethod_3_p4_rotation";
            this.panelMethod_3_p4_rotation.Size = new System.Drawing.Size(400, 72);
            this.panelMethod_3_p4_rotation.TabIndex = 1;
            // 
            // panelMethod_3_rb_rotation_Gorizont_2
            // 
            this.panelMethod_3_rb_rotation_Gorizont_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMethod_3_rb_rotation_Gorizont_2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_rb_rotation_Gorizont_2.Location = new System.Drawing.Point(210, 36);
            this.panelMethod_3_rb_rotation_Gorizont_2.MaximumSize = new System.Drawing.Size(190, 36);
            this.panelMethod_3_rb_rotation_Gorizont_2.MinimumSize = new System.Drawing.Size(190, 36);
            this.panelMethod_3_rb_rotation_Gorizont_2.Name = "panelMethod_3_rb_rotation_Gorizont_2";
            this.panelMethod_3_rb_rotation_Gorizont_2.Size = new System.Drawing.Size(190, 36);
            this.panelMethod_3_rb_rotation_Gorizont_2.TabIndex = 1;
            this.panelMethod_3_rb_rotation_Gorizont_2.Text = "Горизонтальный";
            this.panelMethod_3_rb_rotation_Gorizont_2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.panelMethod_3_rb_rotation_Gorizont_2.UseVisualStyleBackColor = true;
            this.panelMethod_3_rb_rotation_Gorizont_2.Click += new System.EventHandler(this.PanelMethod_3_rb_rotation_Gorizont_2_Click);
            // 
            // panelMethod_3_rb_rotation_Vertic_1
            // 
            this.panelMethod_3_rb_rotation_Vertic_1.Checked = true;
            this.panelMethod_3_rb_rotation_Vertic_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_3_rb_rotation_Vertic_1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_rb_rotation_Vertic_1.Location = new System.Drawing.Point(0, 36);
            this.panelMethod_3_rb_rotation_Vertic_1.MaximumSize = new System.Drawing.Size(190, 36);
            this.panelMethod_3_rb_rotation_Vertic_1.MinimumSize = new System.Drawing.Size(190, 36);
            this.panelMethod_3_rb_rotation_Vertic_1.Name = "panelMethod_3_rb_rotation_Vertic_1";
            this.panelMethod_3_rb_rotation_Vertic_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelMethod_3_rb_rotation_Vertic_1.Size = new System.Drawing.Size(190, 36);
            this.panelMethod_3_rb_rotation_Vertic_1.TabIndex = 1;
            this.panelMethod_3_rb_rotation_Vertic_1.TabStop = true;
            this.panelMethod_3_rb_rotation_Vertic_1.Text = "Вертикальный";
            this.panelMethod_3_rb_rotation_Vertic_1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.panelMethod_3_rb_rotation_Vertic_1.UseVisualStyleBackColor = true;
            this.panelMethod_3_rb_rotation_Vertic_1.Click += new System.EventHandler(this.PanelMethod_3_rb_rotation_Vertic_1_Click);
            // 
            // panelMethod_3_l3
            // 
            this.panelMethod_3_l3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_3_l3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_l3.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_l3.Name = "panelMethod_3_l3";
            this.panelMethod_3_l3.Size = new System.Drawing.Size(400, 36);
            this.panelMethod_3_l3.TabIndex = 0;
            this.panelMethod_3_l3.Text = "Выберите варианты:";
            this.panelMethod_3_l3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelMethod_3_p3_lang
            // 
            this.panelMethod_3_p3_lang.Controls.Add(this.panelMethod_3_rb_lang_RU_2);
            this.panelMethod_3_p3_lang.Controls.Add(this.panelMethod_3_rb_lang_EN_1);
            this.panelMethod_3_p3_lang.Controls.Add(this.panelMethod_3_l2);
            this.panelMethod_3_p3_lang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_3_p3_lang.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_p3_lang.Name = "panelMethod_3_p3_lang";
            this.panelMethod_3_p3_lang.Size = new System.Drawing.Size(400, 72);
            this.panelMethod_3_p3_lang.TabIndex = 1;
            // 
            // panelMethod_3_rb_lang_RU_2
            // 
            this.panelMethod_3_rb_lang_RU_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMethod_3_rb_lang_RU_2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_rb_lang_RU_2.Location = new System.Drawing.Point(210, 36);
            this.panelMethod_3_rb_lang_RU_2.Name = "panelMethod_3_rb_lang_RU_2";
            this.panelMethod_3_rb_lang_RU_2.Size = new System.Drawing.Size(190, 36);
            this.panelMethod_3_rb_lang_RU_2.TabIndex = 1;
            this.panelMethod_3_rb_lang_RU_2.Text = "Кириллица";
            this.panelMethod_3_rb_lang_RU_2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.panelMethod_3_rb_lang_RU_2.UseVisualStyleBackColor = true;
            this.panelMethod_3_rb_lang_RU_2.Click += new System.EventHandler(this.PanelMethod_3_rb_lang_RU_2_Click);
            // 
            // panelMethod_3_rb_lang_EN_1
            // 
            this.panelMethod_3_rb_lang_EN_1.Checked = true;
            this.panelMethod_3_rb_lang_EN_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_3_rb_lang_EN_1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_rb_lang_EN_1.Location = new System.Drawing.Point(0, 36);
            this.panelMethod_3_rb_lang_EN_1.Name = "panelMethod_3_rb_lang_EN_1";
            this.panelMethod_3_rb_lang_EN_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelMethod_3_rb_lang_EN_1.Size = new System.Drawing.Size(190, 36);
            this.panelMethod_3_rb_lang_EN_1.TabIndex = 1;
            this.panelMethod_3_rb_lang_EN_1.TabStop = true;
            this.panelMethod_3_rb_lang_EN_1.Text = "Латиница";
            this.panelMethod_3_rb_lang_EN_1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.panelMethod_3_rb_lang_EN_1.UseVisualStyleBackColor = true;
            this.panelMethod_3_rb_lang_EN_1.Click += new System.EventHandler(this.PanelMethod_3_rb_lang_EN_1_Click);
            // 
            // panelMethod_3_l2
            // 
            this.panelMethod_3_l2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_3_l2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMethod_3_l2.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_l2.Name = "panelMethod_3_l2";
            this.panelMethod_3_l2.Size = new System.Drawing.Size(400, 36);
            this.panelMethod_3_l2.TabIndex = 0;
            this.panelMethod_3_l2.Text = "Выберите расскладку:";
            this.panelMethod_3_l2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelMethod_3_p2_keys
            // 
            this.panelMethod_3_p2_keys.Controls.Add(this.panelMethod_3_textBox_key_2);
            this.panelMethod_3_p2_keys.Controls.Add(this.panelMethod_3_textBox_key_1);
            this.panelMethod_3_p2_keys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMethod_3_p2_keys.Location = new System.Drawing.Point(0, 72);
            this.panelMethod_3_p2_keys.Name = "panelMethod_3_p2_keys";
            this.panelMethod_3_p2_keys.Size = new System.Drawing.Size(1100, 28);
            this.panelMethod_3_p2_keys.TabIndex = 0;
            // 
            // panelMethod_3_textBox_key_2
            // 
            this.panelMethod_3_textBox_key_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMethod_3_textBox_key_2.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_3_textBox_key_2.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_3_textBox_key_2.Location = new System.Drawing.Point(550, 0);
            this.panelMethod_3_textBox_key_2.MaxLength = 30;
            this.panelMethod_3_textBox_key_2.Name = "panelMethod_3_textBox_key_2";
            this.panelMethod_3_textBox_key_2.Size = new System.Drawing.Size(550, 31);
            this.panelMethod_3_textBox_key_2.TabIndex = 0;
            this.panelMethod_3_textBox_key_2.Text = "второй секретный ключ";
            this.panelMethod_3_textBox_key_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelMethod_3_textBox_key_2.Enter += new System.EventHandler(this.PanelMethod_3_textBox_key_2_Enter);
            this.panelMethod_3_textBox_key_2.Leave += new System.EventHandler(this.PanelMethod_3_textBox_key_2_Leave);
            // 
            // panelMethod_3_textBox_key_1
            // 
            this.panelMethod_3_textBox_key_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_3_textBox_key_1.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_3_textBox_key_1.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_3_textBox_key_1.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_textBox_key_1.MaxLength = 30;
            this.panelMethod_3_textBox_key_1.Name = "panelMethod_3_textBox_key_1";
            this.panelMethod_3_textBox_key_1.Size = new System.Drawing.Size(550, 31);
            this.panelMethod_3_textBox_key_1.TabIndex = 0;
            this.panelMethod_3_textBox_key_1.Text = "первый секретный ключ";
            this.panelMethod_3_textBox_key_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelMethod_3_textBox_key_1.Enter += new System.EventHandler(this.PanelMethod_3_textBox_key_1_Enter);
            this.panelMethod_3_textBox_key_1.Leave += new System.EventHandler(this.PanelMethod_3_textBox_key_1_Leave);
            // 
            // panelMethod_3_l1
            // 
            this.panelMethod_3_l1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_3_l1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold);
            this.panelMethod_3_l1.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_l1.Name = "panelMethod_3_l1";
            this.panelMethod_3_l1.Size = new System.Drawing.Size(1100, 34);
            this.panelMethod_3_l1.TabIndex = 0;
            this.panelMethod_3_l1.Text = "Двойной квадрат  Уитстона";
            this.panelMethod_3_l1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMethod_2
            // 
            this.panelMethod_2.Controls.Add(this.panelMethod_2_btn_encrypt);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_dataGridView);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_p3);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_textBox_out);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_textBox_in);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_l7);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_input_data_textbox);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_input_data_text);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_l9_stata);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_l8);
            this.panelMethod_2.Controls.Add(this.panelMethod_2_l1);
            this.panelMethod_2.Enabled = false;
            this.panelMethod_2.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_2.Location = new System.Drawing.Point(2000, 0);
            this.panelMethod_2.MaximumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_2.MinimumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_2.Name = "panelMethod_2";
            this.panelMethod_2.Size = new System.Drawing.Size(1100, 530);
            this.panelMethod_2.TabIndex = 1;
            this.panelMethod_2.Visible = false;
            // 
            // panelMethod_2_btn_encrypt
            // 
            this.panelMethod_2_btn_encrypt.Location = new System.Drawing.Point(13, 414);
            this.panelMethod_2_btn_encrypt.Name = "panelMethod_2_btn_encrypt";
            this.panelMethod_2_btn_encrypt.Size = new System.Drawing.Size(1074, 34);
            this.panelMethod_2_btn_encrypt.TabIndex = 7;
            this.panelMethod_2_btn_encrypt.Text = "Зашифровать";
            this.panelMethod_2_btn_encrypt.UseVisualStyleBackColor = true;
            this.panelMethod_2_btn_encrypt.Click += new System.EventHandler(this.PanelMethod_2_btn_encrypt_Click);
            // 
            // panelMethod_2_dataGridView
            // 
            this.panelMethod_2_dataGridView.AllowUserToAddRows = false;
            this.panelMethod_2_dataGridView.AllowUserToDeleteRows = false;
            this.panelMethod_2_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.panelMethod_2_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelMethod_2_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panelMethod_2_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.panelMethod_2_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelMethod_2_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.panelMethod_2_lang,
            this.panelMethod_2_Column1,
            this.panelMethod_2_Column2,
            this.panelMethod_2_Column3,
            this.panelMethod_2_Column4,
            this.panelMethod_2_Column5,
            this.panelMethod_2_Column6,
            this.panelMethod_2_Column7,
            this.panelMethod_2_Column8,
            this.panelMethod_2_Column9,
            this.panelMethod_2_Column10,
            this.panelMethod_2_Column11,
            this.panelMethod_2_Column12,
            this.panelMethod_2_Column13,
            this.panelMethod_2_Column14,
            this.panelMethod_2_Column15,
            this.panelMethod_2_Column16,
            this.panelMethod_2_Column17,
            this.panelMethod_2_Column18,
            this.panelMethod_2_Column19,
            this.panelMethod_2_Column20,
            this.panelMethod_2_Column21,
            this.panelMethod_2_Column22,
            this.panelMethod_2_Column23,
            this.panelMethod_2_Column24,
            this.panelMethod_2_Column25,
            this.panelMethod_2_Column26,
            this.panelMethod_2_Column27,
            this.panelMethod_2_Column28,
            this.panelMethod_2_Column29,
            this.panelMethod_2_Column30,
            this.panelMethod_2_Column31,
            this.panelMethod_2_Column32,
            this.panelMethod_2_Column33});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.panelMethod_2_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.panelMethod_2_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_2_dataGridView.Location = new System.Drawing.Point(0, 160);
            this.panelMethod_2_dataGridView.Name = "panelMethod_2_dataGridView";
            this.panelMethod_2_dataGridView.ReadOnly = true;
            this.panelMethod_2_dataGridView.Size = new System.Drawing.Size(1100, 169);
            this.panelMethod_2_dataGridView.TabIndex = 6;
            // 
            // panelMethod_2_lang
            // 
            this.panelMethod_2_lang.Frozen = true;
            this.panelMethod_2_lang.HeaderText = "Язык";
            this.panelMethod_2_lang.MaxInputLength = 8;
            this.panelMethod_2_lang.MinimumWidth = 60;
            this.panelMethod_2_lang.Name = "panelMethod_2_lang";
            this.panelMethod_2_lang.ReadOnly = true;
            this.panelMethod_2_lang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.panelMethod_2_lang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.panelMethod_2_lang.Width = 60;
            // 
            // panelMethod_2_Column1
            // 
            this.panelMethod_2_Column1.Frozen = true;
            this.panelMethod_2_Column1.HeaderText = "1";
            this.panelMethod_2_Column1.MinimumWidth = 20;
            this.panelMethod_2_Column1.Name = "panelMethod_2_Column1";
            this.panelMethod_2_Column1.ReadOnly = true;
            this.panelMethod_2_Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.panelMethod_2_Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.panelMethod_2_Column1.Width = 30;
            // 
            // panelMethod_2_Column2
            // 
            this.panelMethod_2_Column2.Frozen = true;
            this.panelMethod_2_Column2.HeaderText = "2";
            this.panelMethod_2_Column2.MinimumWidth = 20;
            this.panelMethod_2_Column2.Name = "panelMethod_2_Column2";
            this.panelMethod_2_Column2.ReadOnly = true;
            this.panelMethod_2_Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.panelMethod_2_Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.panelMethod_2_Column2.Width = 30;
            // 
            // panelMethod_2_Column3
            // 
            this.panelMethod_2_Column3.Frozen = true;
            this.panelMethod_2_Column3.HeaderText = "3";
            this.panelMethod_2_Column3.MinimumWidth = 20;
            this.panelMethod_2_Column3.Name = "panelMethod_2_Column3";
            this.panelMethod_2_Column3.ReadOnly = true;
            this.panelMethod_2_Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.panelMethod_2_Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.panelMethod_2_Column3.Width = 30;
            // 
            // panelMethod_2_Column4
            // 
            this.panelMethod_2_Column4.Frozen = true;
            this.panelMethod_2_Column4.HeaderText = "4";
            this.panelMethod_2_Column4.MinimumWidth = 20;
            this.panelMethod_2_Column4.Name = "panelMethod_2_Column4";
            this.panelMethod_2_Column4.ReadOnly = true;
            this.panelMethod_2_Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.panelMethod_2_Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.panelMethod_2_Column4.Width = 30;
            // 
            // panelMethod_2_Column5
            // 
            this.panelMethod_2_Column5.Frozen = true;
            this.panelMethod_2_Column5.HeaderText = "5";
            this.panelMethod_2_Column5.MinimumWidth = 20;
            this.panelMethod_2_Column5.Name = "panelMethod_2_Column5";
            this.panelMethod_2_Column5.ReadOnly = true;
            this.panelMethod_2_Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.panelMethod_2_Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.panelMethod_2_Column5.Width = 30;
            // 
            // panelMethod_2_Column6
            // 
            this.panelMethod_2_Column6.Frozen = true;
            this.panelMethod_2_Column6.HeaderText = "6";
            this.panelMethod_2_Column6.MinimumWidth = 20;
            this.panelMethod_2_Column6.Name = "panelMethod_2_Column6";
            this.panelMethod_2_Column6.ReadOnly = true;
            this.panelMethod_2_Column6.Width = 30;
            // 
            // panelMethod_2_Column7
            // 
            this.panelMethod_2_Column7.Frozen = true;
            this.panelMethod_2_Column7.HeaderText = "7";
            this.panelMethod_2_Column7.MinimumWidth = 20;
            this.panelMethod_2_Column7.Name = "panelMethod_2_Column7";
            this.panelMethod_2_Column7.ReadOnly = true;
            this.panelMethod_2_Column7.Width = 30;
            // 
            // panelMethod_2_Column8
            // 
            this.panelMethod_2_Column8.Frozen = true;
            this.panelMethod_2_Column8.HeaderText = "8";
            this.panelMethod_2_Column8.MinimumWidth = 20;
            this.panelMethod_2_Column8.Name = "panelMethod_2_Column8";
            this.panelMethod_2_Column8.ReadOnly = true;
            this.panelMethod_2_Column8.Width = 30;
            // 
            // panelMethod_2_Column9
            // 
            this.panelMethod_2_Column9.Frozen = true;
            this.panelMethod_2_Column9.HeaderText = "9";
            this.panelMethod_2_Column9.MinimumWidth = 20;
            this.panelMethod_2_Column9.Name = "panelMethod_2_Column9";
            this.panelMethod_2_Column9.ReadOnly = true;
            this.panelMethod_2_Column9.Width = 30;
            // 
            // panelMethod_2_Column10
            // 
            this.panelMethod_2_Column10.Frozen = true;
            this.panelMethod_2_Column10.HeaderText = "10";
            this.panelMethod_2_Column10.MinimumWidth = 30;
            this.panelMethod_2_Column10.Name = "panelMethod_2_Column10";
            this.panelMethod_2_Column10.ReadOnly = true;
            this.panelMethod_2_Column10.Width = 30;
            // 
            // panelMethod_2_Column11
            // 
            this.panelMethod_2_Column11.Frozen = true;
            this.panelMethod_2_Column11.HeaderText = "11";
            this.panelMethod_2_Column11.MinimumWidth = 30;
            this.panelMethod_2_Column11.Name = "panelMethod_2_Column11";
            this.panelMethod_2_Column11.ReadOnly = true;
            this.panelMethod_2_Column11.Width = 30;
            // 
            // panelMethod_2_Column12
            // 
            this.panelMethod_2_Column12.Frozen = true;
            this.panelMethod_2_Column12.HeaderText = "12";
            this.panelMethod_2_Column12.MinimumWidth = 30;
            this.panelMethod_2_Column12.Name = "panelMethod_2_Column12";
            this.panelMethod_2_Column12.ReadOnly = true;
            this.panelMethod_2_Column12.Width = 30;
            // 
            // panelMethod_2_Column13
            // 
            this.panelMethod_2_Column13.Frozen = true;
            this.panelMethod_2_Column13.HeaderText = "13";
            this.panelMethod_2_Column13.MinimumWidth = 30;
            this.panelMethod_2_Column13.Name = "panelMethod_2_Column13";
            this.panelMethod_2_Column13.ReadOnly = true;
            this.panelMethod_2_Column13.Width = 30;
            // 
            // panelMethod_2_Column14
            // 
            this.panelMethod_2_Column14.Frozen = true;
            this.panelMethod_2_Column14.HeaderText = "14";
            this.panelMethod_2_Column14.MinimumWidth = 30;
            this.panelMethod_2_Column14.Name = "panelMethod_2_Column14";
            this.panelMethod_2_Column14.ReadOnly = true;
            this.panelMethod_2_Column14.Width = 30;
            // 
            // panelMethod_2_Column15
            // 
            this.panelMethod_2_Column15.Frozen = true;
            this.panelMethod_2_Column15.HeaderText = "15";
            this.panelMethod_2_Column15.MinimumWidth = 30;
            this.panelMethod_2_Column15.Name = "panelMethod_2_Column15";
            this.panelMethod_2_Column15.ReadOnly = true;
            this.panelMethod_2_Column15.Width = 30;
            // 
            // panelMethod_2_Column16
            // 
            this.panelMethod_2_Column16.Frozen = true;
            this.panelMethod_2_Column16.HeaderText = "16";
            this.panelMethod_2_Column16.MinimumWidth = 30;
            this.panelMethod_2_Column16.Name = "panelMethod_2_Column16";
            this.panelMethod_2_Column16.ReadOnly = true;
            this.panelMethod_2_Column16.Width = 30;
            // 
            // panelMethod_2_Column17
            // 
            this.panelMethod_2_Column17.Frozen = true;
            this.panelMethod_2_Column17.HeaderText = "17";
            this.panelMethod_2_Column17.MinimumWidth = 30;
            this.panelMethod_2_Column17.Name = "panelMethod_2_Column17";
            this.panelMethod_2_Column17.ReadOnly = true;
            this.panelMethod_2_Column17.Width = 30;
            // 
            // panelMethod_2_Column18
            // 
            this.panelMethod_2_Column18.Frozen = true;
            this.panelMethod_2_Column18.HeaderText = "18";
            this.panelMethod_2_Column18.MinimumWidth = 30;
            this.panelMethod_2_Column18.Name = "panelMethod_2_Column18";
            this.panelMethod_2_Column18.ReadOnly = true;
            this.panelMethod_2_Column18.Width = 30;
            // 
            // panelMethod_2_Column19
            // 
            this.panelMethod_2_Column19.Frozen = true;
            this.panelMethod_2_Column19.HeaderText = "19";
            this.panelMethod_2_Column19.MinimumWidth = 30;
            this.panelMethod_2_Column19.Name = "panelMethod_2_Column19";
            this.panelMethod_2_Column19.ReadOnly = true;
            this.panelMethod_2_Column19.Width = 30;
            // 
            // panelMethod_2_Column20
            // 
            this.panelMethod_2_Column20.Frozen = true;
            this.panelMethod_2_Column20.HeaderText = "20";
            this.panelMethod_2_Column20.MinimumWidth = 30;
            this.panelMethod_2_Column20.Name = "panelMethod_2_Column20";
            this.panelMethod_2_Column20.ReadOnly = true;
            this.panelMethod_2_Column20.Width = 30;
            // 
            // panelMethod_2_Column21
            // 
            this.panelMethod_2_Column21.Frozen = true;
            this.panelMethod_2_Column21.HeaderText = "21";
            this.panelMethod_2_Column21.MinimumWidth = 30;
            this.panelMethod_2_Column21.Name = "panelMethod_2_Column21";
            this.panelMethod_2_Column21.ReadOnly = true;
            this.panelMethod_2_Column21.Width = 30;
            // 
            // panelMethod_2_Column22
            // 
            this.panelMethod_2_Column22.Frozen = true;
            this.panelMethod_2_Column22.HeaderText = "22";
            this.panelMethod_2_Column22.MinimumWidth = 30;
            this.panelMethod_2_Column22.Name = "panelMethod_2_Column22";
            this.panelMethod_2_Column22.ReadOnly = true;
            this.panelMethod_2_Column22.Width = 30;
            // 
            // panelMethod_2_Column23
            // 
            this.panelMethod_2_Column23.Frozen = true;
            this.panelMethod_2_Column23.HeaderText = "23";
            this.panelMethod_2_Column23.MinimumWidth = 30;
            this.panelMethod_2_Column23.Name = "panelMethod_2_Column23";
            this.panelMethod_2_Column23.ReadOnly = true;
            this.panelMethod_2_Column23.Width = 30;
            // 
            // panelMethod_2_Column24
            // 
            this.panelMethod_2_Column24.Frozen = true;
            this.panelMethod_2_Column24.HeaderText = "24";
            this.panelMethod_2_Column24.MinimumWidth = 30;
            this.panelMethod_2_Column24.Name = "panelMethod_2_Column24";
            this.panelMethod_2_Column24.ReadOnly = true;
            this.panelMethod_2_Column24.Width = 30;
            // 
            // panelMethod_2_Column25
            // 
            this.panelMethod_2_Column25.Frozen = true;
            this.panelMethod_2_Column25.HeaderText = "25";
            this.panelMethod_2_Column25.MinimumWidth = 30;
            this.panelMethod_2_Column25.Name = "panelMethod_2_Column25";
            this.panelMethod_2_Column25.ReadOnly = true;
            this.panelMethod_2_Column25.Width = 30;
            // 
            // panelMethod_2_Column26
            // 
            this.panelMethod_2_Column26.Frozen = true;
            this.panelMethod_2_Column26.HeaderText = "26";
            this.panelMethod_2_Column26.MinimumWidth = 30;
            this.panelMethod_2_Column26.Name = "panelMethod_2_Column26";
            this.panelMethod_2_Column26.ReadOnly = true;
            this.panelMethod_2_Column26.Width = 30;
            // 
            // panelMethod_2_Column27
            // 
            this.panelMethod_2_Column27.Frozen = true;
            this.panelMethod_2_Column27.HeaderText = "27";
            this.panelMethod_2_Column27.MinimumWidth = 30;
            this.panelMethod_2_Column27.Name = "panelMethod_2_Column27";
            this.panelMethod_2_Column27.ReadOnly = true;
            this.panelMethod_2_Column27.Width = 30;
            // 
            // panelMethod_2_Column28
            // 
            this.panelMethod_2_Column28.Frozen = true;
            this.panelMethod_2_Column28.HeaderText = "28";
            this.panelMethod_2_Column28.MinimumWidth = 30;
            this.panelMethod_2_Column28.Name = "panelMethod_2_Column28";
            this.panelMethod_2_Column28.ReadOnly = true;
            this.panelMethod_2_Column28.Width = 30;
            // 
            // panelMethod_2_Column29
            // 
            this.panelMethod_2_Column29.Frozen = true;
            this.panelMethod_2_Column29.HeaderText = "29";
            this.panelMethod_2_Column29.MinimumWidth = 30;
            this.panelMethod_2_Column29.Name = "panelMethod_2_Column29";
            this.panelMethod_2_Column29.ReadOnly = true;
            this.panelMethod_2_Column29.Width = 30;
            // 
            // panelMethod_2_Column30
            // 
            this.panelMethod_2_Column30.Frozen = true;
            this.panelMethod_2_Column30.HeaderText = "30";
            this.panelMethod_2_Column30.MinimumWidth = 30;
            this.panelMethod_2_Column30.Name = "panelMethod_2_Column30";
            this.panelMethod_2_Column30.ReadOnly = true;
            this.panelMethod_2_Column30.Width = 30;
            // 
            // panelMethod_2_Column31
            // 
            this.panelMethod_2_Column31.Frozen = true;
            this.panelMethod_2_Column31.HeaderText = "31";
            this.panelMethod_2_Column31.MinimumWidth = 30;
            this.panelMethod_2_Column31.Name = "panelMethod_2_Column31";
            this.panelMethod_2_Column31.ReadOnly = true;
            this.panelMethod_2_Column31.Width = 30;
            // 
            // panelMethod_2_Column32
            // 
            this.panelMethod_2_Column32.Frozen = true;
            this.panelMethod_2_Column32.HeaderText = "32";
            this.panelMethod_2_Column32.MinimumWidth = 30;
            this.panelMethod_2_Column32.Name = "panelMethod_2_Column32";
            this.panelMethod_2_Column32.ReadOnly = true;
            this.panelMethod_2_Column32.Width = 30;
            // 
            // panelMethod_2_Column33
            // 
            this.panelMethod_2_Column33.Frozen = true;
            this.panelMethod_2_Column33.HeaderText = "33";
            this.panelMethod_2_Column33.MinimumWidth = 30;
            this.panelMethod_2_Column33.Name = "panelMethod_2_Column33";
            this.panelMethod_2_Column33.ReadOnly = true;
            this.panelMethod_2_Column33.Width = 30;
            // 
            // panelMethod_2_p3
            // 
            this.panelMethod_2_p3.Controls.Add(this.panelMethod_2_l5);
            this.panelMethod_2_p3.Controls.Add(this.panelMethod_2_l4);
            this.panelMethod_2_p3.Controls.Add(this.panelMethod_2_l6);
            this.panelMethod_2_p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_2_p3.Location = new System.Drawing.Point(0, 96);
            this.panelMethod_2_p3.Margin = new System.Windows.Forms.Padding(20);
            this.panelMethod_2_p3.Name = "panelMethod_2_p3";
            this.panelMethod_2_p3.Padding = new System.Windows.Forms.Padding(20);
            this.panelMethod_2_p3.Size = new System.Drawing.Size(1100, 64);
            this.panelMethod_2_p3.TabIndex = 5;
            // 
            // panelMethod_2_l5
            // 
            this.panelMethod_2_l5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMethod_2_l5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic);
            this.panelMethod_2_l5.Location = new System.Drawing.Point(606, 20);
            this.panelMethod_2_l5.Name = "panelMethod_2_l5";
            this.panelMethod_2_l5.Size = new System.Drawing.Size(237, 24);
            this.panelMethod_2_l5.TabIndex = 2;
            this.panelMethod_2_l5.Text = "НОД (1, 33) = 1";
            this.panelMethod_2_l5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMethod_2_l4
            // 
            this.panelMethod_2_l4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_2_l4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold);
            this.panelMethod_2_l4.Location = new System.Drawing.Point(20, 20);
            this.panelMethod_2_l4.Name = "panelMethod_2_l4";
            this.panelMethod_2_l4.Size = new System.Drawing.Size(576, 24);
            this.panelMethod_2_l4.TabIndex = 1;
            this.panelMethod_2_l4.Text = "Алфавит данного шифра";
            this.panelMethod_2_l4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelMethod_2_l6
            // 
            this.panelMethod_2_l6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMethod_2_l6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic);
            this.panelMethod_2_l6.Location = new System.Drawing.Point(843, 20);
            this.panelMethod_2_l6.Name = "panelMethod_2_l6";
            this.panelMethod_2_l6.Size = new System.Drawing.Size(237, 24);
            this.panelMethod_2_l6.TabIndex = 1;
            this.panelMethod_2_l6.Text = "НОД (1, 26) = 1";
            this.panelMethod_2_l6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMethod_2_textBox_out
            // 
            this.panelMethod_2_textBox_out.Location = new System.Drawing.Point(13, 477);
            this.panelMethod_2_textBox_out.Multiline = true;
            this.panelMethod_2_textBox_out.Name = "panelMethod_2_textBox_out";
            this.panelMethod_2_textBox_out.Size = new System.Drawing.Size(1071, 50);
            this.panelMethod_2_textBox_out.TabIndex = 0;
            // 
            // panelMethod_2_textBox_in
            // 
            this.panelMethod_2_textBox_in.Location = new System.Drawing.Point(13, 358);
            this.panelMethod_2_textBox_in.Multiline = true;
            this.panelMethod_2_textBox_in.Name = "panelMethod_2_textBox_in";
            this.panelMethod_2_textBox_in.Size = new System.Drawing.Size(1074, 50);
            this.panelMethod_2_textBox_in.TabIndex = 0;
            // 
            // panelMethod_2_l7
            // 
            this.panelMethod_2_l7.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_2_l7.Location = new System.Drawing.Point(15, 332);
            this.panelMethod_2_l7.Name = "panelMethod_2_l7";
            this.panelMethod_2_l7.Size = new System.Drawing.Size(1082, 23);
            this.panelMethod_2_l7.TabIndex = 1;
            this.panelMethod_2_l7.Text = "Введите сообщение, которое надо защифровать:";
            this.panelMethod_2_l7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMethod_2_input_data_textbox
            // 
            this.panelMethod_2_input_data_textbox.Controls.Add(this.panelMethod_2_pictureBoxHelp);
            this.panelMethod_2_input_data_textbox.Controls.Add(this.panelMethod_2_textBox_B);
            this.panelMethod_2_input_data_textbox.Controls.Add(this.panelMethod_2_textBox_A);
            this.panelMethod_2_input_data_textbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_2_input_data_textbox.Location = new System.Drawing.Point(0, 64);
            this.panelMethod_2_input_data_textbox.Name = "panelMethod_2_input_data_textbox";
            this.panelMethod_2_input_data_textbox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelMethod_2_input_data_textbox.Size = new System.Drawing.Size(1100, 32);
            this.panelMethod_2_input_data_textbox.TabIndex = 4;
            // 
            // panelMethod_2_pictureBoxHelp
            // 
            this.panelMethod_2_pictureBoxHelp.Image = global::lab_1_2.Properties.Resources.help_64x64;
            this.panelMethod_2_pictureBoxHelp.Location = new System.Drawing.Point(484, 0);
            this.panelMethod_2_pictureBoxHelp.Name = "panelMethod_2_pictureBoxHelp";
            this.panelMethod_2_pictureBoxHelp.Size = new System.Drawing.Size(32, 32);
            this.panelMethod_2_pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelMethod_2_pictureBoxHelp.TabIndex = 2;
            this.panelMethod_2_pictureBoxHelp.TabStop = false;
            this.panelMethod_2_pictureBoxHelp.Click += new System.EventHandler(this.PanelMethod_2_pictureBoxHelp_Click);
            // 
            // panelMethod_2_textBox_B
            // 
            this.panelMethod_2_textBox_B.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMethod_2_textBox_B.Location = new System.Drawing.Point(555, 0);
            this.panelMethod_2_textBox_B.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.panelMethod_2_textBox_B.MaxLength = 4;
            this.panelMethod_2_textBox_B.Name = "panelMethod_2_textBox_B";
            this.panelMethod_2_textBox_B.Size = new System.Drawing.Size(532, 32);
            this.panelMethod_2_textBox_B.TabIndex = 1;
            this.panelMethod_2_textBox_B.Text = "1";
            this.panelMethod_2_textBox_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelMethod_2_textBox_B.Leave += new System.EventHandler(this.PanelMethod_2_textBox_B_Leave);
            // 
            // panelMethod_2_textBox_A
            // 
            this.panelMethod_2_textBox_A.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMethod_2_textBox_A.Location = new System.Drawing.Point(8, 0);
            this.panelMethod_2_textBox_A.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.panelMethod_2_textBox_A.MaxLength = 2;
            this.panelMethod_2_textBox_A.Name = "panelMethod_2_textBox_A";
            this.panelMethod_2_textBox_A.Size = new System.Drawing.Size(473, 32);
            this.panelMethod_2_textBox_A.TabIndex = 0;
            this.panelMethod_2_textBox_A.Text = "1";
            this.panelMethod_2_textBox_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelMethod_2_textBox_A.Leave += new System.EventHandler(this.PanelMethod_2_textBox_A_Leave);
            // 
            // panelMethod_2_input_data_text
            // 
            this.panelMethod_2_input_data_text.Controls.Add(this.panelMethod_2_l3);
            this.panelMethod_2_input_data_text.Controls.Add(this.panelMethod_2_l2);
            this.panelMethod_2_input_data_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_2_input_data_text.Location = new System.Drawing.Point(0, 39);
            this.panelMethod_2_input_data_text.Name = "panelMethod_2_input_data_text";
            this.panelMethod_2_input_data_text.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelMethod_2_input_data_text.Size = new System.Drawing.Size(1100, 25);
            this.panelMethod_2_input_data_text.TabIndex = 3;
            // 
            // panelMethod_2_l3
            // 
            this.panelMethod_2_l3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMethod_2_l3.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_2_l3.Location = new System.Drawing.Point(568, 0);
            this.panelMethod_2_l3.Name = "panelMethod_2_l3";
            this.panelMethod_2_l3.Size = new System.Drawing.Size(527, 25);
            this.panelMethod_2_l3.TabIndex = 2;
            this.panelMethod_2_l3.Text = "Введите B:";
            this.panelMethod_2_l3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMethod_2_l2
            // 
            this.panelMethod_2_l2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_2_l2.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_2_l2.Location = new System.Drawing.Point(5, 0);
            this.panelMethod_2_l2.Name = "panelMethod_2_l2";
            this.panelMethod_2_l2.Size = new System.Drawing.Size(497, 25);
            this.panelMethod_2_l2.TabIndex = 1;
            this.panelMethod_2_l2.Text = "Введите A:";
            this.panelMethod_2_l2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMethod_2_l9_stata
            // 
            this.panelMethod_2_l9_stata.AutoSize = true;
            this.panelMethod_2_l9_stata.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_2_l9_stata.Location = new System.Drawing.Point(6600, 421);
            this.panelMethod_2_l9_stata.Name = "panelMethod_2_l9_stata";
            this.panelMethod_2_l9_stata.Size = new System.Drawing.Size(24, 23);
            this.panelMethod_2_l9_stata.TabIndex = 1;
            this.panelMethod_2_l9_stata.Text = "11";
            // 
            // panelMethod_2_l8
            // 
            this.panelMethod_2_l8.AutoSize = true;
            this.panelMethod_2_l8.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_2_l8.Location = new System.Drawing.Point(496, 451);
            this.panelMethod_2_l8.Name = "panelMethod_2_l8";
            this.panelMethod_2_l8.Size = new System.Drawing.Size(100, 23);
            this.panelMethod_2_l8.TabIndex = 1;
            this.panelMethod_2_l8.Text = "Результат:";
            // 
            // panelMethod_2_l1
            // 
            this.panelMethod_2_l1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_2_l1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold);
            this.panelMethod_2_l1.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_2_l1.Name = "panelMethod_2_l1";
            this.panelMethod_2_l1.Size = new System.Drawing.Size(1100, 39);
            this.panelMethod_2_l1.TabIndex = 0;
            this.panelMethod_2_l1.Text = "Аффиная система подстановок Цезаря";
            this.panelMethod_2_l1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panelMethod_1.Controls.Add(this.panelMethod_1_l1);
            this.panelMethod_1.Enabled = false;
            this.panelMethod_1.Location = new System.Drawing.Point(2000, 0);
            this.panelMethod_1.MaximumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_1.MinimumSize = new System.Drawing.Size(1100, 530);
            this.panelMethod_1.Name = "panelMethod_1";
            this.panelMethod_1.Size = new System.Drawing.Size(1100, 530);
            this.panelMethod_1.TabIndex = 1;
            this.panelMethod_1.Visible = false;
            // 
            // panelMethod_1_btn_encrypt
            // 
            this.panelMethod_1_btn_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panelMethod_1_btn_encrypt.Location = new System.Drawing.Point(56, 332);
            this.panelMethod_1_btn_encrypt.Name = "panelMethod_1_btn_encrypt";
            this.panelMethod_1_btn_encrypt.Size = new System.Drawing.Size(984, 57);
            this.panelMethod_1_btn_encrypt.TabIndex = 4;
            this.panelMethod_1_btn_encrypt.Text = "Зашифровать";
            this.panelMethod_1_btn_encrypt.UseVisualStyleBackColor = true;
            this.panelMethod_1_btn_encrypt.Click += new System.EventHandler(this.PanelMethod_1_btn_encrypt_Click);
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
            this.panelMethod_1_rbEN.Click += new System.EventHandler(this.PanelMethod_1_rbEN_Click);
            // 
            // panelMethod_1_rbRU
            // 
            this.panelMethod_1_rbRU.AutoSize = true;
            this.panelMethod_1_rbRU.Checked = true;
            this.panelMethod_1_rbRU.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMethod_1_rbRU.Location = new System.Drawing.Point(32, 72);
            this.panelMethod_1_rbRU.Name = "panelMethod_1_rbRU";
            this.panelMethod_1_rbRU.Size = new System.Drawing.Size(130, 28);
            this.panelMethod_1_rbRU.TabIndex = 3;
            this.panelMethod_1_rbRU.TabStop = true;
            this.panelMethod_1_rbRU.Text = "Кириллица";
            this.panelMethod_1_rbRU.UseVisualStyleBackColor = true;
            this.panelMethod_1_rbRU.Click += new System.EventHandler(this.PanelMethod_1_rbRU_Click);
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
            this.panelMethod_1_textBox_out.Size = new System.Drawing.Size(1100, 93);
            this.panelMethod_1_textBox_out.TabIndex = 2;
            // 
            // panelMethod_1_textBox_in
            // 
            this.panelMethod_1_textBox_in.Font = new System.Drawing.Font("Arial", 15.75F);
            this.panelMethod_1_textBox_in.Location = new System.Drawing.Point(0, 220);
            this.panelMethod_1_textBox_in.MaxLength = 9999;
            this.panelMethod_1_textBox_in.Multiline = true;
            this.panelMethod_1_textBox_in.Name = "panelMethod_1_textBox_in";
            this.panelMethod_1_textBox_in.Size = new System.Drawing.Size(1099, 93);
            this.panelMethod_1_textBox_in.TabIndex = 2;
            this.panelMethod_1_textBox_in.Enter += new System.EventHandler(this.PanelMethod_1_textBox_in_Enter);
            this.panelMethod_1_textBox_in.Leave += new System.EventHandler(this.PanelMethod_1_textBox_in_Leave);
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
            this.panelMethod_1_textBox_k.Location = new System.Drawing.Point(767, 72);
            this.panelMethod_1_textBox_k.MaxLength = 2;
            this.panelMethod_1_textBox_k.Name = "panelMethod_1_textBox_k";
            this.panelMethod_1_textBox_k.Size = new System.Drawing.Size(319, 32);
            this.panelMethod_1_textBox_k.TabIndex = 2;
            this.panelMethod_1_textBox_k.Leave += new System.EventHandler(this.PanelMethod_1_textBox_k_Leave);
            // 
            // panelMethod_1_l4
            // 
            this.panelMethod_1_l4.AutoSize = true;
            this.panelMethod_1_l4.Font = new System.Drawing.Font("Impact", 14.25F);
            this.panelMethod_1_l4.Location = new System.Drawing.Point(7, 195);
            this.panelMethod_1_l4.Name = "panelMethod_1_l4";
            this.panelMethod_1_l4.Size = new System.Drawing.Size(426, 23);
            this.panelMethod_1_l4.TabIndex = 1;
            this.panelMethod_1_l4.Text = "Введите сообщение, которое надо зашифровать:";
            // 
            // panelMethod_1_l2
            // 
            this.panelMethod_1_l2.AutoSize = true;
            this.panelMethod_1_l2.Font = new System.Drawing.Font("Impact", 14.25F);
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
            this.panelMethod_1_l3.Location = new System.Drawing.Point(763, 46);
            this.panelMethod_1_l3.Name = "panelMethod_1_l3";
            this.panelMethod_1_l3.Size = new System.Drawing.Size(323, 23);
            this.panelMethod_1_l3.TabIndex = 1;
            this.panelMethod_1_l3.Text = "Введите число(смещение) от 0 до 33:";
            // 
            // panelMethod_1_l1
            // 
            this.panelMethod_1_l1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMethod_1_l1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold);
            this.panelMethod_1_l1.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_1_l1.Name = "panelMethod_1_l1";
            this.panelMethod_1_l1.Size = new System.Drawing.Size(1100, 46);
            this.panelMethod_1_l1.TabIndex = 0;
            this.panelMethod_1_l1.Text = "Система Цезаря  с ключевым словом";
            this.panelMethod_1_l1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMainRight_l1
            // 
            this.panelMainRight_l1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainRight_l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.panelMainRight_l1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.panelMainRight_l1.Location = new System.Drawing.Point(0, 0);
            this.panelMainRight_l1.Name = "panelMainRight_l1";
            this.panelMainRight_l1.Size = new System.Drawing.Size(1100, 530);
            this.panelMainRight_l1.TabIndex = 0;
            this.panelMainRight_l1.Text = "Лабораторная работа №1-2\r\n\r\nподготовили: Кутузов Л., Чернуцкая Е., Скребнев Л.\r\n\r" +
    "\n\r\n\r\n\r\n\r\nДля начала работы выберите нужный метод из списка";
            this.panelMainRight_l1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1430, 531);
            this.Controls.Add(this.panelMainRight);
            this.Controls.Add(this.panelMainLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №1-2";
            this.panelMainLeft.ResumeLayout(false);
            this.panelMainLeft.PerformLayout();
            this.panelMainRight.ResumeLayout(false);
            this.panelMethod_4.ResumeLayout(false);
            this.panelMethod_4_p_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMethod_4_p_table_dataGrid)).EndInit();
            this.panelMethod_4_p_encrypt.ResumeLayout(false);
            this.panelMethod_4_p_encrypt.PerformLayout();
            this.panelMethod_4_p_generate_table.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_p_Method_otions.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.PerformLayout();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.PerformLayout();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.PerformLayout();
            this.panelMethod_4_p_generate_table_p_Method_generate.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_p_Method_generate.PerformLayout();
            this.panelMethod_4_p_generate_table_p_lang.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_p_lang.PerformLayout();
            this.panelMethod_4_p_generate_table_p_button.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_En_options.ResumeLayout(false);
            this.panelMethod_4_p_generate_table_En_options.PerformLayout();
            this.panelMethod_4_p_label.ResumeLayout(false);
            this.panelMethod_3.ResumeLayout(false);
            this.panelMethod_3_p5_input_and_table.ResumeLayout(false);
            this.panelMethod_3_p6.ResumeLayout(false);
            this.panelMethod_3_p6.PerformLayout();
            this.panelMethod_3_p7_inout.ResumeLayout(false);
            this.panelMethod_3_p7_inout.PerformLayout();
            this.panelMethod_3_p6_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMethod_3_p6_table_datagrid)).EndInit();
            this.panelMethod_3_p1.ResumeLayout(false);
            this.panelMethod_3_p4_rotation.ResumeLayout(false);
            this.panelMethod_3_p3_lang.ResumeLayout(false);
            this.panelMethod_3_p2_keys.ResumeLayout(false);
            this.panelMethod_3_p2_keys.PerformLayout();
            this.panelMethod_2.ResumeLayout(false);
            this.panelMethod_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMethod_2_dataGridView)).EndInit();
            this.panelMethod_2_p3.ResumeLayout(false);
            this.panelMethod_2_input_data_textbox.ResumeLayout(false);
            this.panelMethod_2_input_data_textbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMethod_2_pictureBoxHelp)).EndInit();
            this.panelMethod_2_input_data_text.ResumeLayout(false);
            this.panelMethod_1.ResumeLayout(false);
            this.panelMethod_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainLeft;
        private System.Windows.Forms.Button panelMainLeft_btn_Accept;
        private System.Windows.Forms.RadioButton panelMainLeft_rb_Method_5;
        private System.Windows.Forms.RadioButton panelMainLeft_rb_Method_4;
        private System.Windows.Forms.RadioButton panelMainLeft_rb_Method_3;
        private System.Windows.Forms.RadioButton panelMainLeft_rb_Method_2;
        private System.Windows.Forms.RadioButton panelMainLeft_rb_Method_1;
        private System.Windows.Forms.RadioButton panelMainLeft_rb_NoFill;
        private System.Windows.Forms.Label panelMainLeft_l1;
        private System.Windows.Forms.Panel panelMainRight;
        private System.Windows.Forms.Label panelMainRight_l1;
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
        private Label panelMethod_1_l1;
        private Button panelMethod_1_btn_encrypt;
        private Panel panelMethod_2_p3;
        private Panel panelMethod_2_input_data_textbox;
        private TextBox panelMethod_2_textBox_B;
        private TextBox panelMethod_2_textBox_A;
        private Panel panelMethod_2_input_data_text;
        private Label panelMethod_2_l3;
        private Label panelMethod_2_l2;
        private Label panelMethod_2_l8;
        private Label panelMethod_2_l7;
        private Label panelMethod_2_l6;
        private Label panelMethod_2_l4;
        private Label panelMethod_2_l1;
        private DataGridView panelMethod_2_dataGridView;
        private TextBox panelMethod_2_textBox_in;
        private Button panelMethod_2_btn_encrypt;
        private TextBox panelMethod_2_textBox_out;
        private Label panelMethod_2_l5;
        private PictureBox panelMethod_2_pictureBoxHelp;
        private Label panelMethod_2_l9_stata;
        private DataGridViewTextBoxColumn panelMethod_2_lang;
        private DataGridViewTextBoxColumn panelMethod_2_Column1;
        private DataGridViewTextBoxColumn panelMethod_2_Column2;
        private DataGridViewTextBoxColumn panelMethod_2_Column3;
        private DataGridViewTextBoxColumn panelMethod_2_Column4;
        private DataGridViewTextBoxColumn panelMethod_2_Column5;
        private DataGridViewTextBoxColumn panelMethod_2_Column6;
        private DataGridViewTextBoxColumn panelMethod_2_Column7;
        private DataGridViewTextBoxColumn panelMethod_2_Column8;
        private DataGridViewTextBoxColumn panelMethod_2_Column9;
        private DataGridViewTextBoxColumn panelMethod_2_Column10;
        private DataGridViewTextBoxColumn panelMethod_2_Column11;
        private DataGridViewTextBoxColumn panelMethod_2_Column12;
        private DataGridViewTextBoxColumn panelMethod_2_Column13;
        private DataGridViewTextBoxColumn panelMethod_2_Column14;
        private DataGridViewTextBoxColumn panelMethod_2_Column15;
        private DataGridViewTextBoxColumn panelMethod_2_Column16;
        private DataGridViewTextBoxColumn panelMethod_2_Column17;
        private DataGridViewTextBoxColumn panelMethod_2_Column18;
        private DataGridViewTextBoxColumn panelMethod_2_Column19;
        private DataGridViewTextBoxColumn panelMethod_2_Column20;
        private DataGridViewTextBoxColumn panelMethod_2_Column21;
        private DataGridViewTextBoxColumn panelMethod_2_Column22;
        private DataGridViewTextBoxColumn panelMethod_2_Column23;
        private DataGridViewTextBoxColumn panelMethod_2_Column24;
        private DataGridViewTextBoxColumn panelMethod_2_Column25;
        private DataGridViewTextBoxColumn panelMethod_2_Column26;
        private DataGridViewTextBoxColumn panelMethod_2_Column27;
        private DataGridViewTextBoxColumn panelMethod_2_Column28;
        private DataGridViewTextBoxColumn panelMethod_2_Column29;
        private DataGridViewTextBoxColumn panelMethod_2_Column30;
        private DataGridViewTextBoxColumn panelMethod_2_Column31;
        private DataGridViewTextBoxColumn panelMethod_2_Column32;
        private DataGridViewTextBoxColumn panelMethod_2_Column33;
        private Panel panelMethod_3_p1;
        private Panel panelMethod_3_p4_rotation;
        private RadioButton panelMethod_3_rb_rotation_Gorizont_2;
        private RadioButton panelMethod_3_rb_rotation_Vertic_1;
        private Label panelMethod_3_l3;
        private Panel panelMethod_3_p3_lang;
        private RadioButton panelMethod_3_rb_lang_RU_2;
        private RadioButton panelMethod_3_rb_lang_EN_1;
        private Label panelMethod_3_l2;
        private Panel panelMethod_3_p2_keys;
        private TextBox panelMethod_3_textBox_key_2;
        private TextBox panelMethod_3_textBox_key_1;
        private Label panelMethod_3_l1;
        private Button panelMethod_3_Generate_Tables;
        private Panel panelMethod_3_p5_input_and_table;
        private Panel panelMethod_3_p6;
        private RadioButton panelMethod_3_rb_EN_2;
        private Label panelMethod_3_l4;
        private RadioButton panelMethod_3_rb_EN_1;
        private Panel panelMethod_3_p6_table;
        private Panel panelMethod_3_p7_inout;
        private DataGridView panelMethod_3_p6_table_datagrid;
        private Button panelMethod_3_p7_inout_encrypt;
        private TextBox panelMethod_3_p7_inout_out;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с1;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с2;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с3;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с4;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с5;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с6;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с7;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с8;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с9;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с10;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с11;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с12;
        private DataGridViewTextBoxColumn panelMethod_3_p6_table_datagrid_с13;
        private TextBox panelMethod_3_p7_inout_in;
        private Panel panelMethod_4_p_table;
        private Panel panelMethod_4_p_encrypt;
        private Panel panelMethod_4_p_generate_table;
        private Panel panelMethod_4_p_label;
        private Label panelMethod_4_p_label_text;
        private Panel panelMethod_4_p_generate_table_p_Method_otions;
        private Panel panelMethod_4_p_generate_table_p_Method_otions_Method_1;
        private Panel panelMethod_4_p_generate_table_p_Method_generate;
        private RadioButton panelMethod_4_p_generate_table_p_Method_generate_offset;
        private RadioButton panelMethod_4_p_generate_table_p_Method_generate_key;
        private Label panelMethod_4_p_generate_table_p_Method_generate_label;
        private Panel panelMethod_4_p_generate_table_p_lang;
        private RadioButton panelMethod_4_p_generate_table_p_lang_RU;
        private RadioButton panelMethod_4_p_generate_table_p_lang_EN;
        private Label panelMethod_4_p_generate_table_p_lang_label;
        private Panel panelMethod_4_p_generate_table_p_button;
        private Panel panelMethod_4_p_generate_table_p_Method_otions_Method_2;
        private Panel panelMethod_4_p_generate_table_p_Method_otions_Method_3;
        private Label panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed;
        private TextBox panelMethod_4_p_generate_table_p_Method_otions_Method_1_key;
        private RadioButton panelMethod_4_p_generate_table_p_Method_generate_randomize;
        private TextBox panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset;
        private TextBox panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb;
        private TextBox panelMethod_4_p_encrypt_in;
        private Button panelMethod_4_p_encrypt_btn;
        private TextBox panelMethod_4_p_encrypt_out;
        private Button panelMethod_4_p_generate_table_GenerateBTN;
        private Panel panelMethod_4_p_generate_table_En_options;
        private RadioButton panelMethod_4_p_generate_table_En_options_q;
        private RadioButton panelMethod_4_p_generate_table_En_options_i_and_j;
        private Label panelMethod_4_p_generate_table_En_options_label;
        private DataGridView panelMethod_4_p_table_dataGrid;
        private DataGridViewTextBoxColumn panelMethod_4_p_table_dataGrid_Column_1;
        private DataGridViewTextBoxColumn panelMethod_4_p_table_dataGrid_Column_2;
        private DataGridViewTextBoxColumn panelMethod_4_p_table_dataGrid_Column_3;
        private DataGridViewTextBoxColumn panelMethod_4_p_table_dataGrid_Column_4;
        private DataGridViewTextBoxColumn panelMethod_4_p_table_dataGrid_Column_5;
    }
}

