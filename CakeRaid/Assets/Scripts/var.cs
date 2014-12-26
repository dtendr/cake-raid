using System.Collections;

namespace cakeRaid{
	public class var {

		//enumerations

		//game states
		public enum GameState { Menu, Instructions, Credits, Game, Paused, GameOver_Lose, GameOver_Win }

		public enum EnemyType { Ant, Spider, Beetle, Bee, Wasp, Dragonfly, Ladybug, SpiderBoss }
		public enum TowerType { Rad, Shock, Fire, Light }
		public enum TrapType { Acid, Flypaper, Zapper, Snare }

		#region Enemy
		public enum statusType {Slowed, Shocked, Healing, Attracted}

		#region Specific enemy type values
		//Ant
		public static int ANT_HEALTH = 10;
		public static int ANT_DAMAGE = 1;
		public static float ANT_SPEED = 1.6f;

		//Spider
		public static int SPIDER_HEALTH = 25;
		public static int SPIDER_DAMAGE = 2;
		public static float SPIDER_SPEED = 1.0f;

		//Beetle
		public static int BEETLE_HEALTH = 50;
		public static int BEETLE_DAMAGE = 1;
		public static float BEETLE_SPEED = 0.7f;

		//Bee
		public static int BEE_HEALTH = 10;
		public static int BEE_DAMAGE = 2;
		public static float BEE_SPEED = 1.6f;

		//Wasp
		public static int WASP_HEALTH = 25;
		public static int WASP_DAMAGE = 4;
		public static float WASP_SPEED = 1.6f;

		//Dragonfly
		public static int DRAGONFLY_HEALTH = 20;
		public static int DRAGONFLY_DAMAGE = 3;
		public static float DRAGONFLY_SPEED = 1.6f;

		//Ladybug
		public static int LADYBUG_HEALTH = 15;
		public static int LADYBUG_DAMAGE = 0;
		public static int LADYBUG_HEAL_AMT = 2;
		public static float LADYBUG_SPEED = 1.0f;
		public static float LADYBUG_HEAL_RADIUS = 150f;

		//Spider Boss
		public static int BOSS_HEALTH = 3000;
		public static int BOSS_DAMAGE = 2;
		public static float BOSS_SPEED = 0.5f;
		#endregion Specific enemy type values

		#endregion Enemy
	}
}