﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject
{
    public partial class StudentOtherRequests : StudentHeader
    {
        public StudentOtherRequests()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            //dll.BL.Course c = new dll.BL.Course();
            //DataTable dt = c.GetCourses();

            //dataGridView1.DataSource = dt;



            //// Add Delete Button Column
            //if (!kryptonDataGridView1.Columns.Contains("btnDelete"))
            //{
            //    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();

            //    btnDelete.FlatStyle = FlatStyle.Flat;
            //    btnDelete.HeaderText = "Delete Course";
            //    btnDelete.Text = "Delete";
            //    btnDelete.Name = "btnDelete";
            //    btnDelete.UseColumnTextForButtonValue = true;
            //    btnDelete.DefaultCellStyle.BackColor = Color.Red;
            //    btnDelete.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            //    kryptonDataGridView1.Columns.Add(btnDelete);
            //}
        }

        private void StudentOtherRequests_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //    // Ignore header and out-of-range clicks
            //    if (e.RowIndex < 0 || e.ColumnIndex != kryptonDataGridView1.Columns["btnDelete"].Index)
            //        return;

            //    // Get ID of the selected row
            //    int id = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["CourseID"].Value);

            //    // Confirm deletion
            //    var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        DBProjectBackend.BL.Course c = new DBProjectBackend.BL.Course();
            //        bool flag = c.DeleteCourse(id);
            //        LoadData(); // Refresh the grid
            //    }
            //}
        }
    }
}
