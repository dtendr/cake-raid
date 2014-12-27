using System.Collections;

namespace CakeRaid {
	public class Constants {

		#region Enumerations

		//Game states
		public enum GameState { Menu, Instructions, Credits, Game, Paused, GameOver_Lose, GameOver_Win }

		//Construct enumerations
		public enum TowerType { Rad, Shock, Fire, Light }
		public enum TrapType { Acid, Flypaper, Zapper, Snare }

		//Enemy enumerations
		public enum EnemyType { Ant, Spider, Beetle, Bee, Wasp, Dragonfly, Ladybug, SpiderBoss }
		public enum EnemyState { Spawn, FollowPath, MoveToTower, MoveFromTower, AttackTower, AttackTrap, Death, Despawn }
		public enum StatusType { Slowed, Shocked, Healing, Attracted }

		//Tower enumeration
		public enum TowerState { Fire, Search, Wait, Upgrade }
		
		#endregion Enumerations

		//Starting values for game loop
		public static int MAX_CAKE_HEALTH = 5 /*base is 5*/, START_MONEY = 850; /*base is 850*/

		#region Tower

		//Tower health values
		public static int RAD_TOWER_HEALTH = 400;
		public static int SHOCK_TOWER_HEALTH = 800;
		public static int FIREBALL_TOWER_HEALTH = 800;
		public static int LIGHT_TOWER_HEALTH = 1200;

		#endregion Tower

		#region Enemy

		#region Specific enemy type values

		//Ant
		public static int ANT_HEALTH = 10, ANT_DAMAGE = 1;
		public static float ANT_SPEED = 1.6f;

		//Spider
		public static int SPIDER_HEALTH = 25, SPIDER_DAMAGE = 2;
		public static float SPIDER_SPEED = 1.0f;

		//Beetle
		public static int BEETLE_HEALTH = 50, BEETLE_DAMAGE = 1;
		public static float BEETLE_SPEED = 0.7f;

		//Bee
		public static int BEE_HEALTH = 10, BEE_DAMAGE = 2;
		public static float BEE_SPEED = 1.6f;

		//Wasp
		public static int WASP_HEALTH = 25, WASP_DAMAGE = 4;
		public static float WASP_SPEED = 1.6f;

		//Dragonfly
		public static int DRAGONFLY_HEALTH = 20, DRAGONFLY_DAMAGE = 3;
		public static float DRAGONFLY_SPEED = 1.6f;

		//Ladybug
		public static int LADYBUG_HEALTH = 15, LADYBUG_DAMAGE = 0, LADYBUG_HEAL_AMT = 2;
		public static float LADYBUG_SPEED = 1.0f, LADYBUG_HEAL_RADIUS = 150f;

		//Spider Boss
		public static int BOSS_HEALTH = 3000, BOSS_DAMAGE = 2;
		public static float BOSS_SPEED = 0.5f;

		#endregion Specific enemy type values

		#endregion Enemy
	}
}