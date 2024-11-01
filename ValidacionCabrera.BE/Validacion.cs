using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacionCabrera.BE
{
    public class Validacion
    {
        //Devuelve un valor boolean en base a si la patente ingresada es válida o no
        public bool ValidarPatente(string patente) 
        {
            if (string.IsNullOrEmpty(patente)) 
            { 
                return false; 
            }
            //Si el textbox patente esta vacio o es nulo devuelve false

            
            
            if (patente.Length == 6)
            {
                if(Char.IsLetter(patente, 0) && Char.IsLetter(patente, 1) && Char.IsLetter(patente, 2))
                {
                    if(Char.IsDigit(patente, 3) && Char.IsDigit(patente, 4) && Char.IsDigit(patente, 5))
                    {
                        return true;
                    }
                }
            }

            if (patente.Length == 7)
            {
                if (Char.IsLetter(patente, 0) && Char.IsLetter(patente, 1))
                {
                    if (Char.IsDigit(patente, 2) && Char.IsDigit(patente, 3) && Char.IsDigit(patente, 4))
                    {
                        if (Char.IsLetter(patente, 5) && Char.IsLetter(patente, 6))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        

            
            
        }

        public string DevolverDNI(MaskedTextBox maskedTextBox)
        {
            
                
            if (maskedTextBox.Text.Length != 13)
            {
                return "CUIL Inválido";
            }   
            
            string texto;
            texto = maskedTextBox.Text.Substring(3, 8);
            return texto;

        }
    }
}