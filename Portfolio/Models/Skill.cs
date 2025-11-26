namespace Portfolio.Models
{
    public class Skill
    {
        public string Title { get; set; } = string.Empty;
        public string IconPath { get; set; } = string.Empty; // ex: "./assets/images/shopping_cart.svg"
        public List<string> Details { get; set; } = new List<string>();
    }
}
