namespace ParibuListener
{
    partial class Form1
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
            this.lstCoins = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCoin = new System.Windows.Forms.ComboBox();
            this.btnAddAlert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.lstAlerts = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrListener = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstCoins
            // 
            this.lstCoins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lstCoins.FullRowSelect = true;
            this.lstCoins.HideSelection = false;
            this.lstCoins.Location = new System.Drawing.Point(12, 12);
            this.lstCoins.MultiSelect = false;
            this.lstCoins.Name = "lstCoins";
            this.lstCoins.Size = new System.Drawing.Size(264, 448);
            this.lstCoins.TabIndex = 0;
            this.lstCoins.UseCompatibleStateImageBehavior = false;
            this.lstCoins.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Max";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yüzdelik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alarmlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coin :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(450, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(82, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // txtCoin
            // 
            this.txtCoin.FormattingEnabled = true;
            this.txtCoin.Location = new System.Drawing.Point(339, 45);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Size = new System.Drawing.Size(104, 21);
            this.txtCoin.TabIndex = 4;
            // 
            // btnAddAlert
            // 
            this.btnAddAlert.Location = new System.Drawing.Point(642, 43);
            this.btnAddAlert.Name = "btnAddAlert";
            this.btnAddAlert.Size = new System.Drawing.Size(63, 23);
            this.btnAddAlert.TabIndex = 5;
            this.btnAddAlert.Text = "Ekle";
            this.btnAddAlert.UseVisualStyleBackColor = true;
            this.btnAddAlert.Click += new System.EventHandler(this.btnAddAlert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "₺";
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Üstünde",
            "Altında"});
            this.txtType.Location = new System.Drawing.Point(556, 45);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(80, 21);
            this.txtType.TabIndex = 7;
            // 
            // lstAlerts
            // 
            this.lstAlerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader10});
            this.lstAlerts.FullRowSelect = true;
            this.lstAlerts.HideSelection = false;
            this.lstAlerts.Location = new System.Drawing.Point(302, 72);
            this.lstAlerts.MultiSelect = false;
            this.lstAlerts.Name = "lstAlerts";
            this.lstAlerts.Size = new System.Drawing.Size(403, 388);
            this.lstAlerts.TabIndex = 8;
            this.lstAlerts.UseCompatibleStateImageBehavior = false;
            this.lstAlerts.View = System.Windows.Forms.View.Details;
            this.lstAlerts.DoubleClick += new System.EventHandler(this.lstAlerts_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Fiyat";
            this.columnHeader9.Width = 194;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tip";
            // 
            // tmrListener
            // 
            this.tmrListener.Enabled = true;
            this.tmrListener.Interval = 60000;
            this.tmrListener.Tick += new System.EventHandler(this.tmrListener_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 509);
            this.Controls.Add(this.lstAlerts);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAlert);
            this.Controls.Add(this.txtCoin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCoins);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paribu Listener";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCoins;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox txtCoin;
        private System.Windows.Forms.Button btnAddAlert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.ListView lstAlerts;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Timer tmrListener;
    }
}

