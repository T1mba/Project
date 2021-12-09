using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vosmerochka_ry
{
    public partial class WpfElementi : Form
    {
        UserControl1 wpfControl = new UserControl1();
        UserControl2 wpfControl1 = new UserControl2();

        public WpfElementi()
        {
            InitializeComponent();
            elementHost1.Child = wpfControl1;
            elementHost2.Child = wpfControl;
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void WpfElementi_Load(object sender, EventArgs e)
        {

        }

    }
}
