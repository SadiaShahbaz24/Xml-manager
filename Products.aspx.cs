using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace XML_example
{
    public partial class Products : System.Web.UI.Page
    {
        XDocument xmldoc;
      

       
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = MapPath("~/Products.xml");
            xmldoc = XDocument.Load(file);
            LoadGrid();
        }

        protected void BTNInsert_Click(object sender, EventArgs e)
        {
      ;


            XElement emp = new XElement("Product",
       new XElement("ID", txtid.Text),
       new XElement("Name", txtpname.Text),
       new XElement("Quantity", txtquan.Text),
       new XElement("Price", txtprice.Text),
       new XElement("Expiry", txtexp.Text),
       new XElement("supID", txtsppID.Text));
            xmldoc.Root.Add(emp);
            xmldoc.Save(MapPath("~/Products.xml"));
            LoadGrid();
            Reset(); // For clear textbox  

        }

        protected void BTNupdate_Click(object sender, EventArgs e)
        {
          
            XElement emp = xmldoc.Root.Elements("Product").Where(i => (string)i.Element("ID") == txtid.Text).FirstOrDefault();
            if (emp != null)
            {
                emp.Element("Name").Value = txtpname.Text;
                emp.Element("Quantity").Value = txtquan.Text;
                emp.Element("Price").Value = txtprice.Text;
                emp.Element("Expiry").Value = txtexp.Text;
                emp.Element("supID").Value = txtsppID.Text;
                //xmldoc.Root.Add(emp);
                xmldoc.Save(MapPath("~/Products.xml"));
                LoadGrid();
                Reset();
            }
        }
        protected void BTNdelete_Click(object sender, EventArgs e)
        {
                XElement pro = xmldoc.Descendants("Product").FirstOrDefault(p => p.Element("ID").Value == txtid.Text);
                if (pro != null)
                {
                    pro.Remove();
                    xmldoc.Save(MapPath("~/Products.xml"));
                    LoadGrid();
                    Reset();
                }
            }

        protected void BTNsearch_Click(object sender, EventArgs e)
        {
        
            XElement pro = xmldoc.Root.Elements("Product").Where(i => (string)i.Element("ID") == txtid.Text).FirstOrDefault();


            if (pro != null)
            {
                txtpname.Text = pro.Element("Name").Value;
                txtquan.Text = pro.Element("Quantity").Value;
                txtprice.Text = pro.Element("Price").Value;
                txtexp.Text = pro.Element("Expiry").Value;
                txtsppID.Text = pro.Element("supID").Value;

            }
        }

        public void LoadGrid()
        {
            DataSet ds = new DataSet();

            ds.ReadXml(Server.MapPath("Products.xml"));
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        private void Reset()
        {
            txtid.Text = "";
            txtpname.Text = "";
            txtquan.Text = "";
            txtprice.Text = "";
            txtexp.Text = "";
            txtsppID.Text = "";
            txtid.Focus();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}