namespace INEGI.src.models
{
    public class ModelVivienda
    {
        public enum TipoVivienda
        {
            concreto,
            adobe_antiguo,
            ladrillo,
            madera,
            carton,
            piedra,
            prefabricada,
            material_ecologico,
            paja_ramas_cana,
            adobe_moderno
        }

        public string? direccion { get; set; }
        public TipoVivienda tipovi { get; set; }
        public int idLocalidad { get; set; }
    }
}