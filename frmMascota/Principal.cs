using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMascota
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        List<Mascota> mascotas = new List<Mascota>();
        private void Form1_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            cmbTipoAnimal.Items.Add("Perro");
            cmbTipoAnimal.Items.Add("Gato");
            cmbTipoAnimal.Items.Add("Hamster");
            cmbTipoAnimal.SelectedIndex = 0;
            cmbTipoAnimal2.Items.Add("Perro");
            cmbTipoAnimal2.Items.Add("Gato");
            cmbTipoAnimal2.Items.Add("Hamster");
            cmbTipoAnimal2.SelectedIndex = 0;
            LimpiarInterfaz();
        }
        public void LimpiarInterfaz()
        {
            txtEdad.Text = "";
            txtNombre.Text = "";
            cmbTipoAnimal.SelectedIndex = 0;
            lblAlimentar.Text = "0";
            lblCuidar.Text = "0";   
            lblJugar.Text = "0";
            btnCargar.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {               
                Mascota nuevaMascota = new Mascota();
                nuevaMascota.Nombre = txtNombre.Text;
                nuevaMascota.TipoAnimal = cmbTipoAnimal.Text;
                nuevaMascota.Edad = int.Parse(txtEdad.Text);

                // Agregar la mascota a la lista de mascotas
                mascotas.Add(nuevaMascota);
            LimpiarInterfaz();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            foreach(Mascota mascota in mascotas)
            {
                lstConsulta.Items.Add("Nombre de la mascota: " + mascota.Nombre);
                lstConsulta.Items.Add("Tipo de animal: " + mascota.TipoAnimal);
                lstConsulta.Items.Add("Edad: " + mascota.Edad.ToString());
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtNombre.Text != "" && txtEdad.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }            
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEdad.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int jugar = 0;
        int alimentar = 0;
        int cuidar = 0;
        private void btnAlimentar_Click(object sender, EventArgs e)
        {      
            pcbFoto.Visible = true;
            alimentar++;
            lblAlimentar.Text = alimentar.ToString();
            if (cmbTipoAnimal2.SelectedIndex == 0)
            {
                string rutaImagen = "perrito.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cmbTipoAnimal2.SelectedIndex == 1)
            {
                string rutaImagen = "gatito.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cmbTipoAnimal2.SelectedIndex == 2)
            {
                string rutaImagen = "hamster.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        
        private void btnJugar_Click(object sender, EventArgs e)
        {
            pcbFoto.Visible = true;
            jugar++;
            lblJugar.Text = jugar.ToString();
            if (cmbTipoAnimal2.SelectedIndex == 0)
            {
                string rutaImagen = "perrito.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cmbTipoAnimal2.SelectedIndex == 1)
            {
                string rutaImagen = "gatito.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cmbTipoAnimal2.SelectedIndex == 2)
            {
                string rutaImagen = "hamster.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCuidar_Click(object sender, EventArgs e)
        {
            pcbFoto.Visible = true;
            cuidar++;
            lblCuidar.Text = cuidar.ToString();
            if (cmbTipoAnimal2.SelectedIndex == 0)
            {
                string rutaImagen = "perrito.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cmbTipoAnimal2.SelectedIndex == 1)
            {
                string rutaImagen = "gatito.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cmbTipoAnimal2.SelectedIndex == 2)
            {
                string rutaImagen = "hamster.jpg";
                Image imagen = Image.FromFile(rutaImagen);
                pcbFoto.Image = imagen;
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoAnimal2.SelectedIndex = 0;            
            alimentar = 0;
            jugar = 0;
            cuidar = 0;
            lblAlimentar.Text = "0";
            lblJugar.Text = "0";
            lblCuidar.Text = "0";
            pcbFoto.Visible = false;
        }
    }
}
