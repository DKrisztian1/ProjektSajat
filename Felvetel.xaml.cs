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
using System.Windows.Shapes;

namespace Felvetelizok
{
    /// <summary>
    /// Interaction logic for Felvetel.xaml
    /// </summary>
    public partial class Felvetel : Window
    {
        Diak diakAdatai;
        public Felvetel()
        {
            InitializeComponent();
        }

        public Felvetel(Diak ujDiak) : this() => diakAdatai = ujDiak;

        private void btnFelvetel_Click(object sender, RoutedEventArgs e)
        {
            string ujSor = $"{txtOMAzon.Text};{txtNev.Text};{txtEmail};{dpDatum.Text};{txtCim.Text};{int.Parse(txtMatek.Text)};{int.Parse(txtMagyar.Text)}";
            diakAdatai = new Diak(ujSor);
            Close();

        }
    }
}
