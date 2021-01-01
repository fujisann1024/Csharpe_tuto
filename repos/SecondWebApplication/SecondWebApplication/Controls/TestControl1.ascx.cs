using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondWebApplication
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                
        }

        public int Hour
        {
            get
            {
                return int.Parse(HourTextBox.Text);
            }
        }
        public int Minute
        {
            get
            {
                return int.Parse(MinuteTextBox.Text);
            }
        }


    }
}