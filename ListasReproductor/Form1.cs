using ListasReproductor.clases;
using ListasReproductor.listaCircularEj;
using ListasReproductor.ListaDoble;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasReproductor
{
    public partial class Form1 : Form
    {
        NodoCir nuevo;
        String[] ArchivosMP3; //para almacenar todos los archivos seleccionados de forma temporal
        String[] rutasArchivoMP3; 
        

        OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog(); //Para seleccionar las canciones que quiera
        objListaOrdenada addpath = new objListaOrdenada();
        clsListaDoble ListaDoble = new clsListaDoble();
        ListaCircular Circular = new ListaCircular();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CajaDeBusquedaDeArchivos.Multiselect = true; //Esto va a permitir seleccionar varios archivos al mismo tiempo

            //Este if se encarga de abrir la ventana
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK) //Para recolectar los datos de la caja de dialogo
            {
                rutasArchivoMP3 = CajaDeBusquedaDeArchivos.SafeFileNames; //Aqui se van a almacenar todos los archivos que seleccione
                ArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames; //Guardamos las rutas de los archivos temporal

                //Para recorrer dependiendo de la cantidad de canciones que haya ingresado 
                for (int i = 0; i < CajaDeBusquedaDeArchivos.FileNames.Length; i++)
                {
                    string rutas;
                    rutas = rutasArchivoMP3[i]; //Para que vaya tomando el valor de cada ruta almacenada en el arreglo rutasArchivoMP3
                    //addpath.insertaOrden(dt); //Para insertarlas a la lista doble
                    ListaDoble.insertarCabezaLista(rutas); //Para insertar las canciones que tengo almacenadas en el vector a la lista doble
                    Circular.insertar(rutas); //Para insertar las canciones a la lista circular
                }

                string[] datos = ListaDoble.vizualizarTam(); //Tomando los datos de la Lista y agregandolos a un arreglo para calcular el tamaño

                foreach (string dato in datos) //Para leer cada uno de los archivos mp3 que adjunte
                {
                    lstCanciones.Items.Add(dato); //Agregando las canciones al listbox    
                }
                //Reproductor.URL = CajaDeBusquedaDeArchivos.FileNames[0];
                //lstCanciones.SelectedIndex = 0; //SelectedIndex para obtener el índice del elemento seleccionado

                int pausa;
                pausa = 0;


            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Insertar las canciones al listbox
            //Va a ejecutarse mientras selectedIndex sea diferente a -1
            if (lstCanciones.SelectedIndex != -1) //diferente a -1 porque si el valor es -1 significa que no se ha seleccionado ningún valor.
            {
                //Esto va a hacer que cuando el usuario seleccione de la lista de reproduccion automaticamente se reproduzca en windows media player
                Reproductor.URL = CajaDeBusquedaDeArchivos.FileNames[lstCanciones.SelectedIndex];
                int index= lstCanciones.SelectedIndex; 
                nuevo = new NodoCir(CajaDeBusquedaDeArchivos.FileNames[index]);
                
            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            String elim = CajaDeBusquedaDeArchivos.FileNames[lstCanciones.SelectedIndex];
            int eliminar = lstCanciones.SelectedIndex; //Para tomar la posicion a eliminar

            if (lstCanciones.SelectedIndex != -1) // diferente a - 1 porque si el valor es - 1 significa que no se ha seleccionado ningún valor.
            {
                ListaDoble.eliminar(elim);
                Circular.eliminar(elim);
                lstCanciones.Items.RemoveAt(eliminar); //Para eliminar lo que este en la posicion 
                
            }else
            {
                MessageBox.Show("No se pudo eliminar la cancion");
            }

            int pausa;
            pausa = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.play();

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.pause();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Pasar a la siguiente cancion
            if (lstCanciones.SelectedIndex < lstCanciones.Items.Count - 1) //.items.Conut para obtener el número de elementos del de la lista
            {
                lstCanciones.SelectedIndex = lstCanciones.SelectedIndex + 1;
            }else
            {
                Repetir();

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //VOLVER A LA CANCION ANTERIOR
            if(lstCanciones.SelectedIndex > 0)
            {
                lstCanciones.SelectedIndex = lstCanciones.SelectedIndex- 1;
            }
            else
            {
                MessageBox.Show("NO SE PUEDE RETROCEDER");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random(); //Inicializando una instancia de la clase Random
            int ale = aleatorio.Next(lstCanciones.Items.Count - 1); //Para recorrer todo lo que esta dentro del listbox
            Reproductor.URL = CajaDeBusquedaDeArchivos.FileNames[ale];
            lstCanciones.SelectedIndex = ale;
        }

        private void Repeticion_Click(object sender, EventArgs e)
        {
            Repetir();

        }

        public void Repetir()
        {

            if (nuevo != null)
            {
                nuevo = Circular.lc.enlace;
                                               
                while (nuevo == Circular.lc.enlace)
                {
                    if (lstCanciones.SelectedIndex < lstCanciones.Items.Count - 1)
                    {
                        MessageBox.Show("AUN NO HA LLEGADO A LA ULTIMA CANCION");
                        lstCanciones.SelectedIndex += 1;
                        nuevo = nuevo.enlace;
                    }
                    else
                    {
                        MessageBox.Show("¿QUIERES VOLVER A LA PRIMERA CANCION DE LA LISTA?");
                        Reproductor.URL = CajaDeBusquedaDeArchivos.FileNames[0];
                        lstCanciones.SelectedIndex = 0;
                        nuevo = nuevo.enlace;
                    }

                    nuevo = nuevo.enlace;
                }
            }
            else
            {
                MessageBox.Show("\t LA LISTA SE ENCUENTRA VACIA.");
            }
        }


    }
}


