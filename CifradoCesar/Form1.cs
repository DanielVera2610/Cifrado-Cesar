using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifradoCesar
{
    public partial class Form1 : Form
    {
        int[,] Matriz;
        string strCripto;
        Cesar miCesar = new Cesar();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvMatriz.ReadOnly = true;
            dtgvMatriz.AllowUserToAddRows = false;
            dtgvMatriz.AllowUserToDeleteRows = false;
            dtgvMatriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                miCesar.Mcla = Mncltxt.Text.ToUpper().Replace(" ", "");
                miCesar.Llave = int.Parse(LlaveTxt.Text);

                Matriz = new int[4, miCesar.Mcla.Length];

                if (radioCifrar.Checked == true)
                {
                    strCripto = miCesar.Cifrar_Descifrar(Matriz, true);
                }
                else
                {
                    strCripto = miCesar.Cifrar_Descifrar(Matriz, false);
                }
                CriptogramaTxt.Text = strCripto;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void MostrarDatos()
        {
            dtgvMatriz.ColumnCount = Matriz.GetLength(1);
            dtgvMatriz.RowCount = Matriz.GetLength(0) + 2;

            for (int x = 0; x < miCesar.Mcla.Length; x++)
            {
                dtgvMatriz.Rows[0].Cells[x].Value = miCesar.Mcla[x];
            }
            for (int r = 0; r < Matriz.GetLength(0); r++)
            {
                for (int c = 0; c < Matriz.GetLength(1); c++)
                {
                    dtgvMatriz.Rows[r + 1].Cells[c].Value = Matriz[r,c];
                }
            }
          
        }
    }
}
