using UnityEngine;
using System.Collections;

namespace CakeRaid
{
	public abstract class Entity : MonoBehaviour
    {

		private bool isActive;
		private int startHealth, currHealth, damage;
		private float speed;

		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}

		public int StartHealth
		{
			get { return startHealth; }
			set { startHealth = value; }
		}

		public int CurrentHealth
		{
			get { return currHealth; }
			set { currHealth = value; }
		}

		public int Damage
		{
			get { return damage; }
			set { damage = value; }
		}

		public float Speed
		{
			get { return speed; }
			set { speed = value; }
		}
	}
}