using System;
using Controllers;
using Models;

namespace View
{
    public class FilmeView
    {
        public void addFilme(int idFilme, string titulo, string dataLanc, string sinopse, double valorLoc, int estoque)  
            {
                FilmeController.addFilme(idFilme, titulo, dataLanc, sinopse, valorLoc, estoque);
            }

        public void getFilme(Filme filmes)
            {
                Console.Write(filmes);
            }

        public static void GetClientes()
            {
               FilmeController.GetFilmes().ForEach(filme => Console.WriteLine(filme));
            }        
    }
}