using DependencyInversion.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInversion
{
    public partial class Form1 : Form
    {
        //En el caso de que quiera cambiar el tipo de base de datos deberia cambiarla en esta linea,
        //y en todos los formularios y lugares donde se instancio la clase dataBaseSQL.
        DataBaseSQL dataBaseSQL = new DataBaseSQL();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBaseSQL.Save("Data1"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBaseSQL.Save("Data2");
        }
    }
}
