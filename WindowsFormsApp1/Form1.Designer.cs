
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstuaddress = new System.Windows.Forms.Label();
            this.lblstudstd = new System.Windows.Forms.Label();
            this.txtstuid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtmarks = new System.Windows.Forms.TextBox();
            this.lblstupercentage = new System.Windows.Forms.Label();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(138, 67);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(64, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "SudentId";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(138, 130);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(94, 17);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "StudentName";
            // 
            // lblstuaddress
            // 
            this.lblstuaddress.AutoSize = true;
            this.lblstuaddress.Location = new System.Drawing.Point(138, 181);
            this.lblstuaddress.Name = "lblstuaddress";
            this.lblstuaddress.Size = new System.Drawing.Size(109, 17);
            this.lblstuaddress.TabIndex = 3;
            this.lblstuaddress.Text = "StudentAddress";
            // 
            // lblstudstd
            // 
            this.lblstudstd.AutoSize = true;
            this.lblstudstd.Location = new System.Drawing.Point(138, 238);
            this.lblstudstd.Name = "lblstudstd";
            this.lblstudstd.Size = new System.Drawing.Size(46, 17);
            this.lblstudstd.TabIndex = 4;
            this.lblstudstd.Text = "Marks";
            // 
            // txtstuid
            // 
            this.txtstuid.Location = new System.Drawing.Point(315, 64);
            this.txtstuid.Name = "txtstuid";
            this.txtstuid.Size = new System.Drawing.Size(183, 22);
            this.txtstuid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(315, 125);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(183, 22);
            this.txtname.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(315, 176);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(183, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // txtmarks
            // 
            this.txtmarks.Location = new System.Drawing.Point(315, 233);
            this.txtmarks.Name = "txtmarks";
            this.txtmarks.Size = new System.Drawing.Size(183, 22);
            this.txtmarks.TabIndex = 8;
            // 
            // lblstupercentage
            // 
            this.lblstupercentage.AutoSize = true;
            this.lblstupercentage.Location = new System.Drawing.Point(138, 290);
            this.lblstupercentage.Name = "lblstupercentage";
            this.lblstupercentage.Size = new System.Drawing.Size(130, 17);
            this.lblstupercentage.TabIndex = 9;
            this.lblstupercentage.Text = "StudentPercentage";
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(315, 290);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(183, 22);
            this.txtpercentage.TabIndex = 11;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(52, 364);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(147, 54);
            this.btnwrite.TabIndex = 12;
            this.btnwrite.Text = "BinaryWrite";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(216, 366);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(164, 52);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "BinaryRead";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(404, 364);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(141, 52);
            this.btnxmlwrite.TabIndex = 14;
            this.btnxmlwrite.Text = "XMWrite";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(571, 366);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(141, 52);
            this.btnxmlread.TabIndex = 15;
            this.btnxmlread.Text = "XMLRead";
            this.btnxmlread.UseVisualStyleBackColor = true;
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(634, 64);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(141, 52);
            this.btnsoapwrite.TabIndex = 16;
            this.btnsoapwrite.Text = "SOAPWrite";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(866, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 52);
            this.button2.TabIndex = 17;
            this.button2.Text = "SOAPRead";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(634, 176);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(141, 52);
            this.btnjsonwrite.TabIndex = 18;
            this.btnjsonwrite.Text = "JSONWrite";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            // 
            // btnjsonRead
            // 
            this.btnjsonRead.Location = new System.Drawing.Point(866, 161);
            this.btnjsonRead.Name = "btnjsonRead";
            this.btnjsonRead.Size = new System.Drawing.Size(141, 52);
            this.btnjsonRead.TabIndex = 19;
            this.btnjsonRead.Text = "JSONRead";
            this.btnjsonRead.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 567);
            this.Controls.Add(this.btnjsonRead);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.lblstupercentage);
            this.Controls.Add(this.txtmarks);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtstuid);
            this.Controls.Add(this.lblstudstd);
            this.Controls.Add(this.lblstuaddress);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstuaddress;
        private System.Windows.Forms.Label lblstudstd;
        private System.Windows.Forms.TextBox txtstuid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtmarks;
        private System.Windows.Forms.Label lblstupercentage;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonRead;
    }
}

