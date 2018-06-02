using MantenedorDeNotas.lib.validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedorDeNotas.lib.model
{
    public class Persona
    {
        private int id;
        private string run;
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string correoElectronico;

        public Persona() {
        }

        public Persona(int id, string run, string nombres, string apellidoPaterno, string apellidoMaterno, string correoElectronico)
        {
            this.id = id;
            this.run = run;
            this.nombres = nombres;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.correoElectronico = correoElectronico;
        }

        public int Id {
            get {
                return id;
            }
            set {
                if (value > 0) {
                    id = value;
                }
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }
            set
            {
                StringValidator sv = StringValidator.Instance;
                if (sv.betweenOneAndEightyText(value))
                {
                    nombres = value;
                }
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
            set
            {
                StringValidator sv = StringValidator.Instance;
                if (sv.betweenOneAndEightyText(value))
                {
                    apellidoPaterno = value;
                }
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }
            set
            {
                StringValidator sv = StringValidator.Instance;
                if (sv.betweenOneAndEightyText(value))
                {
                    apellidoMaterno = value;
                }
            }
        }

        public string CorreoElectronico
        {
            get
            {
                return correoElectronico;
            }
            set
            {
                StringValidator sv = StringValidator.Instance;
                if (sv.betweenOneAndEightyText(value))
                {
                    correoElectronico = value;
                }
            }
        }

        public override string ToString()
        {
            return "id: " + id + " run: " + run +
                " nombres:" + nombres +
                "apellidoPaterno: " + apellidoPaterno +
                "apellidoMaterno: " + apellidoMaterno +
                "correoElectronico: " + correoElectronico;
        }
    }
}
