using System.Collections;
using System.Collections.Generic;

namespace CakeRaid {
	abstract class Enemy : Entity {

		protected bool hasCake, adjacentToCake;
		protected float slowEffect, attackRange;

		//list of status effects, for better checking of enemy states and usage for status animations
		//slowed, shocked, healing, and attracted
		protected List<bool> status_effects;

		public Constants.EnemyState behavior;

		public Enemy(){

		}
	}
}