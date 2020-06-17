using Observer.Classes;
using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        ConcreteSubject subject = new ConcreteSubject();
        IObserver observer1 = new ConcreteObserver();
        IObserver observer2 = new ConcreteObserver();
        IObserver observer3 = new ConcreteObserver();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dispara el evento del cual seran informados los observers.
            subject.AddProduct();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Agrega los observadores.
            subject.Subscribe(observer1);
            subject.Subscribe(observer2);
            subject.Subscribe(observer3);
        }
    }
}
