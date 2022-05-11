using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semana6RickyBlacio
{
    public partial class MainPage : ContentPage
    {

        
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked (object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                // Datos a enviar al POST - insertar

                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                cliente.UploadValues("http://172.16.10.205/moviles/post.php", "POST", parametros);
                DisplayAlert("Mensaje de alerta", "Ingreso Correcto", "ok");

            }
            catch (Exception ex)

            {
                DisplayAlert("Mensaje de alerta", ex.Message, "ok");
            }

        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {

        }
    }
}


