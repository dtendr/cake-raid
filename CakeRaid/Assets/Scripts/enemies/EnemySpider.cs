using UnityEngine;
using System.Collections;

namespace CakeRaid
{
	public class EnemySpider : Enemy
    {
        // Use this for initialization
        void Start ()
        {
            this.Speed = Constants.SPIDER_SPEED;
        }
		
		// Update is called once per frame
		void Update ()
        {
            this.MovetoNextNode();
        }
	}
}