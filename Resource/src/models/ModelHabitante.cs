namespace INEGI.src.models
{
    public class ModelHabitante
    {
        public enum Genero
        {
            masculino,
            femenino,
            otro
        }
        public string? nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Genero genero { get; set; }
        public int idVivienda { get; set; }
    }
}