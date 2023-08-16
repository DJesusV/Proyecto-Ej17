using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3
{
    public partial class InterfazPostres : Form
    {
        Postres postre = new Postres();
        public InterfazPostres()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAltaPostre_Click(object sender, EventArgs e)
        {
            string nombrePostre = textBox1.Text;
            if (nombrePostre != "")
            {
                LinkedList<string> ingredientes = new LinkedList<string>();
                postre.AgregarPostre(nombrePostre, ingredientes);
                comboBoxPostres.Items.Add(nombrePostre);
                MessageBox.Show("Postre agregado.");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("El campo Postres no puede estar vacío");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBajaPostre_Click(object sender, EventArgs e)
        {
            if (comboBoxPostres.SelectedIndex >= 0)
            {
                string nombrePostre = comboBoxPostres.SelectedItem.ToString();
                postre.EliminarPostre(nombrePostre);
                MessageBox.Show("Postre eliminado.");
                comboBoxPostres.Items.RemoveAt(comboBoxPostres.SelectedIndex);
                comboBoxIngredientes.Items.Clear();
            }
        }

        private void comboBoxPostres_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIngredientes.Items.Clear();
            if (comboBoxPostres.SelectedIndex >= 0)
            {
                string nombrePostre = comboBoxPostres.SelectedItem.ToString();
                int indice = postre.BuscarIndice(nombrePostre);
                LinkedList<string> ingredientes = postre.postres[indice].Item2; string textoIngredientes = "";
                foreach (string ingrediente in ingredientes)
                {
                    comboBoxIngredientes.Items.Add(ingrediente);
                }

            }
        }

        private void comboBoxIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsertarIngredientes_Click(object sender, EventArgs e)
        {
            //string nombrePostre = comboBoxPostres.SelectedItem.ToString();
            string nombrePostre = comboBoxPostres.SelectedItem.ToString();
            string nombreIngrediente = textBox1.Text;
            if (nombreIngrediente != "")
            {
                if (nombrePostre != "")
                {
                    int indice = postre.BuscarIndice(nombrePostre);
                    LinkedList<string> ingredientes = postre.postres[indice].Item2;
                    ingredientes.AddLast(nombreIngrediente);
                    comboBoxIngredientes.Items.Add(nombreIngrediente);
                    MessageBox.Show("Ingrediente agregado.");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un postre.");
                }
            }
            else
            {
                MessageBox.Show("El campo ingrediente no puede estar vacío");
            }
        }

        private void buttonMostrarIngredientes_Click(object sender, EventArgs e)
        {
            ListIngredientes.Items.Clear();
            comboBoxIngredientes.Text = "";
            // Limpiar el text box 
            if (comboBoxPostres.SelectedIndex >= 0)
            {
                string nombrePostre = comboBoxPostres.SelectedItem.ToString();
                int indice = postre.BuscarIndice(nombrePostre);
                LinkedList<string> ingredientes = postre.postres[indice].Item2; string textoIngredientes = "";
                // Variable para concatenar los ingredientes 
                int contador = 0;
                foreach (string ingrediente in ingredientes)
                {
                    contador = contador + 1;
                    ListIngredientes.Items.Add(ingrediente);
                    List<string> nombresPostres = new List<string>(ingredientes); nombresPostres.Sort();
                }
                if (contador == 0)
                {
                    ListIngredientes.Items.Add("--Este postre no tiene ingredientes--");
                }
            }
        }

        private void tbMostrarIngredientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminarIngredientes_Click(object sender, EventArgs e)
        {

            if (comboBoxIngredientes.SelectedIndex >= 0 && comboBoxPostres.SelectedIndex >= 0)
            {
                string nombrePostre = comboBoxPostres.SelectedItem.ToString();
                string nombreIngrediente = comboBoxIngredientes.SelectedItem.ToString();
                int indice = postre.BuscarIndice(nombrePostre);
                LinkedList<string> ingredientes = postre.postres[indice].Item2;
                ingredientes.Remove(nombreIngrediente);
                comboBoxIngredientes.Items.Remove(nombreIngrediente);
                int contador = 0;
                MessageBox.Show("Ingrediente eliminado.");
                foreach (object s in comboBoxIngredientes.Items)
                {
                    contador = contador + 1;
                }
                if (contador == 0)
                {
                    MessageBox.Show("Todos los ingredientes han sido eliminados.");
                    comboBoxIngredientes.Items.Clear();
                    comboBoxIngredientes.SelectedText = "";
                    comboBoxIngredientes.Refresh();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ListIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
