using System;

namespace ConsoleApplication1
{
    public class CalculadorDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, string imposto)
        {
            Console.WriteLine("Modo errado (Nível iniciante)");
            if ("ICMS".Equals(imposto))
            {
                var icms = orcamento.Valor * 0.1;
                Console.WriteLine(string.Format("Icms: {0}", icms));
            }
            else if ("ISS".Equals(imposto))
            {
                var iss = orcamento.Valor * 0.06;
                Console.WriteLine(string.Format("Iss: {0}", iss));
            }
            Console.ReadKey();
            
            Console.WriteLine("Modo um pouquinho melhor (menos pior)");
            if ("ICMS".Equals(imposto))
            {
                var icms = new ICMS().CalcularICMS(orcamento);
                Console.WriteLine(string.Format("Icms: {0}", icms));
            }
            else if ("ISS".Equals(imposto))
            {
                var iss = new ISS().CalcularISS(orcamento);
                Console.WriteLine(string.Format("Iss: {0}", iss));
            }
            Console.ReadKey();
        }

        public void RealizarCalculoICMS(Orcamento orcamento)
        {
            Console.WriteLine("Só calcula o Icms (Modo Convencional)");
            var icms = orcamento.Valor * 0.1;
            Console.WriteLine(string.Format("Icms: {0}", icms));
            Console.ReadKey();
        }

        public void RealizarCalculoISS(Orcamento orcamento)
        {
            Console.WriteLine("Só calcula o Iss (Modo Convencional)");
            var iss = orcamento.Valor * 0.1;
            Console.WriteLine(string.Format("Iss: {0}", iss));
            Console.ReadKey();
        }

        public void RealizarCalculoICMS(Orcamento orcamento, ICMS imposto)
        {
            Console.WriteLine("Imposto ICMS (Errado)");
            Console.WriteLine(imposto.CalcularICMS(orcamento));
            Console.ReadKey();
        }

        public void RealizarCalculoISS(Orcamento orcamento, ISS imposto)
        {
            Console.WriteLine("Imposto ISS (Errado)");
            Console.WriteLine(imposto.CalcularISS(orcamento));
            Console.ReadKey();
        }

        public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            Console.WriteLine("Cálculo de Imposto - Correto");
            Console.WriteLine(imposto.Calcular(orcamento));
            Console.ReadKey();
        }
    }
}
