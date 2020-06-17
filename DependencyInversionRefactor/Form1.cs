using DependencyInversionRefactor.Classes;
using DependencyInversionRefactor.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInversionRefactor
{
    public partial class Form1 : Form
    {
        //DataBaseFactory es la que se encarga de crear un tipo de base de datos o otro
        //por lo cual queda desacoplado este modulo con el del acceso a los datos.
        IDataBase dataBase = DataBaseFactory.CreateDB();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.Save("Data1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBase.Save("Data2");
        }
    }
}
