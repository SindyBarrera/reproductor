
namespace ListasReproductor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Aleatorio = new System.Windows.Forms.PictureBox();
            this.Repeticion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeticion)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(85, 244);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(617, 127);
            this.Reproductor.TabIndex = 0;
            // 
            // lstCanciones
            // 
            this.lstCanciones.BackColor = System.Drawing.Color.DarkGray;
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(85, 52);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(456, 186);
            this.lstCanciones.TabIndex = 1;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ListasReproductor.Properties.Resources.agregar;
            this.btnAgregar.Location = new System.Drawing.Point(586, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 80);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::ListasReproductor.Properties.Resources.detener;
            this.btnStop.Location = new System.Drawing.Point(194, 392);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 62);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 3;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::ListasReproductor.Properties.Resources.iniciar;
            this.btnPlay.Location = new System.Drawing.Point(381, 392);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(77, 62);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 4;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::ListasReproductor.Properties.Resources.anterior;
            this.btnAnterior.Location = new System.Drawing.Point(85, 392);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 62);
            this.btnAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnterior.TabIndex = 7;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ListasReproductor.Properties.Resources.siguiente;
            this.pictureBox1.Location = new System.Drawing.Point(482, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ListasReproductor.Properties.Resources.titulo;
            this.pictureBox2.Location = new System.Drawing.Point(164, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(827, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // remover
            // 
            this.remover.Image = global::ListasReproductor.Properties.Resources.remover;
            this.remover.Location = new System.Drawing.Point(586, 148);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(84, 78);
            this.remover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.remover.TabIndex = 13;
            this.remover.TabStop = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ListasReproductor.Properties.Resources.pausa;
            this.pictureBox3.Location = new System.Drawing.Point(289, 392);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Aleatorio
            // 
            this.Aleatorio.Image = global::ListasReproductor.Properties.Resources.aleatorio;
            this.Aleatorio.Location = new System.Drawing.Point(593, 392);
            this.Aleatorio.Name = "Aleatorio";
            this.Aleatorio.Size = new System.Drawing.Size(77, 62);
            this.Aleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aleatorio.TabIndex = 15;
            this.Aleatorio.TabStop = false;
            this.Aleatorio.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Repeticion
            // 
            this.Repeticion.Image = global::ListasReproductor.Properties.Resources.repetir;
            this.Repeticion.Location = new System.Drawing.Point(733, 261);
            this.Repeticion.Name = "Repeticion";
            this.Repeticion.Size = new System.Drawing.Size(87, 77);
            this.Repeticion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Repeticion.TabIndex = 16;
            this.Repeticion.TabStop = false;
            this.Repeticion.Click += new System.EventHandler(this.Repeticion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListasReproductor.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(934, 504);
            this.Controls.Add(this.Repeticion);
            this.Controls.Add(this.Aleatorio);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeticion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox remover;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Aleatorio;
        private System.Windows.Forms.PictureBox Repeticion;
    }
}

