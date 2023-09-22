using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Usar carpeta de models
using apiSuperMKD.Models;

namespace apiSuperMKD.Clases
{
    public class clsOpeMdo
    {
        modSuperMkD objModMdo = new modSuperMkD();

        #region "Métodos Privados"
        private bool Validar()
        {
            if (objModMdo.tipoClasif != 1 && objModMdo.tipoClasif != 5 && objModMdo.tipoClasif != 10)
            {
                objModMdo.Error = "Tipo de clasificación no válida";
                return false;
            }

            if (objModMdo.subTotal <= 0)
            {
                objModMdo.Error = "Valor del subtotal no válido";
                return false;
            }
            return true;
        }

        private void hallarDscto()
        {
            if (Validar())
            {
                switch (objModMdo.tipoClasif)
                {
                    case 1:     //Preferente
                        if (objModMdo.subTotal < 1000000)
                            objModMdo.porcDscto = 8f;
                        else
                            objModMdo.porcDscto = 15f;
                        break;

                    case 5:     //Especial
                        if (objModMdo.subTotal < 1000000)
                            objModMdo.porcDscto = 5f;
                        else
                            objModMdo.porcDscto = 10f;
                        break;

                    default:    //Ordinario
                        if (objModMdo.subTotal < 1000000)
                            objModMdo.porcDscto = 0f;
                        else
                            objModMdo.porcDscto = 4f;
                        break;
                }
                objModMdo.vrDscto = objModMdo.subTotal * objModMdo.porcDscto / 100f;
            }
        }

        private void hallarDatos()
        {
            if (!Validar())
            {
                hallarDscto();
                objModMdo.vrAPagar = objModMdo.subTotal - objModMdo.vrDscto;
            }
        }
        #endregion
    }
}