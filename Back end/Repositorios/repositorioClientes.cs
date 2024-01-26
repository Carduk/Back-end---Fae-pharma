using Back_end.Entidades;

namespace Back_end.Repositorios
{
    public class repositorioClientes: interfazCliente
    {
        private List<cliente> clientes;
        public repositorioClientes()
        {
            clientes = new List<cliente>()
            {
                new cliente(){ rut = "1.111.111-1", nombre = "Viz", apellido = "Avalon",fono = 999999999, correo = "carduks.a@gmail.com", privilegios = 1, password = "1234" },
                new cliente(){nombre = "Edwin", apellido = "Chumanzo", correo = "kike21@gmail.com", fono = 999999999, rut = "2.222.222-2", privilegios = 0, password = "popin" },
                new cliente(){nombre = "Scarlett", apellido = "Zuñiga", correo = "cuttiepatotie@gmail.com", fono = 999999999, rut = "3.333.333-3", privilegios = 0, password = "5678" }
            };
        }

        public cliente comprobarCliente(string run)
        { List<cliente> info = clientes;
            for (int i = 0; i < info.Count; i++)
            {
                if (run == info[i].rut)
                {
                    return info[i];
                }
            }
            return null;
        }

        public List<cliente> verClientes()
        {
            return clientes;
        }

        
    }
}
