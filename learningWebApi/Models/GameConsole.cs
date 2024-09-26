namespace Models
{
    public class GameConsole // Renomeado para evitar conflito com System.Console
    {
        public GameConsole()
        {
        }

        public string? Nome { get; set; }
        public double Valor { get; set; } // Corrigido para "Valor"
    }
}
