using UnityEngine;
using System.Collections;

namespace CakeRaid
{
	abstract class Tower : Entity
    {
		protected bool canFire;

		public Constants.TowerState behavior;

        // Use this for initialization
        void Awake()
        {
            this.behavior = Constants.TowerState.Wait;

            this.canFire = false;
        }

        // Update is called once per frame
        void Update()
        {
            
		}
	}
}