using UnityEngine;
using System.Collections;

namespace CakeRaid
{
	public class EnemyAnt : Enemy
    {
        // Use this for initialization
        void Start()
        {
            this.Speed = Constants.ANT_SPEED;
        }

        // Update is called once per frame
        void Update()
        {
            this.MovetoNextNode();
        }
    }
}