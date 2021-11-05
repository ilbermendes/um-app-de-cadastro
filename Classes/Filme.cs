using System;

namespace RegSeries
{
    public class Filme : EntidadeBase
    {
        static int contadorId = 0;

        private string Pais {get; set; }

        public Filme(string titulo, int ano, string pais)
        {
            this.Id = 0 + contadorId;
            contadorId++;
            this.Titulo = titulo;
            this.Ano = ano;
            this.Pais = pais;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Titulo: {this.Titulo}" + Environment.NewLine;
            retorno += $"Ano: {this.Ano}" + Environment.NewLine;
            retorno += $"País: {this.Pais}" + Environment.NewLine;
            retorno += $"Excluído: {this.Excluido}"; 
            return retorno;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaAno()
        {
            return this.Ano;
        }

        public string RetornaPais()
        {
            return this.Pais;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
        
        public void AtualizaFilme(string titulo, int ano, string pais)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Pais = pais;
        }
    }
}