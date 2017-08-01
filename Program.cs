using System;

namespace CajaRegistradora {
    class Program {
        static void Main(string[] args) {
            double[] values = CoinsAndBills.getValues();
            CajaRegistradora caja = new CajaRegistradora();
            caja.makeABuy(180, 200);
            Listener listener = new Listener(caja);
            caja.makeABuy(40, 200);
            listener.Detach();
            int[] valuesReturned = caja.makeABuy(40, 200);
            for (int i=0; i<14; i++) {
                Console.WriteLine(String.Concat("Numero de elementos de valor ", values[i], ":", valuesReturned[i]));
            }
        }
    }
}