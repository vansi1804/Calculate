using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateProfit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1050, 500);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtpNgayBatDau.Value = DateTime.Parse("04/06/2022");
            dtpNgayKetThuc.Value = DateTime.Today;
        }

        public float Lamtron(float x)
        {
            return (float)Math.Round(x, 1);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            float von = float.Parse(tbVon.Text);
            float loinhuanngay = float.Parse(tbLoiNhuan.Text);
            float rut = float.Parse(tbRut.Text);
            int songay = dtpNgayKetThuc.Value.Subtract(dtpNgayBatDau.Value).Days + 1;
            DateTimePicker date = new DateTimePicker();
            date.Value = dtpNgayBatDau.Value;
            for (int i = 1; i <= songay; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                row.Cells[0].Value = i;
                row.Cells[1].Value = date.Value.ToString();
                row.Cells[2].Value = von;
                float sotienmoilenh = von * float.Parse(tbMoiLenh.Text);
                row.Cells[3].Value = Lamtron(sotienmoilenh);
                float lai = Lamtron(von * float.Parse(tbLoiNhuan.Text));
                row.Cells[4].Value = lai;
                float voncuoingay = von + lai;
                row.Cells[5].Value = voncuoingay;
                int ngayrut = int.Parse(date.Value.Day.ToString());
                if (ngayrut == 9 || ngayrut == 19 || ngayrut == 25)
                {
                    if (DateTime.Compare(date.Value, DateTime.Parse("04/09/2022")) != 0)
                    {

                        voncuoingay -= rut;
                        row.Cells[6].Value = "rút " + rut.ToString() + ". Vốn còn: " + voncuoingay.ToString();
                    }
                    
                }
                von = voncuoingay;
                dgv.Rows.Add(row);
                if (DateTime.Compare(date.Value, DateTime.Today) == 0)
                {
                    dgv.Rows[0].Selected = false;
                    dgv.Rows[i - 1].Selected = true;
                }
                date.Value = date.Value.AddDays(1);
            }
        }

        private void ValueChange(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpNgayBatDau.Value, dtpNgayKetThuc.Value) > 0)
            {
                if (sender == dtpNgayBatDau)
                {
                    dtpNgayBatDau.Value = DateTime.Today;
                }
                else
                {
                    dtpNgayKetThuc.Value = DateTime.Today;
                }
            }
            tbSoNgay.Text = (dtpNgayKetThuc.Value.Subtract(dtpNgayBatDau.Value).Days + 1).ToString();
        }
    }
}
