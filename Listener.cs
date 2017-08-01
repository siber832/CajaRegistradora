using System;

namespace CajaRegistradora
{
    public class Listener
    {
        private CajaRegistradora caja;

        public Listener(CajaRegistradora caja) {
            this.caja = caja;
            this.caja.Achieved += new EventHandler(ChangeTo200);
        }

        private void ChangeTo200(object sender, EventArgs e) {
            Console.WriteLine("He sido llamado.");
            caja.changeTo200();
        }

        public void Detach() {
            caja.Achieved -= new EventHandler(ChangeTo200);
            caja = null;
        }
    }
}