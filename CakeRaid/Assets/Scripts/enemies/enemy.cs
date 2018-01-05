using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CakeRaid
{
	public abstract class Enemy : Entity
    {

		protected bool hasCake, adjacentToCake;
		protected float slowEffect, attackRange;

		//list of status effects, for better checking of enemy states and usage for status animations
		//slowed, shocked, healing, and attracted
		protected List<bool> status_effects;

		public Constants.EnemyState behavior;


        private int destPoint = 0;

        private Transform eTransform;
        Vector2 pos;


        // Use this for initialization
        void Awake()
        {
            this.behavior = Constants.EnemyState.Spawn;

            this.hasCake = false;
            this.adjacentToCake = false;

            this.slowEffect = 1.0f;
            this.attackRange = 1.0f;
        }

        void MovetoNextNode()
        {
           // if (points.Length == 0)
            //    return;


           // Vector2 dir = target.pos - this.pos;
            //Vector2.Distance() 
        }
	}
}