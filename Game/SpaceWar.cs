﻿using Framework.Debug;
using Framework.Object;
using SpaceWar.Game.Menu;
using SpaceWar.Game.Play;

namespace SpaceWar.Game {

	internal static class SpaceWar {

		static void Main(string[] args) {
			FrameworkDebugMode.IsEnabled = true;

			var game = new Framework.Game();
			game.RegisterInputProvider(new Keymap());
			game.CreatePrimitiveWindow(VierportAnchor.Horizontal, "SpaceWar");
			game.ShowScene(new MenuScene());
//			game.ShowScene(new PlayScene());
			game.Run();
		}
	}

}
