using LiteDB;

namespace Padawan.Financeiro.Negocio.Models
{
    public class Categoria
    {
        private string text;

        public Categoria()
        {
        }

        public Categoria(string text)
        {
            this.text = text;
        }

        public string Descricao { get; set; }
    }
}