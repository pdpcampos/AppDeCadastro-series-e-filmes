using System;

namespace DIO.series
{
    public class filme : entidadeBase
    {
        private string titulo;

        //atributo 

        private genero Genero { get; set; }

        private string  Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }
        public bool Excluido { get; set;}

        // Métodos

        public filme (int id, genero genero, string Titulo, string Descricao, int Ano)
        {
            this.id = id;
			this.Genero = genero;
			this.Titulo = titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
            
            }

        public override string ToString()
        {
            string  retorno = "";
            retorno += "Gênero" +  this.Genero + Environment.NewLine;
            retorno += "Titulo" + this.Titulo +  Environment.NewLine;
            retorno += "descrição" + this.Descricao + Environment.NewLine;
            retorno += "Ano de inicio" + this.Ano + Environment.NewLine;
            retorno += "excluido:" + this.Excluido;
            return retorno; 

            }

            public string retornaTitulo()
            {
                return this.Titulo;
            }

            public int retornaId()
            {
                return this.id;
            }

            public bool retornaEcluido()
            {
                return  this.Excluido;
            }

            public void Excluir()
            {
           
            this.Excluido = true; 
            }

            
    }
}