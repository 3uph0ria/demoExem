using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для users.xaml
    /// </summary>
    public partial class users : Page
    {
        public users()
        {
            InitializeComponent();
            ListViewServices.ItemsSource = poday_na_16Entities.GetContext().Services.ToList();

            var services = poday_na_16Entities.GetContext().Services.ToList();
            CountServices.Text = "Отображено " + services.Count + " из " + services.Count;

        }

        

        private void DiscountSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSort();
        }

        private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSort();
        }

        private void UpdateSort()
        {
            
            var services = poday_na_16Entities.GetContext().Services.ToList();
            var CountAllServicrs = services.Count;

            switch (CostSort.SelectedIndex)
            {
                case 0:
                    services = services.ToList();
                    break;
                case 1:
                    services = services.OrderBy(p => p.Cost).ToList();
                    break;
                case 2:
                    services = services.OrderByDescending(p => p.Cost).ToList();
                    break;
            }

            switch (DiscountSort.SelectedIndex)
            {
                case 0:
                    services = services.ToList();
                    break;
                case 1:
                    services = services.Where(p => p.DiscountProcent < 5).ToList();
                    services = services.Where(p => p.DiscountProcent >= 0).ToList();
                    break;
                case 2:
                    services = services.Where(p => p.DiscountProcent < 15).ToList();
                    services = services.Where(p => p.DiscountProcent >= 5).ToList();
                    break;
                case 3:
                    services = services.Where(p => p.DiscountProcent < 30).ToList();
                    services = services.Where(p => p.DiscountProcent >= 15).ToList();
                    break;
                case 4:
                    services = services.Where(p => p.DiscountProcent < 70).ToList();
                    services = services.Where(p => p.DiscountProcent >= 30).ToList();
                    break;
                case 5:
                    services = services.Where(p => p.DiscountProcent < 100).ToList();
                    services = services.Where(p => p.DiscountProcent > 70).ToList();
                    break;
            }

            services = services.Where(p => p.Name.ToLower().Contains(TextSearch.Text.ToLower())).ToList();
           

            ListViewServices.ItemsSource = services;

            CountServices.Text = "Отображено " + services.Count + " из " + CountAllServicrs;

        }
    }
}
