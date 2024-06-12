using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App03
{
    public class EventPublisher
    {
        private string theVal;

        //Para crear el evento, se tiene que basar en el delegate que ya se creo
        // anteriormente
        public event MiEventoHandler valueChanged;

        public event EventHandler<MiEventoArgs> miEvento;

        public string val
        {
            set
            {
                this.theVal = value;
                this.valueChanged(theVal);
                this.miEvento(this, new MiEventoArgs {data = theVal});
            }
        }
    }
}
