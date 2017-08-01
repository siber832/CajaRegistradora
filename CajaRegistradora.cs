using System;

namespace CajaRegistradora {
    public class CajaRegistradora {
        
        private double money = 0;
    
        public int[] makeABuy(double price, double given) {
            money += price;
            if (money > 200) {
                MaximumAchieved(EventArgs.Empty);
            }
            return returnAsCoinsAndBills(given - price);
        }
        
        public event EventHandler Achieved;

        protected void MaximumAchieved(EventArgs e) {
            EventHandler copyAchieved = Achieved;
            if (copyAchieved != null)
                copyAchieved(this, e);
        }
        
        private int[] returnAsCoinsAndBills(double quantity) {
            int[] returnValues = new int[14];
            double[] values = CoinsAndBills.getValues();
            for (int i = 13; quantity > 0 && i >= 0;) {
                if (quantity >= values[i]) {
                    returnValues[i] += 1;
                    quantity -= values[i];
                } else {
                    i--;
                }
            }
            return returnValues;
        }

        public void changeTo200() {
            money = 200;
            Console.WriteLine("Cambio a 200.");
        }
    }

    public delegate void EventHandler(object sender, EventArgs args);

}