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

        private Transform eTransform;
        Vector2 pos;

        //point list for pathing
        public List<Vector2> points;

        private int currentNode = 0;
        private float lastNodeSwitchTime = 0;

        public float spawnDelay = 10.0f;

        // Use this for initialization
        void Awake()
        {
            this.behavior = Constants.EnemyState.Spawn;

            this.hasCake = false;
            this.adjacentToCake = false;

            this.slowEffect = 1.0f;
            this.attackRange = 1.0f;

            // Instantiate nodes for pathfinding
            GameObject[] nodes = GameObject.FindGameObjectsWithTag("node");
            this.points = new List<Vector2>();

            GameObject[] sortedNodes = new GameObject[nodes.Length];
            foreach(GameObject node in nodes)
            {
                sortedNodes[int.Parse(node.name.Split('_')[1])] = node;
            }

            // Populate points from tagged gameobjects in Scene
            foreach (GameObject node in sortedNodes)
            {
                Vector2 t = new Vector2(node.transform.position.x, node.transform.position.y);
                this.points.Add(t);
            }
            
            // Store initial position as a vector2 for quick internal reference
            this.pos = new Vector2(transform.position.x, transform.position.y);
            
        }

        public void MovetoNextNode()
        {
            // Gather start and end points from points list
            Vector2 startPosition = points[currentNode];
            Vector2 endPosition = points[currentNode + 1];
            Vector3 dir = (endPosition - startPosition);

            // Calculate path length and timings
            float pathLength = Vector2.Distance(startPosition, endPosition);
            float totalTimeForPath = pathLength / this.Speed;
            float currentTimeOnPath = Time.time - lastNodeSwitchTime;
            
            // Lerp and update object position
            gameObject.transform.position = Vector2.Lerp(startPosition, endPosition, currentTimeOnPath / totalTimeForPath);

            // Update internal vector2 quick reference
            this.pos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);

            if (this.pos.Equals(endPosition))
            {
                if (currentNode < points.Count - 2)
                {
                    currentNode++;
                    lastNodeSwitchTime = Time.time;

                    //update facing direction
                    float rotationAngle = Mathf.Atan2(dir.x, dir.y) * 90 / Mathf.PI;
                    transform.Rotate(Vector3.forward * rotationAngle);
                }
                else
                {
                    //gameObject.GetComponent<Renderer>().enabled = false;
                    Destroy(gameObject);
                }
            }
        }
	}
}