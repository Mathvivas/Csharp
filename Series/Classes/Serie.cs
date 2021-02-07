namespace Series.Classes
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero genero { get; set; }   
        private string titulo { get; set; }
        private string descricao { get; set; }
        private int ano { get; set; }
    }
}