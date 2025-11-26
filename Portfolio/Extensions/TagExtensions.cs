using Portfolio.Models;

namespace Portfolio.Extensions
{
    public static class TagExtensions
    {
        // Récupère le nom affiché (ex: "C#" au lieu de "CSharp")
        public static string ToFriendlyString(this TechTag tag) => tag switch
        {
            TechTag.CSharp => "C#",
            TechTag.DotNet => ".NET 8/9",
            TechTag.Blazor => "Blazor WASM",
            TechTag.Flutter => "Flutter",
            TechTag.API => "API REST",
            TechTag.Sql => "SQL Server",
            // Par défaut, on renvoie le nom de l'enum
            _ => tag.ToString()
        };

        // (Bonus) Récupère une couleur pour le badge CSS
        public static string ToColorClass(this TechTag tag) => tag switch
        {
            TechTag.CSharp or TechTag.DotNet or TechTag.Blazor => "badge-purple", // Tes technos principales
            TechTag.Flutter => "badge-teal",
            TechTag.API => "badge-green",
            TechTag.Python => "badge-yellow",
            TechTag.Sql => "badge-blue",
            _ => "badge-gray"
        };
    }
}
