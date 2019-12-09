using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(500.0);
            var calculador = new CalculadorDeImpostos();
            
            calculador.RealizarCalculo(orcamento, "ISS");

            calculador.RealizarCalculo(orcamento, "ICMS");

            calculador.RealizarCalculoISS(orcamento);

            calculador.RealizarCalculoICMS(orcamento);

            var iss = new ISS();
            var icms = new ICMS();

            calculador.RealizarCalculoICMS(orcamento, icms);
                       
            calculador.RealizarCalculo(orcamento, iss);

            calculador.RealizarCalculo(orcamento, icms);
        }
    }
}
