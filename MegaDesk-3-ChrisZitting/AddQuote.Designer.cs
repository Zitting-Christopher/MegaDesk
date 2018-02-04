namespace MegaDesk_3_ChrisZitting
{
    partial class AddQuote
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

        //Define a few things according to the assignment
        double basePrice = 200;
        double surfArea;
        double surfAreaCost;
        int numOfDrawers;
        int costPerDrawer = 50;
        double drawersCost;
        int surfMatCost;
        


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aq_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_aq_basePrice = new System.Windows.Forms.TextBox();
            this.tb_aq_costSurfaceArea = new System.Windows.Forms.TextBox();
            this.tb_aq_costDrawers = new System.Windows.Forms.TextBox();
            this.tb_aq_surfMatCost = new System.Windows.Forms.TextBox();
            this.tb_aq_rushFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dd_aq_surfMat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dd_aq_numDrawers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_aq_width = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_aq_back
            // 
            this.btn_aq_back.Location = new System.Drawing.Point(13, 13);
            this.btn_aq_back.Name = "btn_aq_back";
            this.btn_aq_back.Size = new System.Drawing.Size(181, 36);
            this.btn_aq_back.TabIndex = 1;
            this.btn_aq_back.Text = "Back to Main Menu";
            this.btn_aq_back.UseVisualStyleBackColor = true;
            this.btn_aq_back.Click += new System.EventHandler(this.btn_aq_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost of Surface Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost of Drawers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Surface Material Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rush Fee";
            // 
            // tb_aq_basePrice
            // 
            this.tb_aq_basePrice.Enabled = false;
            this.tb_aq_basePrice.Location = new System.Drawing.Point(193, 61);
            this.tb_aq_basePrice.Name = "tb_aq_basePrice";
            this.tb_aq_basePrice.Size = new System.Drawing.Size(100, 20);
            this.tb_aq_basePrice.TabIndex = 7;
            // 
            // tb_aq_costSurfaceArea
            // 
            this.tb_aq_costSurfaceArea.Enabled = false;
            this.tb_aq_costSurfaceArea.Location = new System.Drawing.Point(193, 92);
            this.tb_aq_costSurfaceArea.Name = "tb_aq_costSurfaceArea";
            this.tb_aq_costSurfaceArea.Size = new System.Drawing.Size(100, 20);
            this.tb_aq_costSurfaceArea.TabIndex = 8;
            // 
            // tb_aq_costDrawers
            // 
            this.tb_aq_costDrawers.Enabled = false;
            this.tb_aq_costDrawers.Location = new System.Drawing.Point(193, 123);
            this.tb_aq_costDrawers.Name = "tb_aq_costDrawers";
            this.tb_aq_costDrawers.Size = new System.Drawing.Size(100, 20);
            this.tb_aq_costDrawers.TabIndex = 9;
            // 
            // tb_aq_surfMatCost
            // 
            this.tb_aq_surfMatCost.Enabled = false;
            this.tb_aq_surfMatCost.Location = new System.Drawing.Point(193, 154);
            this.tb_aq_surfMatCost.Name = "tb_aq_surfMatCost";
            this.tb_aq_surfMatCost.Size = new System.Drawing.Size(100, 20);
            this.tb_aq_surfMatCost.TabIndex = 10;
            // 
            // tb_aq_rushFee
            // 
            this.tb_aq_rushFee.Enabled = false;
            this.tb_aq_rushFee.Location = new System.Drawing.Point(193, 185);
            this.tb_aq_rushFee.Name = "tb_aq_rushFee";
            this.tb_aq_rushFee.Size = new System.Drawing.Size(100, 20);
            this.tb_aq_rushFee.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Surface Material";
            // 
            // dd_aq_surfMat
            // 
            this.dd_aq_surfMat.FormattingEnabled = true;
            this.dd_aq_surfMat.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.dd_aq_surfMat.Location = new System.Drawing.Point(193, 216);
            this.dd_aq_surfMat.Name = "dd_aq_surfMat";
            this.dd_aq_surfMat.Size = new System.Drawing.Size(121, 21);
            this.dd_aq_surfMat.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number of Drawers";
            // 
            // dd_aq_numDrawers
            // 
            this.dd_aq_numDrawers.FormattingEnabled = true;
            this.dd_aq_numDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.dd_aq_numDrawers.Location = new System.Drawing.Point(193, 247);
            this.dd_aq_numDrawers.Name = "dd_aq_numDrawers";
            this.dd_aq_numDrawers.Size = new System.Drawing.Size(121, 21);
            this.dd_aq_numDrawers.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Desired Width";
            // 
            // tb_aq_width
            // 
            this.tb_aq_width.Location = new System.Drawing.Point(193, 278);
            this.tb_aq_width.Name = "tb_aq_width";
            this.tb_aq_width.Size = new System.Drawing.Size(100, 20);
            this.tb_aq_width.TabIndex = 17;
            this.tb_aq_width.Validating += new System.ComponentModel.CancelEventHandler(this.tb_aq_width_Validating);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 351);
            this.Controls.Add(this.tb_aq_width);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dd_aq_numDrawers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dd_aq_surfMat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_aq_rushFee);
            this.Controls.Add(this.tb_aq_surfMatCost);
            this.Controls.Add(this.tb_aq_costDrawers);
            this.Controls.Add(this.tb_aq_costSurfaceArea);
            this.Controls.Add(this.tb_aq_basePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aq_back);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
            //if(AddQuote.dd_aq_surfMat.ToString() == "Oak")
            //{
            //surfMatCost = 200;
            //}
            //if (this.dd_aq_surfMat.ToString() == "Laminate")
            //{
            //surfMatCost = 100;
            //}
            //if (this.dd_aq_surfMat.ToString() == "Pine")
            //{
            //surfMatCost = 50;
            //}
            //if (this.dd_aq_surfMat.ToString() == "Rosewood")
            //{
            //surfMatCost = 300;
            //}
            //if (this.dd_aq_surfMat.ToString() == "Veneer")
            //{
            //surfMatCost = 125;
            //}

        private System.Windows.Forms.Button btn_aq_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_aq_basePrice;
        private System.Windows.Forms.TextBox tb_aq_costSurfaceArea;
        private System.Windows.Forms.TextBox tb_aq_costDrawers;
        private System.Windows.Forms.TextBox tb_aq_surfMatCost;
        private System.Windows.Forms.TextBox tb_aq_rushFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dd_aq_surfMat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dd_aq_numDrawers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_aq_width;
    }
}