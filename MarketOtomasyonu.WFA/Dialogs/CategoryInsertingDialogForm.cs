﻿using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.WFA.Dialogs
{
    public partial class CategoryInsertingDialogForm : Form
    {
        public CategoryInsertingDialogForm()
        {
            InitializeComponent();
        }

        private void btnCategoryCancel_Click(object sender, EventArgs e)
        {

            ProductInsertingDialogForm ProductInsertingDialogForm = new ProductInsertingDialogForm();
            ProductInsertingDialogForm.Show();
            this.Close();

        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {

            bool varMi = false;

            try
            {
                CategoryRepo db = new CategoryRepo();
                Category category = new Category();


                foreach (var item in db.GetAll())
                {
                    if(item.CategoryName.ToLower() == txtCategory.Text.ToLower())
                    {
                        varMi = true;
                        break;
                    }

                }

                if(varMi == false)
                {
                    category.CategoryName = txtCategory.Text;
                    db.Insert(category);
                    MessageBox.Show($"{category.CategoryName} Kategorisi Eklendi");

                    System.Threading.Thread.Sleep(500);

                    ProductInsertingDialogForm ProductInsertingDialogForm = new ProductInsertingDialogForm();
                    ProductInsertingDialogForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu isimde kategoriniz zaten mevcuttur.");
                }

            }
            catch (Exception)
            {

                throw;
            }

           

        }
    }
}
