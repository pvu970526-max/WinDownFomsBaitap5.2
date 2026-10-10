namespace Baitap5._2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private Dictionary<string, BindingList<Service>> servicesByCategory;
        private BindingList<Service> selectedServices;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            servicesByCategory = new Dictionary<string, BindingList<Service>>();
            // Sample services with prices
            servicesByCategory["Khám bệnh"] = new BindingList<Service>
            {
                new Service("Khám tổng quát", 150000, "Khám bệnh"),
                new Service("Khám chuyên khoa", 250000, "Khám bệnh"),
            };

            servicesByCategory["Xét nghiệm"] = new BindingList<Service>
            {
                new Service("Máu toàn phần", 120000, "Xét nghiệm"),
                new Service("Sinh hóa cơ bản", 200000, "Xét nghiệm"),
            };

            servicesByCategory["Chụp X-Quang"] = new BindingList<Service>
            {
                new Service("X-Quang phổi", 300000, "Chụp X-Quang"),
                new Service("X-Quang cột sống", 350000, "Chụp X-Quang"),
            };

            servicesByCategory["Vắc-xin"] = new BindingList<Service>
            {
                new Service("Vắc-xin phòng cúm", 200000, "Vắc-xin"),
                new Service("Vắc-xin 6 trong 1", 500000, "Vắc-xin"),
            };

            // combo categories
            cboCategory.Items.AddRange(servicesByCategory.Keys.ToArray());
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;

            // selected services list
            selectedServices = new BindingList<Service>();
            lstSelectedServices.DisplayMember = "DisplayText";
            lstSelectedServices.DataSource = selectedServices;

            // initial binding for available list is handled in SelectedIndexChanged
            txtTotal.Text = "0";
            txtFinal.Text = "0";
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableServicesForSelectedCategory();
        }

        private void LoadAvailableServicesForSelectedCategory()
        {
            if (cboCategory.SelectedItem == null) return;
            var key = cboCategory.SelectedItem.ToString();
            if (!servicesByCategory.ContainsKey(key)) return;

            lstAvailableServices.DisplayMember = "DisplayText";
            lstAvailableServices.DataSource = servicesByCategory[key];
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var selected = lstAvailableServices.SelectedItems.Cast<Service>().ToList();
            if (selected.Count == 0) return;
            var category = cboCategory.SelectedItem?.ToString();
            foreach (var s in selected)
            {
                // remove from available
                if (category != null && servicesByCategory.ContainsKey(category))
                {
                    servicesByCategory[category].Remove(s);
                }
                // add to selected
                selectedServices.Add(s);
            }
            // refresh available list binding
            LoadAvailableServicesForSelectedCategory();
            RecalculateTotals();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var toRemove = lstSelectedServices.SelectedItems.Cast<Service>().ToList();
            if (toRemove.Count == 0) return;
            foreach (var s in toRemove)
            {
                selectedServices.Remove(s);
                // return to its original category if possible
                if (!string.IsNullOrEmpty(s.Category) && servicesByCategory.ContainsKey(s.Category))
                {
                    servicesByCategory[s.Category].Add(s);
                }
                else
                {
                    // fallback: add to currently selected category
                    var current = cboCategory.SelectedItem?.ToString();
                    if (current != null) servicesByCategory[current].Add(s);
                }
            }
            LoadAvailableServicesForSelectedCategory();
            RecalculateTotals();
        }

        private void lstSelectedServices_DoubleClick(object sender, EventArgs e)
        {
            btnRemove_Click(sender, e);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            var all = selectedServices.ToList();
            foreach (var s in all)
            {
                selectedServices.Remove(s);
                if (!string.IsNullOrEmpty(s.Category) && servicesByCategory.ContainsKey(s.Category))
                {
                    servicesByCategory[s.Category].Add(s);
                }
            }
            LoadAvailableServicesForSelectedCategory();
            RecalculateTotals();
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            RecalculateTotals();
        }

        private void RecalculateTotals()
        {
            decimal total = selectedServices.Sum(s => s.Price);
            txtTotal.Text = total.ToString("N0");
            decimal discountPercent = Convert.ToDecimal(nudDiscount.Value);
            decimal final = total * (1 - discountPercent / 100m);
            if (final < 0) final = 0;
            txtFinal.Text = final.ToString("N0");
        }
    }

    public class Service
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Service(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public string DisplayText => $"{Name} - {Price:N0}";

        public override string ToString() => DisplayText;
    }
}
