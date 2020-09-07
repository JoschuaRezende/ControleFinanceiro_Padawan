using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.Financeiro.Negocio.Banco
{
    public class Banco<T>
    {

        private const string caminho = @"C:\Users\joschua.silva\Documents\GitHub\JoschuaRezende\ControleFinanceiro_Padawan\Banco\";
        private const string arquivoNome = "BancoFinanceiro.db";
        public List<T> Listar()
        {
            using (var db = new LiteDatabase(caminho + arquivoNome))
            {
                return db.GetCollection<T>().FindAll().ToList();
            }
        }

        public bool Add(T obj)
        {
            using (var db = new LiteDatabase(caminho + arquivoNome))
            {
                try
                {
                    db.GetCollection<T>().Insert(obj);

                }
                catch (System.Exception)
                {

                    return false;
                }
                return true;
            }

        }

        public void Remove()
        {
            using (var db = new LiteDatabase(caminho + arquivoNome))
            {
               // return db.GetCollection<T>().FindAll().ToList();
            }

        }

    }
}