using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TallerCalc
{
    public partial class MainPage : ContentPage
    {
        double res = 0;
        public MainPage()
        {
            InitializeComponent();
            spin.Items.Add("Suma");
            spin.Items.Add("Resta");
            spin.Items.Add("Multiplicacion");
            spin.Items.Add("Division");
            spin.SelectedIndexChanged += Spin_SelectedIndexChanged;
            btncalcular.Clicked += Btncalcular_Clicked;
        }

        private void Btncalcular_Clicked(object sender, EventArgs e)
        {
         if(!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                String op = spin.SelectedItem.ToString();
                int n1 = Int32.Parse(num1.Text);
                int n2 = Int32.Parse(num2.Text);

                if (op == "Suma")
                {
                    res = n1 + n2;
                }
                else if (op == "Resta")
                {
                    res = n1 - n2;
                }
                else if (op == "Multiplicacion")
                {
                    res = n1 * n2;
                }
                else if (op == "Division")
                {
                    res = n1 / n2;
                }              
                }
                else
                {
                DisplayAlert("Error:", "Digite dos numeros para realizar la operacion seleccionada", "Aceptar");
            }
            resul.Text = res + "";
        }
        private void Spin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
