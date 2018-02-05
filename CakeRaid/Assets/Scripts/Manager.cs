using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

namespace CakeRaid
{
    public class Manager : MonoBehaviour
    {
        public static Manager instance = null;

        //singleton values
        public int cash;
        public int cake;

        public int wave = 1;
        public int maxWave = 5;
        public int level = 0;
        public int maxLevel = 5;

        public Text cashText;
        public Text cakeText;
        public Text waveText;

        public GameObject cakeObj;

        //enemy gameobj type references
        public GameObject[] enemies;

        private string curWaveData;

        //instanced enemies
        private List<Enemy> insEnemies;

        private int enemiesSpawned = 0;

        private float timeBetweenWaves = 2.0f;
        private float lastSpawnTime;

        string spt;
        string[] spt2;
        
        int enemyInd = 0;

        void Awake()
        {
            if (instance == null) //check if instance is null
                instance = this; //assign instance to this instance
            else if (instance != this) //if instance is not null
                Destroy(gameObject); //get rid of duplicate

            DontDestroyOnLoad(gameObject);

        }

        // Use this for initialization
        void Start()
        {
            instance.curWaveData = Levels.levels[instance.level];

            insEnemies = new List<Enemy>();

            Instantiate(cakeObj, new Vector3(0, 4, 0), Quaternion.identity);

            cash = Constants.START_MONEY;
            cake = Constants.MAX_CAKE_HEALTH;

            instance.UpdateSplit();

            lastSpawnTime = Time.time;
        }

        // Update is called once per frame
        void Update()
        {
            //update all text
            cashText.text = "$" + cash;
            cakeText.text = "Cake: " + cake;
            waveText.text = "Wave: " + wave + "/" + maxWave;

            //instance.SpawnEnemy(0);

            if (instance.wave < instance.maxWave)
            {
                float timeInterval = Time.time - lastSpawnTime;
                float spawnInterval = 2.0f;

                //if timer conditions are met and we're under the amount specified for the wave
                //update the timer, spawn an enemy, and update our counter
                if (((enemiesSpawned == 0 && timeInterval > timeBetweenWaves) || timeInterval > spawnInterval) &&
                    enemiesSpawned < Levels.waveTotals[wave - 1])
                {
                    lastSpawnTime = Time.time;

                    instance.SpawnEnemy(enemyInd);
                    
                    enemiesSpawned++;
                }

                //if there are still more enemies to spawn for the wave, continue
                if (enemiesSpawned == int.Parse(spt2[enemyInd + 1]) && (enemyInd + 2) != spt2.Length)
                {
                    enemyInd += 2;
                }

                //if all enemies for the wave have spawned and all enemies are either killed or despawne
                if (enemiesSpawned >= Levels.waveTotals[wave - 1] && insEnemies.Count == 0)
                {
                    instance.wave++;
                    enemiesSpawned = 0;

                    lastSpawnTime = Time.time;
                    instance.UpdateSplit();
                }

                //if no more enemies remain, and we've reached max waves
                //continue to the next level, provided there we haven't reached the final level
                if ((insEnemies.Count == 0) && (wave == Constants.MAX_WAVES) && (level != Constants.MAX_LEVELS))
                {
                    enemyInd = 0;

                    this.LevelComplete();
                }

                if (insEnemies.Count > 0)
                {
                    if (insEnemies[0] == null)
                    {
                        insEnemies.RemoveAt(0);
                    }
                }
            }
        }

        void UpdateSplit()
        {
            //split waves
            spt = instance.curWaveData.Split('+')[instance.wave - 1];

            //split types
            spt2 = spt.Split('-');
        }

        void SpawnEnemy(int index)
        {
            //pulled separately from points since points should consist of future targets
            //basically saves an extra step of immediately popping it off the List
            Vector3 s = GameObject.Find("spawn_0").transform.position;

            GameObject temp;

            switch (spt2[index])
            {
                case "ant":
                    temp = Instantiate(enemies[0], s, Quaternion.identity);
                    insEnemies.Add(temp.GetComponent<Enemy>());
                    break;

                case "spider":
                    temp = Instantiate(enemies[1], s, Quaternion.identity);
                    insEnemies.Add(temp.GetComponent<Enemy>());
                    break;

                case "beetle":
                    temp = Instantiate(enemies[2], s, Quaternion.identity);
                    insEnemies.Add(temp.GetComponent<Enemy>());
                    break;
            }
        }

        public void LevelComplete()
        {
            instance.level++;
            instance.curWaveData = Levels.levels[instance.level];

            instance.UpdateSplit();

            SceneManager.LoadScene("scene" + instance.level, LoadSceneMode.Single); //Additive
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("scene" + instance.level));

            foreach (GameObject g in SceneManager.GetSceneByName("scene" + (instance.level - 1)).GetRootGameObjects())
            {
                g.SetActive(false);
            }

        }
    }
}