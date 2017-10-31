using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class insertar : ContentPage
    {

        public ObservableCollection<_13090417> Items { get; set; }
        public static MobileServiceClient Cliente;
        public static IMobileServiceTable<_13090417> Tabla;
//        SQLiteConnection database;
        string picker_carreras;

        public insertar()
        {
            InitializeComponent();
            Cliente = new MobileServiceClient(AzureConnection.AzureURL);
            Tabla = Cliente.GetTable<_13090417>();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var datos = new _13090417
            {
                //Matricula = Convert.ToInt32(Entry_ID.Text),
                Nombre = Entry_Name.Text,
                Apellidos = Entry_Ap.Text,
                Direccion = Entry_Dir.Text,
                Telefono = Entry_Tel.Text,
                Carrera = picker_carreras,
                Semestre = Entry_Sem.Text,
                Correo = Entry_Cor.Text,
                Github = Entry_Git.Text



            };
            await insertar.Tabla.InsertAsync(datos);
            
            //await Navigation.PushAsync(new BasedeDatos());
        }

        private void carreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            var carreras = (Picker)sender;
            int selectedIndex = carreras.SelectedIndex;

            if (selectedIndex != -1)
            {
                picker_carreras = (string)carreras.ItemsSource[selectedIndex];

            }
        }
    }
}