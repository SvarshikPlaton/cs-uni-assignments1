/******************************************************/
/*               Лабораторная работа № 4              */
/*      Абстрактные сущности и связи между ними       */
/*                      Задание 1                     */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab02FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb1.SelectedIndex = 0;
            cb2.SelectedIndex = 0;
        }

        int row = 0;
        List<Watch> watches = new List<Watch>();

        private void UpdateTable() {
            Sort();
            dataGridView1.RowCount = watches.Count;
            for (int i = 0; i < watches.Count; i++) {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DimGray;
                dataGridView1.Rows[i].Cells[0].Value = watches[i].GetStatus();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Watch watch = null;
            if (tb1.Text != "" && tb2.Text != "")
                watch = new Watch(tb1.Text, tb2.Text);
            else if (tb1.Text != "" && tb2.Text == "")
                watch = new Watch(tb1.Text);
            else 
                watch = new Watch();

            watches.Add(watch);
            UpdateTable();

            groupBox2.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.CurrentRow.Index;
            groupBox2.Text = "Control:" + (row + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            watches[row].TurnPower();
            UpdateTable();
        }

        private void button3_Click(object sender, EventArgs e) {
            watches[row].TurnAlarmWatch();
            UpdateTable();
        }

        private void button4_Click(object sender, EventArgs e) {
            watches[row].TurnBacklight();
            UpdateTable();
        }

        private void cb4_SelectedIndexChanged(object sender, EventArgs e) {
            watches[row].SetGeo((GeoTime)cb1.SelectedIndex);
            UpdateTable();
        }

        private void tb3_KeyPress(object sender, KeyPressEventArgs e) { 
            if (e.KeyChar == 13) {
                watches[row].SetTime(tb3.Text);
                tb3.Text = "";
                UpdateTable();
            }
        }

        private void tb4_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                
                watches[row].SetAlarm(tb4.Text);
                tb4.Text = "";
                UpdateTable();
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            watches.Remove(watches[row]);
            if (watches.Count == 0) {
                groupBox2.Visible = false;
                row = 0;
            }
        }

        void Sort()
        {
            switch (cb2.SelectedIndex)
            {
                case 1:
                    watches.Sort();
                    break;
                case 2:
                    watches.Sort(new Watch.TimeComparer());
                    break;
                case 3:
                    watches.Sort(new Watch.GeoComparer());
                    break;
                case 4:
                    watches.Sort(new Watch.AlarmClockComparer());
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
