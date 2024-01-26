using Back_end.Entidades;

namespace Back_end.Repositorios
{
    public class repositorioProducto: interfazProducto
    {
        private readonly ILogger<repositorioProducto> lugger;
        private List<producto> catalogo;

        public repositorioProducto(ILogger<repositorioProducto> lugger) {
            catalogo = new List<producto>()
            {
                new producto("Osteoartrit", 1, "Medicamento para artitis, artrosis y osteoporosis", 30000, 60, 2, "Kg", 1),
                new producto("Paracetamol", 2, "Medicamento convencional para dolores de cabeza", 4000, 0, 250, "mg", 1),
                new producto("Coca-Cola light", 3, "Refrescante bebida sin azucar y con sabor liviano", 1200, 10, 591, "ml", 2),
                new producto("Monster Energy", 4, "Bebida energética favorita de la gente", 2000, 0, 990, "ml", 2),
                new producto("Clorfenamina maleato", 5, "Medicamento anti-inflamatorio", 5000, 5, 100, "mg", 1),
                new producto("Salbutamol", 6, "Medicamento para combatir la bronquitis", 7500, 0, 150, "cm³", 1),
                new producto("Pepto bismol", 7, "Base para combatir la acidez estomacal", 12000, 15, 200, "ml", 1)
        };
            this.lugger = lugger;
        }

        public producto buscarProducto(int id)
        {
            for(int i = 0; i < catalogo.Count; i++)
            {
                if (catalogo[i].ID == id)
                {
                    lugger.LogInformation($"Artículo con nombre {catalogo[i].nombre} encontrado");
                    return catalogo[i];
                }
            }
            lugger.LogWarning($"No fue encontrado ningún producto con la id {id}");
            return null;
        }

        public List<producto> getProductos()
        {
            lugger.LogInformation($"Mostrando productos: ");
            return catalogo;
        }

    }
}
