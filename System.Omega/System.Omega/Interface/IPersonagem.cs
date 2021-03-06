using System.Collections.Generic;
using System.Omega.Enum;

namespace System.Omega.Interface
{
    public interface IPersonagem
    {
        string Nome { get; set; }
        EscalaDePoder Escala { get; set; }
        List<ICaracteristica> Caracteristicas { get; set; }
        List<IVantagemDesvantagem> VantagemDesvantagens { get; set; }
        int PontosDeVida { get; set; }
        int PontosDeMagia { get; set; }
        int PontosDeExperiencia { get; set; }
        bool Vivo { get; }
        int ObterTotalDePontos();
        int ObterCaracteristica(NomeCaracteristica nomeCaracteristica);
    }
}