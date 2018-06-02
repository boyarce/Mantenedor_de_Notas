using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedorDeNotas.lib.validator
{
    public class StringValidator {

        private static StringValidator stringValidator = null;

        private StringValidator() {
        }

        public static StringValidator Instance {

            get{
                if (stringValidator == null) {
                    stringValidator = new StringValidator();
                }
                return stringValidator;
            }
        }

        public bool isEmpty(string value) {

            bool resultado = false;

            if (value == null || "".Equals(value) ) {
                resultado = true;
            }

            return resultado;
        }

        public bool betweenOneAndEightyText(string value) {
            bool resultado = false;

            if (!isEmpty(value) && (value.Length > 1 &&
                value.Length < 80))
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
