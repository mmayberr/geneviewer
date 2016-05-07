using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public partial class Abstract : Form
    {
        private TextBox abstractBox;

        private void InitializeComponent()
        {
            this.abstractBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // abstractBox
            // 
            this.abstractBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abstractBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abstractBox.Location = new System.Drawing.Point(12, 12);
            this.abstractBox.MinimumSize = new System.Drawing.Size(558, 422);
            this.abstractBox.Multiline = true;
            this.abstractBox.Name = "abstractBox";
            this.abstractBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.abstractBox.Size = new System.Drawing.Size(558, 422);
            this.abstractBox.TabIndex = 0;
            // 
            // Abstract
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(582, 455);
            this.Controls.Add(this.abstractBox);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Abstract";
            this.Text = "Abstract";
            this.Load += new System.EventHandler(this.Abstract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        string id = "";
        string name = "";

        public Abstract(Sequence seq)
        {
            InitializeComponent();
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);
            name = seq.getAccession();
            id = seq.getAbstractID();
        }

        private void Abstract_Load(object sender, EventArgs e)
        {
            this.Text = name;
            if (id == null)
            {
                abstractBox.Text = "There were no abstracts found";
                return;
            }
            string datapage = EutilsURLBuilder.getFile("pubmed", id, "text", "abstract");
            System.Net.WebRequest request = WebRequest.Create(datapage);
            WebResponse response;
            try
            {
                response = request.GetResponse();
            }
            catch
            {
                abstractBox.Text = "There were errors accessing the abstract page.";
                return;
            }
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string abr = reader.ReadToEnd();
            abstractBox.Text = abr.Replace("\n", "\r\n");
            reader.Close();
            response.Close();
        }
    }
}
