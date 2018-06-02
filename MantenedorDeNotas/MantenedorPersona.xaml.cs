using MantenedorDeNotas.lib.model;
using MantenedorDeNotas.lib.validator;
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

namespace MantenedorDeNotas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int id;
        private List<Persona> personas;
        public MainWindow()
        {
            personas = new List<Persona>();
            id = 1;
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            string validacion = "tamaño debe ser mayor a 1 y menor que 80";
            string messageError = "";
            StringValidator sv = StringValidator.Instance;
            if (!sv.betweenOneAndEightyText(txt_nombre.Text))
            {
                messageError = messageError+ "\nError en campo Nombre"+validacion;
            }

            if (!sv.betweenOneAndEightyText(txt_apa.Text))
            {
                messageError = messageError + "\nError en campo Nombre" + validacion;
            }

            if (!sv.betweenOneAndEightyText(txt_ama.Text))
            {
                messageError = messageError + "\nError en campo Nombre" + validacion;
            }

            if (!sv.betweenOneAndEightyText(txt_correo.Text))
            {
                messageError = messageError + "\nError en campo Nombre" + validacion;
            }

            if (sv.isEmpty(messageError)) {
                Persona persona = new Persona();
                persona.Id = id;
                persona.Run = txt_run.Text;
                persona.Nombres = txt_nombre.Text;
                persona.ApellidoPaterno = txt_apa.Text;
                persona.ApellidoMaterno = txt_ama.Text;
                persona.CorreoElectronico = txt_correo.Text;

                id = id + 1;
                personas.Add(persona);

                dtg_personas.ItemsSource = personas;
                dtg_personas.Items.Refresh();
            }
            else{
                MessageBox.Show(messageError);
            }
        }
    }
}
