namespace Order_Automizer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpboxManufacturers = new System.Windows.Forms.GroupBox();
            this.cmbManufacturers = new System.Windows.Forms.ComboBox();
            this.grpboxPositions = new System.Windows.Forms.GroupBox();
            this.grpboxCurrentPosition = new System.Windows.Forms.GroupBox();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numCurrentPositionCount = new System.Windows.Forms.NumericUpDown();
            this.txtCurrentPosition = new System.Windows.Forms.TextBox();
            this.lstCurrentPositions = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblManufacturer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpboxDocument = new System.Windows.Forms.GroupBox();
            this.btnExportToXls = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvDocumentTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbout = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpboxManufacturers.SuspendLayout();
            this.grpboxPositions.SuspendLayout();
            this.grpboxCurrentPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentPositionCount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.grpboxDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentTable)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxManufacturers
            // 
            this.grpboxManufacturers.Controls.Add(this.cmbManufacturers);
            this.grpboxManufacturers.Location = new System.Drawing.Point(3, 28);
            this.grpboxManufacturers.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxManufacturers.Name = "grpboxManufacturers";
            this.grpboxManufacturers.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxManufacturers.Size = new System.Drawing.Size(398, 61);
            this.grpboxManufacturers.TabIndex = 0;
            this.grpboxManufacturers.TabStop = false;
            this.grpboxManufacturers.Text = "Производитель";
            // 
            // cmbManufacturers
            // 
            this.cmbManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManufacturers.FormattingEnabled = true;
            this.cmbManufacturers.Location = new System.Drawing.Point(9, 24);
            this.cmbManufacturers.Name = "cmbManufacturers";
            this.cmbManufacturers.Size = new System.Drawing.Size(382, 26);
            this.cmbManufacturers.TabIndex = 0;
            this.cmbManufacturers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpboxPositions
            // 
            this.grpboxPositions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpboxPositions.Controls.Add(this.grpboxCurrentPosition);
            this.grpboxPositions.Controls.Add(this.lstCurrentPositions);
            this.grpboxPositions.Location = new System.Drawing.Point(3, 96);
            this.grpboxPositions.Name = "grpboxPositions";
            this.grpboxPositions.Size = new System.Drawing.Size(398, 520);
            this.grpboxPositions.TabIndex = 1;
            this.grpboxPositions.TabStop = false;
            this.grpboxPositions.Text = "Наименование";
            // 
            // grpboxCurrentPosition
            // 
            this.grpboxCurrentPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpboxCurrentPosition.Controls.Add(this.btnAddPosition);
            this.grpboxCurrentPosition.Controls.Add(this.label1);
            this.grpboxCurrentPosition.Controls.Add(this.numCurrentPositionCount);
            this.grpboxCurrentPosition.Controls.Add(this.txtCurrentPosition);
            this.grpboxCurrentPosition.Location = new System.Drawing.Point(9, 314);
            this.grpboxCurrentPosition.Name = "grpboxCurrentPosition";
            this.grpboxCurrentPosition.Size = new System.Drawing.Size(382, 200);
            this.grpboxCurrentPosition.TabIndex = 1;
            this.grpboxCurrentPosition.TabStop = false;
            this.grpboxCurrentPosition.Text = "Выбранное наименование";
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPosition.Image")));
            this.btnAddPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPosition.Location = new System.Drawing.Point(270, 163);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(106, 31);
            this.btnAddPosition.TabIndex = 3;
            this.btnAddPosition.Text = "Добавить";
            this.btnAddPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество";
            // 
            // numCurrentPositionCount
            // 
            this.numCurrentPositionCount.Location = new System.Drawing.Point(104, 167);
            this.numCurrentPositionCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurrentPositionCount.Name = "numCurrentPositionCount";
            this.numCurrentPositionCount.Size = new System.Drawing.Size(86, 24);
            this.numCurrentPositionCount.TabIndex = 1;
            this.numCurrentPositionCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurrentPositionCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtCurrentPosition
            // 
            this.txtCurrentPosition.Location = new System.Drawing.Point(6, 23);
            this.txtCurrentPosition.Multiline = true;
            this.txtCurrentPosition.Name = "txtCurrentPosition";
            this.txtCurrentPosition.ReadOnly = true;
            this.txtCurrentPosition.Size = new System.Drawing.Size(370, 134);
            this.txtCurrentPosition.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtCurrentPosition, "Нажмите на текст, чтобы скопировать полное название выбранного наименования.");
            this.txtCurrentPosition.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // lstCurrentPositions
            // 
            this.lstCurrentPositions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCurrentPositions.FormattingEnabled = true;
            this.lstCurrentPositions.ItemHeight = 18;
            this.lstCurrentPositions.Location = new System.Drawing.Point(9, 23);
            this.lstCurrentPositions.Name = "lstCurrentPositions";
            this.lstCurrentPositions.Size = new System.Drawing.Size(382, 274);
            this.lstCurrentPositions.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstCurrentPositions, "Кликните по наименованию два раза для добавления в накладную.");
            this.lstCurrentPositions.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lstCurrentPositions.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblManufacturer,
            this.tsslblPosition,
            this.tsslblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblManufacturer
            // 
            this.tsslblManufacturer.Name = "tsslblManufacturer";
            this.tsslblManufacturer.Size = new System.Drawing.Size(98, 17);
            this.tsslblManufacturer.Text = "Производитель: ";
            // 
            // tsslblPosition
            // 
            this.tsslblPosition.Name = "tsslblPosition";
            this.tsslblPosition.Size = new System.Drawing.Size(167, 17);
            this.tsslblPosition.Text = "| Наименование: не выбрано";
            // 
            // tsslblCount
            // 
            this.tsslblCount.Name = "tsslblCount";
            this.tsslblCount.Size = new System.Drawing.Size(64, 17);
            this.tsslblCount.Text = "| Кол-во: 1";
            // 
            // grpboxDocument
            // 
            this.grpboxDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxDocument.Controls.Add(this.btnExportToXls);
            this.grpboxDocument.Controls.Add(this.btnClear);
            this.grpboxDocument.Controls.Add(this.btnRemove);
            this.grpboxDocument.Controls.Add(this.dgvDocumentTable);
            this.grpboxDocument.Location = new System.Drawing.Point(408, 28);
            this.grpboxDocument.Name = "grpboxDocument";
            this.grpboxDocument.Size = new System.Drawing.Size(496, 588);
            this.grpboxDocument.TabIndex = 3;
            this.grpboxDocument.TabStop = false;
            this.grpboxDocument.Text = "Накладная";
            // 
            // btnExportToXls
            // 
            this.btnExportToXls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToXls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToXls.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnExportToXls.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToXls.Image")));
            this.btnExportToXls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToXls.Location = new System.Drawing.Point(301, 545);
            this.btnExportToXls.Name = "btnExportToXls";
            this.btnExportToXls.Size = new System.Drawing.Size(182, 31);
            this.btnExportToXls.TabIndex = 1;
            this.btnExportToXls.Text = "Экспорт в EXCEL";
            this.btnExportToXls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportToXls.UseVisualStyleBackColor = true;
            this.btnExportToXls.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(108, 545);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(6, 545);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 31);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvDocumentTable
            // 
            this.dgvDocumentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocumentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDocumentTable.Location = new System.Drawing.Point(6, 23);
            this.dgvDocumentTable.Name = "dgvDocumentTable";
            this.dgvDocumentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentTable.Size = new System.Drawing.Size(477, 519);
            this.dgvDocumentTable.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvDocumentTable, "Дважды кликните на ячейку, чтобы отредактировать ее.");
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Производитель";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество";
            this.Column3.Name = "Column3";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(767, 619);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(124, 22);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "О ПРОГРАММЕ";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Visible = false;
            this.btnAbout.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(904, 24);
            this.menuMain.TabIndex = 5;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.ToolTipText = "Добавляет выбранное наименование в накладную";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.Image")));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.removeToolStripMenuItem.Text = "Удалить";
            this.removeToolStripMenuItem.ToolTipText = "Удаляет выбранное наименование из накладной";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.clearToolStripMenuItem.Text = "Очистить";
            this.clearToolStripMenuItem.ToolTipText = "Полностью очищает накладную";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.exitToolStripMenuItem.Text = "Выход из программы";
            this.exitToolStripMenuItem.ToolTipText = "Закрывает программу Order Automizer | Автоматизация заказов";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editorToolStripMenuItem.Image")));
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.editorToolStripMenuItem.Text = "Редактор";
            this.editorToolStripMenuItem.ToolTipText = "Открывает редактор наименований";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reloadToolStripMenuItem.Text = "Перезагрузка";
            this.reloadToolStripMenuItem.ToolTipText = "Заново считывает записи из базы данных";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statsToolStripMenuItem.Image")));
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.statsToolStripMenuItem.Text = "Cтатистика";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exportToolStripMenuItem.Text = "Экспорт в Excel";
            this.exportToolStripMenuItem.ToolTipText = "Экспортирует сформированную накладную в MS Excel";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.siteToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.ToolTipText = "Сведения о программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.updateToolStripMenuItem.Text = "Проверить обновления";
            this.updateToolStripMenuItem.ToolTipText = "Проверяет наличие более новой версии программы";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // siteToolStripMenuItem1
            // 
            this.siteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("siteToolStripMenuItem1.Image")));
            this.siteToolStripMenuItem1.Name = "siteToolStripMenuItem1";
            this.siteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.siteToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.siteToolStripMenuItem1.Text = "Сайт разработчика";
            this.siteToolStripMenuItem1.ToolTipText = "Посетить сайт разработчика программы";
            this.siteToolStripMenuItem1.Click += new System.EventHandler(this.siteToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Совет";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 641);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.grpboxDocument);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.grpboxPositions);
            this.Controls.Add(this.grpboxManufacturers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(920, 680);
            this.Name = "frmMain";
            this.Text = "Order Automizer | Главный экран";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpboxManufacturers.ResumeLayout(false);
            this.grpboxPositions.ResumeLayout(false);
            this.grpboxCurrentPosition.ResumeLayout(false);
            this.grpboxCurrentPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentPositionCount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpboxDocument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentTable)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxManufacturers;
        private System.Windows.Forms.ComboBox cmbManufacturers;
        private System.Windows.Forms.GroupBox grpboxPositions;
        private System.Windows.Forms.GroupBox grpboxCurrentPosition;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCurrentPositionCount;
        private System.Windows.Forms.TextBox txtCurrentPosition;
        private System.Windows.Forms.ListBox lstCurrentPositions;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grpboxDocument;
        private System.Windows.Forms.Button btnExportToXls;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvDocumentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripStatusLabel tsslblManufacturer;
        private System.Windows.Forms.ToolStripStatusLabel tsslblPosition;
        private System.Windows.Forms.ToolStripStatusLabel tsslblCount;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

