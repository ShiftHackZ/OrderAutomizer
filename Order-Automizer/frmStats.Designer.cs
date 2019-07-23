namespace Order_Automizer
{
    partial class frmStats
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStats));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblManufGeneral = new System.Windows.Forms.Label();
            this.lblManufGeneralPositions = new System.Windows.Forms.Label();
            this.lblGeneralPositionsPerManufacturer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblPositions = new System.Windows.Forms.Label();
            this.lblCountPerOrder = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPositionsPerOrders = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общее количество производителей: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Общее количество наименований:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Среднее кол-во позиций на производителя:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblManufGeneral);
            this.groupBox1.Controls.Add(this.lblManufGeneralPositions);
            this.groupBox1.Controls.Add(this.lblGeneralPositionsPerManufacturer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База данных";
            // 
            // lblManufGeneral
            // 
            this.lblManufGeneral.AutoSize = true;
            this.lblManufGeneral.Location = new System.Drawing.Point(337, 22);
            this.lblManufGeneral.Name = "lblManufGeneral";
            this.lblManufGeneral.Size = new System.Drawing.Size(16, 18);
            this.lblManufGeneral.TabIndex = 1;
            this.lblManufGeneral.Text = "0";
            // 
            // lblManufGeneralPositions
            // 
            this.lblManufGeneralPositions.AutoSize = true;
            this.lblManufGeneralPositions.Location = new System.Drawing.Point(337, 45);
            this.lblManufGeneralPositions.Name = "lblManufGeneralPositions";
            this.lblManufGeneralPositions.Size = new System.Drawing.Size(16, 18);
            this.lblManufGeneralPositions.TabIndex = 1;
            this.lblManufGeneralPositions.Text = "0";
            // 
            // lblGeneralPositionsPerManufacturer
            // 
            this.lblGeneralPositionsPerManufacturer.AutoSize = true;
            this.lblGeneralPositionsPerManufacturer.Location = new System.Drawing.Point(337, 68);
            this.lblGeneralPositionsPerManufacturer.Name = "lblGeneralPositionsPerManufacturer";
            this.lblGeneralPositionsPerManufacturer.Size = new System.Drawing.Size(16, 18);
            this.lblGeneralPositionsPerManufacturer.TabIndex = 1;
            this.lblGeneralPositionsPerManufacturer.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOrder);
            this.groupBox2.Controls.Add(this.lblPositions);
            this.groupBox2.Controls.Add(this.lblCountPerOrder);
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.lblPositionsPerOrders);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 141);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказы";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(337, 22);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(16, 18);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "0";
            // 
            // lblPositions
            // 
            this.lblPositions.AutoSize = true;
            this.lblPositions.Location = new System.Drawing.Point(337, 45);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(16, 18);
            this.lblPositions.TabIndex = 1;
            this.lblPositions.Text = "0";
            // 
            // lblCountPerOrder
            // 
            this.lblCountPerOrder.AutoSize = true;
            this.lblCountPerOrder.Location = new System.Drawing.Point(337, 114);
            this.lblCountPerOrder.Name = "lblCountPerOrder";
            this.lblCountPerOrder.Size = new System.Drawing.Size(16, 18);
            this.lblCountPerOrder.TabIndex = 1;
            this.lblCountPerOrder.Text = "0";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(337, 91);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 18);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            // 
            // lblPositionsPerOrders
            // 
            this.lblPositionsPerOrders.AutoSize = true;
            this.lblPositionsPerOrders.Location = new System.Drawing.Point(337, 68);
            this.lblPositionsPerOrders.Name = "lblPositionsPerOrders";
            this.lblPositionsPerOrders.Size = new System.Drawing.Size(16, 18);
            this.lblPositionsPerOrders.TabIndex = 1;
            this.lblPositionsPerOrders.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Всего сформировано заказов: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Общее число позиций:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Среднее кол-во товара за заказ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Общее количество товара:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(292, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Среднее кол-во наименований за заказ:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Точное значение";
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStats";
            this.Text = "Order Automizer | Статистика";
            this.Load += new System.EventHandler(this.frmStats_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblManufGeneral;
        private System.Windows.Forms.Label lblManufGeneralPositions;
        private System.Windows.Forms.Label lblGeneralPositionsPerManufacturer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblPositions;
        private System.Windows.Forms.Label lblPositionsPerOrders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCountPerOrder;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}