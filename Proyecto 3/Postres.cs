using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3
{
    public class Postres
    {
        public (string, LinkedList<string>)[] postres;

        public Postres()
        {
            // Crear un arreglo con capacidad para 10 postres
            postres = new (string, LinkedList<string>)[10];

            // Dejar el resto del arreglo vacío
            for (int i = 2; i < 10; i++)
            {
                postres[i] = (null, null);
            }
        }

        public int BuscarIndice(string nombrePostre)
        {
            // Recorrer el arreglo desde el principio hasta el final
            for (int i = 0; i < postres.Length; i++)
            {
                // Si el elemento del arreglo es nulo, se termina la búsqueda
                if (postres[i].Item1 == null)
                {
                    break;
                }

                // Si el elemento del arreglo tiene el nombre buscado, se devuelve su índice
                if (postres[i].Item1 == nombrePostre)
                {
                    return i;
                }
            }

            // Si no se encontró el nombre buscado, se devuelve -1
            return -1;
        }
        public void AgregarPostre(string nombrePostre, LinkedList<string> ingredientes)
        {
            // Recorrer el arreglo desde el principio hasta el final
            for (int i = 0; i < postres.Length; i++)
            {
                // Si el elemento del arreglo es nulo, se asigna la tupla con el nombre del postre y la lista de ingredientes
                if (postres[i].Item1 == null)
                {
                    postres[i] = (nombrePostre, ingredientes);
                    break;
                }
            }
        }
        // Método que elimina un postre del arreglo dado su nombre
        public void EliminarPostre(string nombrePostre)
        {
            // Buscar el índice del postre en el arreglo
            int indice = BuscarIndice(nombrePostre);

            // Si se encontró el índice, se asigna un valor nulo al elemento del arreglo
            if (indice != -1)
            {
                postres[indice] = (null, null);
            }

            // Reordenar el arreglo para que no queden espacios vacíos entre los elementos
            for (int i = indice; i < postres.Length - 1; i++)
            {
                // Intercambiar los elementos del arreglo si el siguiente no es nulo
                if (postres[i + 1].Item1 != null)
                {
                    postres[i] = postres[i + 1];
                    postres[i + 1] = (null, null);
                }
                else
                {
                    // Terminar el ciclo si el siguiente es nulo
                    break;
                }
            }
        }
        public void AgregarIngrediente(string nombrePostre, string nombreIngrediente)
        {
            int indice = BuscarIndice(nombrePostre);

            LinkedList<String> ingredientes = postres[indice].Item2;
            ingredientes.AddLast(nombreIngrediente);
        }

        public void EliminarIngrediente(string nombrePostre, string nombreIngrediente)
        {
            int indice = BuscarIndice(nombrePostre);
            LinkedList<String> ingredientes = postres[indice].Item2;
            ingredientes.Remove(nombreIngrediente);
            

        }
    }
}
