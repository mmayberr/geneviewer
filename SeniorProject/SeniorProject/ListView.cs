using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SeniorProject
{
    class ListView : View
    {
        public ListView(List<Control> objs)
            : base(objs)
        {
            foreach(Control obj in objs)
            {
                if( obj.GetType() == typeof(DataGridView))
                {
                    data = (DataGridView)obj;
                    return;
                }
            }
        }

        public void SetFound(XmlTextReader xreader)
        {
            string thisName = "";
            string thisID = "";
            string thisTitle = "";

            Dictionary<string, string> dic = new Dictionary<string, string>();
            while (xreader.Read())
            {
                switch (xreader.NodeType)
                {
                    case XmlNodeType.Element:
                        thisName = xreader.Name;
                        if (thisName != "Item" || !xreader.HasAttributes) break;
                        while (xreader.MoveToNextAttribute())
                        {
                            if (xreader.Name != "Name" || xreader.Value != "Title") continue;
                            thisName = xreader.Value;
                            break;
                        }
                        xreader.MoveToElement();

                        break;

                    case XmlNodeType.Text:
                        switch (thisName)
                        {
                            case "Id":
                                thisID = xreader.Value;
                                break;

                            case "Title":
                                thisTitle = xreader.Value;
                                break;

                            default:
                                break;
                        }
                        break;

                    case XmlNodeType.EndElement:
                        if (xreader.Name == "DocSum")
                        {
                            dic[thisID] = thisTitle;
                        }
                        break;

                    default:
                        break;
                }
            }

            int maxCol = data.ColumnCount - 1;
            int nextCol = 0;
            int nextRow = 0;
            data.Rows.Clear();
            data.Refresh();
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                if(nextCol == 0) data.Rows.Add();
                data.Rows[nextRow].Cells[nextCol].Value = kvp.Value;
                data.Rows[nextRow].Cells[nextCol].Tag = kvp.Key;

                if (nextCol == maxCol)
                {
                    nextCol = 0;
                    nextRow++;
                }
                else nextCol++;
            }
            data.Refresh();
        }

        DataGridView data;
    }
}
