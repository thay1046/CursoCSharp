using CursoCSharp.fundamentos;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

#main
namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //crtl + D duplica a ultima coisa escrita
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - fundamentos", Comentarios.Executar },
                 {"Variaveis E Constantes - fundamentos", VariaveisEConstantes.Executar },
                 {"Inferencia - fundamentos", Inferencia.Executar },
            });

            central.SelecionarEExecutar();

            
        }
    }
}