using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using SeniorProject.Properties;

namespace SeniorProject
{
    public partial class main_form : Form
    {
        const int menuHeight = 200;
        const int menuWidth = 305;
        List<TextBox> funcBox = new List<TextBox>();
        SeqView viewer;
        ListView view_list;
        Key key;
        Help help;
        Abstract abr;

        BindingList<string> listitems = new BindingList<string>();
        bool isSeqView = false;
        int graphstart = 1;
        int graphheight = 10;
        bool stopBoxDraw = false;
        Sequence curSEQ = new Sequence();
        Sequence prevSEQ = new Sequence();


        public main_form()
        {
            InitializeComponent();
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newnum;
            try { newnum = Int32.Parse(navInput.Text); } catch { return; }
            if (newnum <= 0 || newnum > curSEQ.getSEQ().Length) { return; }
            graphstart = Int32.Parse(navInput.Text);
            if (graphheight == 0)
            {
                graphheight = 5;
            }
            if (graphstart + graphheight > curSEQ.getSEQ().Length) {
                graphheight = curSEQ.getSEQ().Length - graphstart;
            }
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            key = new Key();
            help = new Help();
            abr = new Abstract(curSEQ);
            dropDown.SelectedIndex = 0;

            // keep track of controls used for sequence viewing
            List<Control> seqView = new List<Control>();
            seqView.Add(titleBox);
            seqView.Add(subTitleTop);
            seqView.Add(subTitleBot);
            seqView.Add(end3prime);
            seqView.Add(end5prime);
            seqView.Add(keyButton);
            seqView.Add(featureListBox);
            seqView.Add(pan_down);
            seqView.Add(pan_up);
            seqView.Add(zoom_in);
            seqView.Add(zoom_out);
            seqView.Add(navLabel);
            seqView.Add(navInput);
            seqView.Add(navButton);
            seqView.Add(posStart);
            seqView.Add(posEnd);
            seqView.Add(prv_src);
            seqView.Add(prv_rna);
            seqView.Add(abstractButton);

            viewer = new SeqView(seqView);
            viewer.Off();

            // keep track of controls used for search list viewing
            List<Control> listView = new List<Control>();
            listView.Add(searchResultsTable);
            view_list = new ListView(listView);
            view_list.Off();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            
            if (isSeqView && curSEQ.getSEQ() != null )
            {
                //clear
                e.Graphics.Clear(this.BackColor);

                // determine window size
                Size size = this.ClientSize;
                size.Height -= (menuHeight+30);
                size.Width -= menuWidth;

                // line of bases
                int unitsize = size.Height / graphheight;
                if (unitsize < 5)
                {
                    graphheight = size.Height / 5;
                    unitsize = 5;
                }

                // position units
                posStart.Text = graphstart.ToString();
                posEnd.Text = (graphstart + graphheight).ToString();
                
                if (unitsize < 15)
                {
                    for (int i = 0; i < graphheight && i + graphstart <= curSEQ.getSEQ().Length; i++)
                    {
                        char ntbase = curSEQ.getSEQ()[graphstart + i - 1];
                        SolidBrush pencolor = new SolidBrush(SeqView.getColor(ntbase));
                        Rectangle rectangle = new Rectangle(
                            size.Width *2 / 5 - unitsize / 2, menuHeight + i * unitsize, unitsize, unitsize);
                        e.Graphics.FillEllipse(pencolor, rectangle);
                    }
                }
                else if (unitsize < 75)
                {
                    Font drawFont = new Font("Arial", unitsize, GraphicsUnit.Pixel);
                    for (int i = 0; i < graphheight && i + graphstart <= curSEQ.getSEQ().Length; i++)
                    {
                        char ntbase = curSEQ.getSEQ()[graphstart + i - 1];
                        SolidBrush drawBrush = new SolidBrush(SeqView.getColor(ntbase));
                        float x = size.Width *2 / 5 - unitsize / 2;
                        float y = menuHeight + i * (unitsize);

                        StringFormat drawFormat = new StringFormat();
                        e.Graphics.DrawString(ntbase.ToString(), drawFont, drawBrush, x, y, drawFormat);
                        
                        //drawBrush.Dispose();
                        
                    }
                    //graphics.Dispose();
                    //drawFont.Dispose();
                }
                else
                {
                    for (int i = 0; i < graphheight && i + graphstart <= curSEQ.getSEQ().Length; i++)
                    {
                        char ntbase = curSEQ.getSEQ()[graphstart + i - 1];
                        Image newImage = SeqView.ResizeImage(SeqView.getImg(ntbase), unitsize, unitsize * 3/5);
                        Point ulCorner = new Point(size.Width * 2 / 5 - unitsize / 2, menuHeight + i * (unitsize));
                        e.Graphics.DrawImage(newImage, ulCorner);
                    }
                }

                List<Sequence.feature> featurelist = curSEQ.getVisibleFeatures(graphstart, graphstart + graphheight - 1);
                featurelist = featurelist.OrderBy(feat => feat.start).ToList();

                int done = 0;
                foreach (TextBox box in funcBox.ToList())
                {
                    if(!stopBoxDraw) box.Hide();
                }
                if (!stopBoxDraw) foreach (Sequence.feature feat in featurelist)
                {
                    int boxheight = size.Height / featurelist.Count();
                    int boxwidth = size.Width / 4;
                    TextBox txt;
                    if (funcBox.Count() >= done)
                    {
                        txt = new TextBox();
                        txt.Multiline = true;
                        txt.WordWrap = true;
                        txt.AutoSize = false;
                        txt.ScrollBars = ScrollBars.Vertical;
                        txt.MouseEnter += new System.EventHandler(this.flicker_Off);
                        txt.MouseLeave += new System.EventHandler(this.flicker_On);
                    }
                    else { txt = funcBox[done]; }
                    txt.Text = feat.name + "\r\n";
                    txt.Text += "-> Position: " + feat.start + "-" + feat.end + "\r\n";
                    txt.Text += feat.notes;
                    txt.Size = new Size(boxwidth, (int)(boxheight*0.8));
                    int featbox_x = size.Width - boxwidth;
                    int featbox_y = menuHeight + 15 + done * boxheight;
                    txt.Location = new Point(featbox_x, featbox_y);
                    if (funcBox.Count() >= done)
                    {
                        funcBox.Add(txt);
                        Controls.Add(txt);
                    }
                    else { txt.Show(); }
                    
                    Pen myPen = new Pen(SeqView.randColor(done));
                    int startWidth = size.Width * 3 / 5;
                    int linetop = (feat.start < graphstart) ? 0 : feat.start - graphstart;
                    int linebot = (feat.end >= graphstart + graphheight) ? graphheight : feat.end - graphstart + 1;
                    int x = startWidth + done * 8;
                    int y1 = menuHeight + linetop * unitsize;
                    int y2 = menuHeight + linebot * unitsize;
                    e.Graphics.DrawLine(myPen, x, y1, x, y2);
                    e.Graphics.DrawLine(myPen, x, (y1+ y2)/2, featbox_x, featbox_y+ txt.Size.Height/2);
                    myPen.Dispose();

                    done++;
                }
            }

        }

        private void flicker_Off(object sender, EventArgs e)
        {
            stopBoxDraw = true;
        }
        private void flicker_On(object sender, EventArgs e)
        {
            stopBoxDraw = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void featurelistbox_DoubleClick(object sender, EventArgs e)
        {
            string lookfor = featureListBox.SelectedItem.ToString();
            int thisstart = 0;
            int thislength = 0;

            foreach (Sequence.feature feat in curSEQ.featurelist)
            {
                if (feat.name == lookfor)
                {
                    thisstart = feat.start;
                    thislength = feat.end - feat.start;
                    if (thislength < 3) thislength = 3;
                    break;
                }
            }

            graphheight = thislength;
            graphstart = thisstart;
            Refresh();
        }

        private void get_page_Click(object sender, EventArgs e)
        {
            viewer.Off();
            isSeqView = false;
            Control[] boxArray = { Accession, Organism, Feature_key, dropDown, All_fields };
            WebRequest id_request = WebRequest.Create(EutilsURLBuilder.makeQueryURL(boxArray, "nucleotide", 30));
            WebResponse id_response = null;
            try {
                id_response = id_request.GetResponse();
            }
            catch {
                Console.WriteLine("There was an error accessing the web utilities.");
                return;
            }
            Stream id_dataStream = id_response.GetResponseStream();
            StreamReader id_reader = new StreamReader(id_dataStream);
            string id_responseFromServer = id_reader.ReadToEnd();
            id_reader.Close();
            id_response.Close();

            Match id_matches = Regex.Match(id_responseFromServer, "<Id>(\\d+)</Id>");

            XmlTextReader id_read = new XmlTextReader(new StringReader(id_responseFromServer));

            string thisName = "";
            List<string> ids = new List<string>();
            while (id_read.Read())
            {
                if (id_read.NodeType == XmlNodeType.Element)
                {
                    thisName = id_read.Name;
                }
                else if (id_read.NodeType == XmlNodeType.Text && thisName == "Id")
                {
                    ids.Add(id_read.Value);
                }
                else if (id_read.NodeType == XmlNodeType.Text && thisName == "ERROR")
                {
                    Console.WriteLine("There was an error accessing the web utilities.");
                }
            }


            WebRequest sum_request = WebRequest.Create(EutilsURLBuilder.getSummary("nucleotide", ids));
            WebResponse sum_response = null;
            try
            {
                sum_response = sum_request.GetResponse();
            }
            catch
            {
                Console.WriteLine("There was an error accessing the web utilities.");
                return;
            }
            Stream sum_dataStream = sum_response.GetResponseStream();
            StreamReader sum_reader = new StreamReader(sum_dataStream);
            string sum_responseFromServer = sum_reader.ReadToEnd();
            sum_reader.Close();
            sum_response.Close();

            view_list.SetFound(new XmlTextReader(new StringReader(sum_responseFromServer)));
            view_list.On();
        }

        private void SetTitles()
        {
            titleBox.Text = curSEQ.getAccession();
            subTitleTop.Text = curSEQ.getStrandedness() + " stranded " + curSEQ.getTopology() + " " + curSEQ.getMolType() + " in " + curSEQ.getOrganism();
            subTitleBot.Text = curSEQ.getDefinition();
        }

        private void Get_Page(string id)
        {
            // get page from ID
            string datapage = EutilsURLBuilder.getFile("nucleotide", id, "gb", "xml");
            Console.WriteLine(datapage);
            WebRequest request = WebRequest.Create(datapage);
            WebResponse response;
            try
            {
                response = request.GetResponse();
            }
            catch
            {
                Console.WriteLine("There was an error accessing the web utilities.");
                return;
            }
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            Console.WriteLine(responseFromServer);
            reader.Close();
            response.Close();

            // get name & location & put in vector

            prevSEQ = curSEQ;
            curSEQ = new Sequence(new XmlTextReader(new StringReader(responseFromServer)));

            listitems.Clear();
            foreach (Sequence.feature feat in curSEQ.featurelist)
            {
                listitems.Add(feat.name);
            }
            featureListBox.DataSource = listitems;

            SetTitles();
            graphstart = 1;
            viewer.On();
            isSeqView = true;

            Refresh();
        }

        private void pan_up_Click(object sender, EventArgs e)
        {
            int downBy = (int)Math.Ceiling((double)graphheight / 6);
            if (graphstart - downBy > 0)
            {
                graphstart -= downBy;
            }
            else
            {
                graphstart = 1;
            }
            Refresh();
        }

        private void pan_down_Click(object sender, EventArgs e)
        {
            int upBy = (int)Math.Ceiling((double)graphheight / 6);
            if (graphstart + graphheight + upBy < curSEQ.getSEQ().Length)
            {
                graphstart += upBy;
            }
            else
            {
                graphstart = curSEQ.getSEQ().Length - graphheight;
            }
            Refresh();
        }

        private void zoom_in_Click(object sender, EventArgs e)
        {
            if ((graphheight * 2) / 3 > 3) { graphheight = (graphheight * 2) / 3; }
            else { graphheight = 3; }
            Refresh();
        }

        private void zoom_out_Click(object sender, EventArgs e)
        {
            if ((graphheight * 3) / 2 < curSEQ.getSEQ().Length) { graphheight = (graphheight * 3) / 2; }
            else { graphheight = curSEQ.getSEQ().Length; }
            Refresh();
        }

        private void featurelistbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                featurelistbox_DoubleClick(this, new EventArgs());
            }
        }

        private void key_button_Click(object sender, EventArgs e)
        {
            if (key.IsDisposed) key = new Key();
            key.Show();
        }

        private void search_help_Click(object sender, EventArgs e)
        {
            if (help.IsDisposed) help = new Help();
            help.Show();
        }

        private void searchResultsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Get_Page((string)searchResultsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag);
            view_list.Off();
        }

        private void prv_src_Click(object sender, EventArgs e)
        {
            viewer.Off();
            view_list.On();
            isSeqView = false;
        }

        private void prv_rna_Click(object sender, EventArgs e)
        {
            if (prevSEQ.getAccession() == "Default") return;
            graphstart = 1;
            Sequence tmpSEQ = curSEQ;
            curSEQ = prevSEQ;
            prevSEQ = tmpSEQ;
            SetTitles();
        }

        private void abstractButton_Click(object sender, EventArgs e)
        {
            abr = new Abstract(curSEQ);
            abr.Show();
        }
    }
}
