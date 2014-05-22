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
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm2()
        {
            InitializeComponent();
        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoparkDataSet.vodii". При необходимости она может быть перемещена или удалена.
            this.vodiiTableAdapter.Fill(this.avtoparkDataSet.vodii);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Додати новий запис
            this.vodiiBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Видалити запис
            this.vodiiBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Зберегти            
            this.Validate();
            this.vodiiBindingSource.EndEdit();
            this.vodiiTableAdapter.Update(this.avtoparkDataSet.vodii);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Оновити таблицю
            this.gridControl1.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Експорт таблиці в pdf
            DevExpress.XtraGrid.Views.Grid.GridView Viev = gridControl2.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (Viev != null)
            {
                Viev.ExportToPdf("Vodii.pdf");
                Process pdfExport = new Process();
                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "Vodii.pdf";
                pdfExport.Start();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Експорт таблиці в OneNote
            this.gridControl2.Print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Переміщення таблиці на передній фон 
            this.gridControl2.SendToBack();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Переміщення таблиці на передній фон
            this.gridControl1.SendToBack();
        }
    }
}