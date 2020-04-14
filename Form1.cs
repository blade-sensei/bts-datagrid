using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Datagrid
{
    public partial class Form1 : Form
    {
       
        DataGrid dtg_liste = new DataGrid();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void inisialiser()
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = _InscriptionEtudiant_2011_2012DataSet.CURSUS;
            dtg_liste.DataSource = dt;

            
        }
    }
}
