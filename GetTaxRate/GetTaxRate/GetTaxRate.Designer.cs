namespace GetTaxRate
{
  partial class frmMain
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
      this.btnGetTaxRate = new System.Windows.Forms.Button();
      this.lblMST = new System.Windows.Forms.Label();
      this.txtMSTDN = new System.Windows.Forms.TextBox();
      this.txtThongTinDN = new System.Windows.Forms.TextBox();
      this.lbThongTinDN = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnGetTaxRate
      // 
      this.btnGetTaxRate.Location = new System.Drawing.Point(713, 6);
      this.btnGetTaxRate.Name = "btnGetTaxRate";
      this.btnGetTaxRate.Size = new System.Drawing.Size(75, 23);
      this.btnGetTaxRate.TabIndex = 2;
      this.btnGetTaxRate.Text = "&Xử lý";
      this.btnGetTaxRate.UseVisualStyleBackColor = true;
      this.btnGetTaxRate.Click += new System.EventHandler(this.btnGetTaxRate_Click);
      // 
      // lblMST
      // 
      this.lblMST.AutoSize = true;
      this.lblMST.Location = new System.Drawing.Point(12, 9);
      this.lblMST.Name = "lblMST";
      this.lblMST.Size = new System.Drawing.Size(128, 13);
      this.lblMST.TabIndex = 1;
      this.lblMST.Text = "Mã số thuế doanh nghiệp";
      // 
      // txtMSTDN
      // 
      this.txtMSTDN.Location = new System.Drawing.Point(146, 6);
      this.txtMSTDN.Name = "txtMSTDN";
      this.txtMSTDN.Size = new System.Drawing.Size(161, 20);
      this.txtMSTDN.TabIndex = 1;
      // 
      // txtThongTinDN
      // 
      this.txtThongTinDN.Location = new System.Drawing.Point(15, 57);
      this.txtThongTinDN.Multiline = true;
      this.txtThongTinDN.Name = "txtThongTinDN";
      this.txtThongTinDN.ReadOnly = true;
      this.txtThongTinDN.Size = new System.Drawing.Size(773, 381);
      this.txtThongTinDN.TabIndex = 3;
      // 
      // lbThongTinDN
      // 
      this.lbThongTinDN.AutoSize = true;
      this.lbThongTinDN.Location = new System.Drawing.Point(12, 41);
      this.lbThongTinDN.Name = "lbThongTinDN";
      this.lbThongTinDN.Size = new System.Drawing.Size(153, 13);
      this.lbThongTinDN.TabIndex = 4;
      this.lbThongTinDN.Text = "THÔNG TIN DOANH NGHIỆP";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lbThongTinDN);
      this.Controls.Add(this.txtThongTinDN);
      this.Controls.Add(this.txtMSTDN);
      this.Controls.Add(this.lblMST);
      this.Controls.Add(this.btnGetTaxRate);
      this.Name = "frmMain";
      this.Text = "Lấy thông tin doanh nghiệp";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGetTaxRate;
    private System.Windows.Forms.Label lblMST;
    private System.Windows.Forms.TextBox txtMSTDN;
    private System.Windows.Forms.TextBox txtThongTinDN;
    private System.Windows.Forms.Label lbThongTinDN;
  }
}

