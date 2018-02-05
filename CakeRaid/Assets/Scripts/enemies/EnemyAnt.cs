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

            //gameObject.GetComponent<Renderer>().enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
           // spawnDelay -= Time.deltaTime;
            //if (gameObject.GetComponent<Renderer>().enabled == false && spawnDelay < 0)
           // {
            //    gameObject.GetComponent<Renderer>().enabled = true;
            //}

            //if (gameObject.GetComponent<Renderer>().enabled)
            //{
                this.MovetoNextNode();
            //}
        }
    }
}