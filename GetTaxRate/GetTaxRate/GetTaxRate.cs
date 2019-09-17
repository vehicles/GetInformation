using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GetTaxRate
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
      
    }

    private void btnGetTaxRate_Click(object sender, EventArgs e)
    {
      WebClient client = new WebClient();
      client.Encoding = System.Text.Encoding.UTF8;

      
      var Json1 = client.DownloadString("https://thongtindoanhnghiep.co/api/company/" + txtMSTDN.Text);

      XNode node = JsonConvert.DeserializeXNode(Json1, "Root");

      #region "Write File"
      var dir = @"D:\TuanT\Console\GetTaxrate\GetTaxRate\GetTaxRate\Log";  // folder location

      if (!Directory.Exists(dir))  // if it doesn't exist, create
        Directory.CreateDirectory(dir);

          XmlDocument xmlDoc = new XmlDocument();
      xmlDoc.LoadXml(node.ToString());

      XmlWriterSettings settings = new XmlWriterSettings();
      settings.Indent = true;
      // Save the document to a file and auto-indent the output.
      XmlWriter writer = XmlWriter.Create(Path.Combine(dir, txtMSTDN.Text + ".xml"), settings);
      xmlDoc.Save(writer);
      #endregion

      #region "XPath"
      XmlNodeList itemNodes = xmlDoc.SelectNodes("Root");
      foreach (XmlNode itemNode in itemNodes)
      {
        var s = "";
        s = "1. Mã số thuế: " + itemNode.SelectSingleNode("MaSoThue").InnerText + Environment.NewLine;
        s += "2. Tên người nộp thuế: " + itemNode.SelectSingleNode("Title").InnerText + Environment.NewLine;
        s += "3. Địa chỉ công ty: " + itemNode.SelectSingleNode("DiaChiCongTy").InnerText + Environment.NewLine;
        s += "4. Chủ sở hữu: " + itemNode.SelectSingleNode("ChuSoHuu").InnerText + Environment.NewLine;
        s += "4.1 Địa chỉ: " + itemNode.SelectSingleNode("ChuSoHuu_DiaChi").InnerText + Environment.NewLine;
        s += "5. Nơi đăng ký kinh doanh: " + itemNode.SelectSingleNode("NoiDangKyQuanLy_CoQuanTitle").InnerText + Environment.NewLine;
        s += "6. Giấy phép kinh doanh: " + itemNode.SelectSingleNode("GiayPhepKinhDoanh_CoQuanCapTitle").InnerText + Environment.NewLine;
        
        s += "7. Cấp - Chương - Loại - Khoản: " + itemNode.SelectSingleNode("CapChuongLoaiKhoan").InnerText + Environment.NewLine;

        txtThongTinDN.Text = s;
      }
      //Load các tag li trong tag ul
      //var threadItems = node.DocumentNode.SelectNodes("//ul[@id='threads']/li").ToList();


      //var items = new List<object>();
      //foreach (var item in threadItems)
      //{
      //  //Extract các giá trị từ các tag con của tag li
      //  var linkNode = item.SelectSingleNode(".//a[contains(@class,'title')]");
      //  var link = linkNode.Attributes["href"].Value;
      //  var text = linkNode.InnerText;
      //  var readCount = item.SelectSingleNode(".//div[@class='folTypPost']/ul/li/b").InnerText;


      //  items.Add(new { text, readCount, link });

      //}
      #endregion

    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      txtMSTDN.Text = "0312692740";
    }
  }
}
