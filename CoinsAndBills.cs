namespace CajaRegistradora
{
    public class CoinsAndBills
    {
        private static double[] values = null;

        public static double[] getValues()
        {
            if (values == null) {
                values = new double[] { 0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200 };
            }
            return values;
        }
    }
}