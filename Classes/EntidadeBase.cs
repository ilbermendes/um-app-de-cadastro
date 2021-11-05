using System;

namespace RegSeries
{
    public abstract class EntidadeBase
    {
        internal int Id { get;  set; }
        protected string Titulo { get; set; }
        protected int Ano { get; set; }
        protected bool Excluido { get; set; }
    }
}