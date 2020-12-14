namespace CMATRTATICOS.classe
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.07f;
        private static float cotacaoEuro = 6.16f;
        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }
        public static float DolarParaReal(float valorUS){
            return cotacaoDolar * valorUS;
        }

        public static float RealParaEuro(float valorEU){
            return valorEU / cotacaoEuro;
        }
        public static float EuroParaReal(float valorUS){
            return cotacaoEuro * valorUS;
        }
    }
}