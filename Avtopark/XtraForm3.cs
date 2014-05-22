using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace Avtopark
{
    public partial class XtraForm3 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm3()
        {
            InitializeComponent();
        }

        private void XtraForm3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoparkDataSet.slusari". При необходимости она может быть перемещена или удалена.
            this.slusariTableAdapter.Fill(this.avtoparkDataSet.slusari);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Переміщає grid на передній фон
            this.gridControl2.SendToBack();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Переміщає grid на передній фон
            this.gridControl1.SendToBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Зберегти
            this.slusariTableAdapter.Fill(this.avtoparkDataSet.slusari);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Додати
            this.slusariBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //Видалити
           this.slusariBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Оновити
            this.Validate();
            this.slusariBindingSource.EndEdit();
            this.slusariTableAdapter.Update(this.avtoparkDataSet.slusari);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Експорт таблиці в pdf
            DevExpress.XtraGrid.Views.Grid.GridView Viev = gridControl2.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (Viev != null)
            {
                Viev.ExportToPdf("Slusati.pdf");
                Process pdfExport = new Process();
                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "Slusati.pdf";
                pdfExport.Start();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Експорт таблиці в OneNote
            this.gridControl2.Print();
        }
    }
}