using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiSuperMkD.Models
{
    public class modSuperMkD
    {
        #region costructor
        public modSuperMkD(int tipoClasif, float subtotal, float porcDscto, float vrDsto, float vrAPagar, string error)
        {
            this.tipoClasif = tipoClasif;
            this.subtotal = subtotal;
            this.porcDscto = porcDscto;
            this.vrDsto = vrDsto;
            this.vrAPagar = vrAPagar;
            Error = error;
        }
        #endregion

        #region Atributos/Propiedades
        public int tipoClasif { get; set; }
        public float subtotal { get; set; }
        public float porcDscto { get; set; }
        public float vrDsto { get; set; }
        public float vrAPagar { get; set; }
        public string Error { get; set; }
        #endregion
    }

}