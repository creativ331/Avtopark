using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Avtopark
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            XtraForm2 XtraForm = new XtraForm2();
            XtraForm.Show();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            XtraForm4 XtraForm = new XtraForm4();
            XtraForm.Show();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            XtraForm3 XtraForm = new XtraForm3();
            XtraForm.Show();
        }
    }
}