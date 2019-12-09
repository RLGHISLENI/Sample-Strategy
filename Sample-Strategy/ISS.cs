namespace ConsoleApplication1
{

    public class ISS : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6;
        }

        public double CalcularISS(Orcamento orcamento)
        {
            return Calcular(orcamento);
        }


    }
}
