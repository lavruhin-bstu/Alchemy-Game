using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;


using System.Windows.Forms;

namespace alchemy
{
     class ButtonClass:Button
    {
        public void CreateElements(Button elm,string str,int x,int y,int w,int h,EventHandler evh)
        {
            elm = new Button();
            elm.Text= str;
            elm.Location= new Point();
            elm.Size = new Size();
            elm.Click += evh;
            
           
        }
    }
}
