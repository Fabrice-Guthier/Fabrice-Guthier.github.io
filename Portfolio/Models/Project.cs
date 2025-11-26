namespace Portfolio.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // IT, Formation, etc.
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; // Le texte caché

        // Optionnel : si tu veux ajouter des détails plus tard
        public string SubTitle { get; set; } = string.Empty;
        public List<TechTag> Tags { get; set; } = new();
    }
}