﻿using SpaceWar.Game.Play.Enemy.General;

namespace SpaceWar.Game.Play.Enemy.Enemy3 {

	public class Enemy3Spawner : AbstractSpawner {

		public override int MinEnemyCount => 1;
		public override int MaxEnemyCount => 4;
		public override int PointsRequiredForSpawning => 401;
		public override int PointsForKilling => 20;
		public override float SpawnInterval => 2f;

		protected override AbstractEnemy CreateEnemyInstance() {
			return new Enemy3(PointsForKilling);
		}
	}

}
