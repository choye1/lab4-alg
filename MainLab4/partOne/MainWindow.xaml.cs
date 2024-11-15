using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace partOne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static List<int> list = new List<int>();
        private SelectSort selectSort = new SelectSort(list);
        private int count = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            //List<int> result = selectSort.Sort();
            //for (int i = 0; i < result.Count; i++)
            //{
            //    screen.Text += result[i].ToString();
            //}
            //screen.Text += "\n";

            Condition condition = new Condition(count,selectSort);
            List<int> condRes = condition.ConditionSelectSort();
            for (int i = 0; i < condRes.Count; i++)
            {
                screen.Text += condRes[i].ToString();
            }
            screen.Text += "\n";
        }

        private void AddList(object sender, RoutedEventArgs e)
        {
            for (int i = 0;i < List.Text.Length;i++) 
            {
                    list.Add(int.Parse(List.Text[i].ToString()));
            }
        }
    }
}