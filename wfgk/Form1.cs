using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfgk
{
    public partial class Form1 : Form
    {







        public void PP(Label label) {

            Color color;
            string a;

            if (H)
            {
                color = Color.Salmon;
                a = "k";
            }
            else
            { 
                color = Color.Blue;
                a = "c";
            }

            for (int i = 0; i < tableLayoutPanel1.Size.Height; i++)
            {

                for (int j = 0; j < tableLayoutPanel1.Size.Height; j++)
                {

                }

            }

            if (tableLayoutPanel1.GetColumn(label) + 1 >= 0)
            {
                if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label)).Text != a)

                    tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label)).BackColor = color;
            }

            if (tableLayoutPanel1.GetColumn(label) - 1 >= 0)
            {
                if(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label)).Text != a)

                    tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label)).BackColor = color; 
            }

            if (tableLayoutPanel1.GetRow(label) + 1 >= 0)
            {
                if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) + 1).Text != a)

                    tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
            }

            if (tableLayoutPanel1.GetRow(label) - 1 >= 0)
            {
                if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) - 1).Text != a)

                    tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
            }

            if (tableLayoutPanel1.GetColumn(label) + 1 >= 0 & tableLayoutPanel1.GetRow(label) + 1 < tableLayoutPanel1.RowCount)
            {
                if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) + 1).Text != a)

                    tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
            }

            if (tableLayoutPanel1.GetColumn(label) - 1 >= 0 & tableLayoutPanel1.GetRow(label) + 1 < tableLayoutPanel1.RowCount)
            {
                if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) + 1).Text != a)

                    tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
            }

            if (tableLayoutPanel1.GetColumn(label) + 1 >= 0 & tableLayoutPanel1.GetRow(label) - 1 < tableLayoutPanel1.RowCount)
            {
                if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) - 1).Text != a)

                    tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
            }

            if (tableLayoutPanel1.GetColumn(label) - 1 >= 0 & tableLayoutPanel1.GetRow(label) - 1 < tableLayoutPanel1.RowCount)
            {
                if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) - 1).Text != a)

                    tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
            }

            NMove.Text = Convert.ToString(int.Parse(NMove.Text) + 1);
                if (NMove.Text == "5")
                {
                    NMove.Text = "0"; lTeam.Text = "Гим"; H = false;
                }


            


        }



        public bool H = true;


        public Form1()
        {
            InitializeComponent();            

            

            tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount-2).Text = "k";
            
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) + 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2))).BackColor = Color.Salmon;
            
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) - 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2))).BackColor = Color.Salmon;
            
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)), tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) + 1).BackColor = Color.Salmon;
            
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)), tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) - 1).BackColor = Color.Salmon;

                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) + 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2))- 1).BackColor = Color.Salmon;

                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) - 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) - 1).BackColor = Color.Salmon;

                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) + 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) + 1).BackColor = Color.Salmon;

                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) - 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(1, tableLayoutPanel1.RowCount - 2)) + 1).BackColor = Color.Salmon;


            tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount-2, 1).Text = "c";
                //
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) + 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1))).BackColor = Color.Blue;
                //
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) - 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1))).BackColor = Color.Blue;
                //
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)), tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) + 1).BackColor = Color.Blue;
                //
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)), tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) - 1).BackColor = Color.Blue;
                //
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) + 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1))+1).BackColor = Color.Blue;
                //
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) - 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1))-1).BackColor = Color.Blue;
                //
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1))  -1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) + 1).BackColor = Color.Blue;
                //
                tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) + 1, tableLayoutPanel1.GetRow(tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.ColumnCount - 2, 1)) - 1).BackColor = Color.Blue;


        }


        public void _Click(object sender, EventArgs e)
        {
            Label label = sender as Label;

            string a;
            Color color;

            if (H)
            {
                color = Color.Salmon;
                a = "k";                
            }
            else
            {
                color = Color.Blue;
                a = "c";
            }

            

            if (label.BackColor == color)
            {
                label.Text = a;

                if (tableLayoutPanel1.GetColumn(label) + 1 < tableLayoutPanel1.ColumnCount)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label)).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label)).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) - 1 >= 0)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label)).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label)).BackColor = color;
                }

                if (tableLayoutPanel1.GetRow(label) + 1 < tableLayoutPanel1.RowCount)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) + 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetRow(label) - 1 >= 0)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) - 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label), tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) + 1 < tableLayoutPanel1.ColumnCount & tableLayoutPanel1.GetRow(label) + 1 < tableLayoutPanel1.RowCount)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) + 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) - 1 >= 0 & tableLayoutPanel1.GetRow(label) + 1 < tableLayoutPanel1.RowCount)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) + 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) + 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) + 1 < tableLayoutPanel1.ColumnCount & tableLayoutPanel1.GetRow(label) - 1 >= 0)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) - 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) + 1, tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
                }

                if (tableLayoutPanel1.GetColumn(label) - 1 >= 0 & tableLayoutPanel1.GetRow(label) - 1 >= 0)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) - 1).Text != a)

                        tableLayoutPanel1.GetControlFromPosition(tableLayoutPanel1.GetColumn(label) - 1, tableLayoutPanel1.GetRow(label) - 1).BackColor = color;
                }

                NMove.Text = Convert.ToString(int.Parse(NMove.Text) + 1);
                if (NMove.Text == "5")
                {
                    if (H)
                    {
                        NMove.Text = "0"; lTeam.Text = "Гим"; H = false;
                    }
                    else
                    {
                        NMove.Text = "0"; lTeam.Text = "БУБА"; H = true;
                    }
                }
            }


            }

        private void button1_Click(object sender, EventArgs e)
        {

            if (H)
            {

                NMove.Text = "0"; lTeam.Text = "Гим"; H = false;

            }
            else
            {
                NMove.Text = "0"; lTeam.Text = "БУБА"; H = true;
            }
        }
    }
    
       
    }

