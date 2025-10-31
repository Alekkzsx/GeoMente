using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GeoMente
{
    public class RoundedButton : Button
    {
        private int _borderRadius = 15;
        private Color _originalBackColor;
        private bool _isHovering = false;

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            _isHovering = true;
            _originalBackColor = this.BackColor;
            // Lighten the back color for hover effect
            this.BackColor = ControlPaint.Light(_originalBackColor, 0.2f);
            Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            _isHovering = false;
            this.BackColor = _originalBackColor;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Do NOT call base.OnPaint(pevent). We are taking over the drawing.
            
            // Get the graphics path for the rounded rectangle
            GraphicsPath grPath = GetRoundedPath(this.ClientRectangle, _borderRadius);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Use the current BackColor (which might be the hover color)
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                // Fill ONLY the path, not the entire rectangle
                pevent.Graphics.FillPath(brush, grPath);
            }

            // Draw the text in the center
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // When the button is resized, update its region to the new rounded shape
            this.Region = new Region(GetRoundedPath(this.ClientRectangle, _borderRadius));
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            // Ensure the radius doesn't exceed half the button's smaller dimension
            int effectiveRadius = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2);
            
            GraphicsPath grPath = new GraphicsPath();

            if (effectiveRadius > 0)
            {
                // Create the rounded rectangle path
                grPath.AddArc(rect.X, rect.Y, effectiveRadius * 2, effectiveRadius * 2, 180, 90);
                grPath.AddArc(rect.Right - (effectiveRadius * 2), rect.Y, effectiveRadius * 2, effectiveRadius * 2, 270, 90);
                grPath.AddArc(rect.Right - (effectiveRadius * 2), rect.Bottom - (effectiveRadius * 2), effectiveRadius * 2, effectiveRadius * 2, 0, 90);
                grPath.AddArc(rect.X, rect.Bottom - (effectiveRadius * 2), effectiveRadius * 2, effectiveRadius * 2, 90, 90);
                grPath.CloseAllFigures();
            }
            else
            {
                // If radius is 0, just add a rectangle
                grPath.AddRectangle(rect);
            }

            return grPath;
        }
    }
}
