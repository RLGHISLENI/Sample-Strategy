namespace ConsoleApplication1
{
    public class ICMS : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        // Errado
        public double CalcularICMS(Orcamento orcamento)
        {
            return Calcular(orcamento);
        }

    }
}
