using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PracticaStruct
{
    public partial class Form1 : Form
    {
        public struct Alumno {
            public string Nombre;
            public double[] Notas;
            public double PromedioNotas;
            public double MayorNota;
        }
        Alumno[] estudiantes;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresaDatos_Click(object sender, EventArgs e)
        {
            estudiantes= new Alumno[4];
            InicializaCampos(estudiantes);
            CargaDatos(estudiantes);

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ImprimeDatos(estudiantes);
        }

        //----------------------------------------METODOS-----------------------------------------------------//
        //----------------------------------------------------------------------------------------------------//

        public void InicializaCampos(Alumno[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].Nombre = "";
                alumnos[i].MayorNota = 0;
                alumnos[i].Notas=new double[3];
                alumnos[i].PromedioNotas = 0;
            }
        }

        public string CargaNombre()
        {
            string nombre = Interaction.InputBox("Ingrese nombre", "Nombre Estudiante");
            return nombre;
        }

        public void CargaNotas(double[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Convert.ToDouble(Interaction.InputBox("Ingrese nota", "Notas"));
            }
        }
        public double Promedio(double[] notas)
        {
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            return suma / notas.Count();
        }

        public void CargaDatos(Alumno[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].Nombre = CargaNombre();
                CargaNotas(alumnos[i].Notas);
                alumnos[i].PromedioNotas=Promedio(alumnos[i].Notas);
                alumnos[i].MayorNota = BuscaMayorNota(alumnos[i].Notas);
            }
        }
        
        public double BuscaMayorNota(double[] notas)
        {
            double mayor = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > mayor) mayor = notas[i];
            }
            return mayor;
        }

        public void MuestraNombre(string nombre)
        {
            lstImprimeDatos.Items.Add(nombre);
        }

        public void MuestraNotas(double[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                lstImprimeDatos.Items.Add(notas[i]);
            }
        }

        public void MuestraPromedioYMayorNota(Alumno alumnos)
        {
            
                lstImprimeDatos.Items.Add($"La mayor nota de {alumnos.Nombre} es : {alumnos.MayorNota}");
                lstImprimeDatos.Items.Add($"Promedio : {alumnos.PromedioNotas}");

                if (alumnos.PromedioNotas < 4) lstImprimeDatos.Items.Add("Debes ir a recuperatorio !\n");
                else if (alumnos.PromedioNotas >= 4 && alumnos.PromedioNotas <= 7) lstImprimeDatos.Items.Add("Bien !\n");
                else if (alumnos.PromedioNotas > 7) lstImprimeDatos.Items.Add("Muy Bien !\n");
                else lstImprimeDatos.Items.Add("Hubo un error!\n");
            
        }

        public void ImprimeDatos(Alumno[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                MuestraNombre(alumnos[i].Nombre);
                MuestraNotas(alumnos[i].Notas);
                MuestraPromedioYMayorNota(alumnos[i]);
            }
        }


    }
}
