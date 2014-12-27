using System.Collections;

namespace CakeRaid {
	abstract class Tower : Entity{

		protected bool canFire;

		public Constants.TowerState behavior;

		public Tower(){

		}
	}
}