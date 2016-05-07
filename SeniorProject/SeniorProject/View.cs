using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public class View
    {
        public View(List<Control> objs)
        {
            ctrlList = objs;
        }
        public void Off()
        {
            foreach (Control obj in ctrlList)
            {
                obj.Hide();
            }
        }
        public void On()
        {
            foreach (Control obj in ctrlList)
            {
                obj.Show();
            }
        }

        public List<Control> ctrlList;
    }
}
