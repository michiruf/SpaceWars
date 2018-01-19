﻿using System.Drawing;

namespace Framework.Utilities {

	/// @see https://stackoverflow.com/questions/3722307/is-there-an-easy-way-to-blend-two-system-drawing-color-values
	public static class ColorBlendExtension {

		/// <summary>Blends the specified colors together.</summary>
		/// <param name="color">Color to blend onto the background color.</param>
		/// <param name="backColor">Color to blend the other color onto.</param>
		/// <param name="amount">How much of <paramref name="color"/> to keep,
		/// “on top of” <paramref name="backColor"/>.</param>
		/// <returns>The blended colors.</returns>
		public static Color Blend(this Color color, Color backColor, double amount) {
			var r = (byte) (color.R * amount + backColor.R * (1 - amount));
			var g = (byte) (color.G * amount + backColor.G * (1 - amount));
			var b = (byte) (color.B * amount + backColor.B * (1 - amount));
			return Color.FromArgb(r, g, b);
		}
	}

}
