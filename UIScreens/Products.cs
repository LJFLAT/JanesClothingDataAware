﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanesClothingDataAware
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //frmMainForm mainForm = new frmMainForm();
            //mainForm.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmProductsAdd editForm = new frmProductsAdd();
            editForm.ShowDialog();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet2.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.salesDataSet2.Products);
        }
    }
}
