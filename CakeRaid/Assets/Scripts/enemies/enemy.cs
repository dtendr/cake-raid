using UnityEngine;
using System.Collections;

namespace CakeRaid {
	public class Enemy : MonoBehaviour {

		protected bool hasCake, adjacentToCake;
		protected float slowEffect, attackRange;

		//list of status effects, for better checking of enemy states and usage for status animations
		//slowed, shocked, healing, and attracted
		protected List<bool> status_effects;

		protected BehaviorState behavior;

		public Enemy(){

		}
	}
}