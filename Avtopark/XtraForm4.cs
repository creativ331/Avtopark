using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing.Imaging;

namespace Avtopark
{
    public partial class XtraForm4 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm4()
        {
            InitializeComponent();
        }

        private void XtraForm4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoparkDataSet.avtobus". При необходимости она может быть перемещена или удалена.
            this.avtobusTableAdapter.Fill(this.avtoparkDataSet.avtobus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoparkDataSet.vud_transporta". При необходимости она может быть перемещена или удалена.
            this.vud_transportaTableAdapter.Fill(this.avtoparkDataSet.vud_transporta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[255];
            using (MemoryStream stream = new MemoryStream(buffer))
                {
                    //Image.FromFile().Save(stream, ImageFormat.Jpeg);

                    //colfoto.ColumnEdit = textEdit4.BackgroundImage.;
                }
            this.vud_transportaTableAdapter.Fill(this.avtoparkDataSet.vud_transporta);
        }
    }
}