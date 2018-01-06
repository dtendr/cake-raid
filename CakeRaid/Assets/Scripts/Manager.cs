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

        //point list for pathing
        public Vector2[] points;

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

            cashText.text = "$" + cash;
            cakeText.text = "Cake: " + cake;
            waveText.text = "Wave: " + wave + "/" + maxWave;
        }

        // Update is called once per frame
        void Update()
        {
            //split waves
            string spt = instance.curWaveData.Split('+')[instance.wave - 1];

            //split types
            string[] spt2 = spt.Split('-');

            for (int i=0;i<spt2.Length; i+=2)
            {
                Vector3 s = GameObject.Find("spawn").transform.position;

                GameObject temp;

                switch (spt2[i])
                {
                    case "ant":
                        temp = Instantiate(enemies[0], s, Quaternion.identity);
                        insEnemies.Add(temp.GetComponent<Enemy>());
                        break;





                }
            }

            if ((insEnemies.Count == 0) && (wave == Constants.MAX_WAVES) && (level != Constants.MAX_LEVELS))
            {
                this.LevelComplete();
            }

            //update enemy positions

            

            //grab previously loaded enemy (at end of stack)
            if (insEnemies.Count > 0)
            {
                //if(insEnemies[insEnemies.Length - 1].
            }



        }

        public void LevelComplete()
        {
            instance.level++;
            instance.curWaveData = Levels.levels[instance.level];

            SceneManager.LoadScene("scene" + instance.level, LoadSceneMode.Single); //Additive
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("scene" + instance.level));

            foreach (GameObject g in SceneManager.GetSceneByName("scene" + (instance.level - 1)).GetRootGameObjects())
            {
                g.SetActive(false);
            }
        }
    }
}