using System.Drawing;

namespace GeoMente
{
    public static class Theme
    {
        // Backgrounds
        public static readonly Color Background = Color.White; // #FFFFFF - Branco puro
        public static readonly Color Surface = ColorTranslator.FromHtml("#F8F9FA"); // Cinza muito claro para cards/painéis
        public static readonly Color SurfaceVariant = ColorTranslator.FromHtml("#E9ECEF"); // Cinza claro para elementos secundários

        // Textos
        public static readonly Color Text = ColorTranslator.FromHtml("#212529"); // Cinza muito escuro, quase preto
        public static readonly Color TextSecondary = ColorTranslator.FromHtml("#6C757D"); // Cinza médio
        public static readonly Color TextMuted = ColorTranslator.FromHtml("#ADB5BD"); // Cinza claro

        // Cores de Ação
        public static readonly Color Primary = ColorTranslator.FromHtml("#4F46E5"); // Índigo moderno
        public static readonly Color PrimaryHover = ColorTranslator.FromHtml("#4338CA"); // Índigo escuro
        public static readonly Color Secondary = ColorTranslator.FromHtml("#EC4899"); // Rosa vibrante
        public static readonly Color SecondaryHover = ColorTranslator.FromHtml("#DB2777"); // Rosa escuro

        // Status
        public static readonly Color Success = ColorTranslator.FromHtml("#10B981"); // Verde moderno
        public static readonly Color Error = ColorTranslator.FromHtml("#EF4444"); // Vermelho moderno
        public static readonly Color Warning = ColorTranslator.FromHtml("#F59E0B"); // Laranja/amarelo
        public static readonly Color Info = ColorTranslator.FromHtml("#3B82F6"); // Azul moderno

        // Bordas e Sombras
        public static readonly Color Border = ColorTranslator.FromHtml("#DEE2E6"); // Cinza claro para bordas

        // Fonts (usando Segoe UI para aparência moderna)
        public static Font GetTitleFont(float size = 24) => new Font("Segoe UI", size, FontStyle.Bold);
        public static Font GetTextFont(float size = 12) => new Font("Segoe UI", size, FontStyle.Regular);
        public static Font GetButtonFont(float size = 14) => new Font("Segoe UI", size, FontStyle.Bold);
    }
}
