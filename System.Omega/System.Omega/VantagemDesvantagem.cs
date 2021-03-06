using System;
using System.Omega.Interface;

namespace System.Omega
{
    public class VantagemDesvantagem : IVantagemDesvantagem
    {
        public VantagemDesvantagem(string nome, int valor, string descricao = "")
        {
            Nome = nome;
            Valor = valor;
            Descricao = descricao;
            CustoXP = Math.Abs(valor) * 10;
        }
        public int Valor { get; }
        public string Nome { get; }
        public int CustoXP { get; }
        public string Descricao { get; }
    }
}