using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Dog> Dogs = new List<Dog>();
        DogsController Controller = new DogsController();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateData()
        {
            Dogs = Controller.GetAll();
            dgvDogs.DataSource = null;
            dgvDogs.DataSource = Dogs;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            dog.Id = int.Parse(txtId.Text);
            dog.Name = txtName.Text;
            dog.Age = int.Parse(txtAge.Text);

            Controller.Add(dog);
            UpdateData();
        }

        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            Controller.DeleteLast();
            UpdateData();
        }

        private void btnDeleteById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            Controller.DeleteByID(id);
            UpdateData();
        }

        private void btnUpdateById_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            dog.Id = int.Parse(txtId.Text);
            dog.Name = txtName.Text;
            dog.Age = int.Parse(txtAge.Text);
            Controller.UpdateByID(dog);
            UpdateData();
        }
    }
}
