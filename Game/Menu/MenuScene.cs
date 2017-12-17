﻿using System;
using System.Drawing;
using Framework;
using Framework.Camera;
using Framework.Widget;
using OpenTK;
using SpaceWar.Game.Play;
using Zenseless.Geometry;

namespace SpaceWar.Game.Menu {

	public class MenuScene : Scene {

		public override void OnStart() {
			base.OnStart();

			// Camera
			var camera = new DefaultCameraGameObject();
			camera.Component.ViewportScaling = new Vector2(1f, 1f);
			camera.Component.Position = new Vector2(0f, 0f);
			Spawn(camera);

			// Sinpleplayer button
			var singleplayerButton = new AButton(
				new Box2D(-0.2f, -0.05f, 0.4f, 0.1f),
				"Singleplayer",
				Options.DEFAULT_FONT,
				Brushes.Black,
				Color.Gray,
				() => Framework.Game.Instance.ShowScene(new PlayScene()));
			singleplayerButton.Transform.WorldPosition = new Vector2(0, 0.15f);
			Spawn(singleplayerButton);

			// Coop button
			var coopButton = new BButton(
				new Box2D(-0.2f, -0.05f, 0.4f, 0.1f),
				"CO-OP",
				Options.DEFAULT_FONT,
				Brushes.Black,
				Color.Gray,
				() => Framework.Game.Instance.ShowScene(new PlayScene(2)));
			coopButton.Transform.LocalPosition = new Vector2(0, 0);
			Spawn(coopButton);

			// Quit button
			var quitButton = new CButton(
				new Box2D(-0.2f, -0.05f, 0.4f, 0.1f),
				"Quit",
				Options.DEFAULT_FONT,
				Brushes.Black,
				Color.Gray,
				() => Framework.Game.Instance.Close());
			quitButton.Transform.LocalPosition = new Vector2(0, -0.15f);
			Spawn(quitButton);
		}
	}

	class AButton : Button {

		public AButton(Box2D size, string label, Font font, Brush brush, Color background, Action action) : base(size, label, font, brush, background, action) {
		}
	}

	class BButton : Button {

		public BButton(Box2D size, string label, Font font, Brush brush, Color background, Action action) : base(size, label, font, brush, background, action) {
		}
	}

	class CButton : Button {

		public CButton(Box2D size, string label, Font font, Brush brush, Color background, Action action) : base(size, label, font, brush, background, action) {
		}
	}

}
