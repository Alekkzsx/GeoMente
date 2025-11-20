using System.Drawing;

namespace GeoMente
{
    public static class Theme
    {
        // Color Palette
        public static readonly Color Primary = ColorTranslator.FromHtml("#6C63FF"); // Vibrant Purple
        public static readonly Color Secondary = ColorTranslator.FromHtml("#FF6584"); // Soft Red/Pink
        public static readonly Color Background = ColorTranslator.FromHtml("#2A2E37"); // Dark Grey/Blue
        public static readonly Color Surface = ColorTranslator.FromHtml("#3D4250"); // Lighter Grey for cards/panels
        public static readonly Color Text = ColorTranslator.FromHtml("#FFFFFF"); // White
        public static readonly Color TextSecondary = ColorTranslator.FromHtml("#A0A0A0"); // Grey
        public static readonly Color Success = ColorTranslator.FromHtml("#00C851"); // Green
        public static readonly Color Error = ColorTranslator.FromHtml("#FF4444"); // Red
        public static readonly Color Warning = ColorTranslator.FromHtml("#FFBB33"); // Orange

        // Fonts (using system fonts for simplicity, but styled)
        public static Font GetTitleFont(float size = 24) => new Font("Segoe UI", size, FontStyle.Bold);
        public static Font GetTextFont(float size = 12) => new Font("Segoe UI", size, FontStyle.Regular);
        public static Font GetButtonFont(float size = 14) => new Font("Segoe UI", size, FontStyle.Bold);
    }
}
