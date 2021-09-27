using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2309Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //mediante metodos de propiedad
            //creamos un objeto libro
            //SET
            //country.setCountryId(1);
            //country.setName("Nueva Zelanda");

            //mostrar datos de country
            //MessageBox.Show(country.getCountryId() + country.getName());

            //mediante propiedad autoimplementada
            //set
            //country._altitude = "3724m";

            //GET
           //MessageBox.Show(country._altitude);

            //SET
            //country._latitude = "Entre 37 y 45 grados de latitud Sur y entre 174 y 177 grados de longitud Este";

            //GET
           //MessageBox.Show(country._latitude);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //haciendo uso de constructor pasando todos los parametros
            //instancia de la clase Country
            Country object1 = new Country(1, "Nueva Zelanda, 4.915 millones", "3724m");

            //mostrar datos de objeto1
            // MessageBox.Show(object1.getCountryId() + object1.getName() + object1.getPopulation()
            //   + object1._altitude + object1._latitude);

            //llamado del metodo getCountryInfo
            MessageBox.Show(object1.getCountryInfo());

            //haciendo uso de constructor pasando el parametro Nombre
            Country country = new Country(textBox1.Text);
            listBox1.Items.Add("Objeto" + country.getName());


            //agregar datos al listbox
            listBox1.Items.Add(object1.getCountryInfo());
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
