using ListasReproductor.clases;
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
        bool Play = false;

        OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog(); //Para seleccionar las canciones que quiera
        objListaOrdenada addpath = new objListaOrdenada();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            CajaDeBusquedaDeArchivos.Multiselect = true; //Esto va a permitir seleccionar varios archivos al mismo tiempo

            //Este if se encarga de abrir la ventana
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;//Aqui se van a almacenar todos los archivos

                //Para recorrer dependiendo de la cantidad de canciones que haya ingresado 
                for (int i = 0; i < CajaDeBusquedaDeArchivos.FileNames.Length; i++) 
                    //FileNames para devolver la extensión de la ruta de acceso del archivo
                {
                    addpath.insertaOrden(CajaDeBusquedaDeArchivos.FileNames[i]); //Para insertarlas a la lista
                   
                    //Para insertarlas al listbox
                    lstCanciones.Items.Add(CajaDeBusquedaDeArchivos.SafeFileNames[i]); 
                    //SafeFileNames para obtener el nombre y la extensión del archivo seleccionado
                }


                Reproductor.URL = CajaDeBusquedaDeArchivos.FileNames[0];
                lstCanciones.SelectedIndex = 0; //SelectedIndex para obtener el índice del elemento seleccionado

                int pausa;
                pausa = 0;

            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Insertar las canciones al listbox
            //Va a ejecutarse mientras selectedIndex sea diferente a -1
            if (lstCanciones.SelectedIndex != -1)
            {
    //Esto va a hacer que cuando el usuario seleccione de la lista de reproduccion automaticamente se reproduzca en windows media player
                Reproductor.URL = CajaDeBusquedaDeArchivos.FileNames[lstCanciones.SelectedIndex];  
                
            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            int eliminar = lstCanciones.SelectedIndex; //Para tomar la posicion a eliminar

            if (lstCanciones.SelectedIndex != -1)
            {
                addpath.eliminar(eliminar);
                lstCanciones.Items.RemoveAt(eliminar); //Para eliminar lo que este en la posicion 
                Reproductor.Ctlcontrols.stop();
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
            btnPlay.Image = Properties.Resources.iniciar;
            Play = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Pasar a la siguiente cancion
            if (lstCanciones.SelectedIndex < lstCanciones.Items.Count - 1)
            {
                lstCanciones.SelectedIndex = lstCanciones.SelectedIndex + 1;
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //VOLVER A LA CANCION ANTERIOR
            if(lstCanciones.SelectedIndex > 0)
            {
                lstCanciones.SelectedIndex = lstCanciones.SelectedIndex- 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        
    }
}


