using System;

namespace RegSeries
{
    public class Serie : EntidadeBase
    {
        private string Pais { get; set; }

        public Serie(int id, string titulo, int ano, string pais)
        {
            this.Id = id;
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

        public void AtualizaSerie(string titulo, int ano, string pais)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Pais = pais;
        }

    }
}