using System.Collections.Generic;
using System.Windows;

namespace PromotionWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для PromotionWindow.xaml
    /// </summary>
    public partial class PromotionWindow : Window
    {
        public PromotionWindow()
        {
            InitializeComponent();
            var list = new List<PromotionTemplate>();
            {
                PromotionTemplate promotion1 = new PromotionTemplate()
                {
                    Name = "Летняя распродажа",
                    Value = "10% скидка",
                    Date = "2023-07-15"
                };
                list.Add(promotion1);

                PromotionTemplate promotion2 = new PromotionTemplate()
                {
                    Name = "Блэк Фрайдей",
                    Value = "50% скидка",
                    Date = "2023-11-25"
                };
                list.Add(promotion2);

                PromotionTemplate promotion3 = new PromotionTemplate()
                {
                    Name = "Распродажа новогодних товаров",
                    Value = "20% скидка",
                    Date = "2023-12-31"
                };
                list.Add(promotion3);

            } // data for dg
            promotionDataGrid.ItemsSource = list;


        }
    }

    class PromotionTemplate
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Date { get; set; }
    }
}
