using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    GameObject coin;
    GameObject Cactus;
    GameObject Crystal;
    GameObject enemy;
    float timer=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer += Time.deltaTime;
       
            if (Random.Range(0, 100) < 5)
            {
                coin = PoolMethod.Instance.Get("Coin");
                if (coin != null)
                {
                if (timer > 2.0f)
                {
                   // coin.transform.position = this.transform.position + new Vector3(-2.5f, Random.Range(-3.5f,-0.05f), 0);
                    coin.transform.position = this.transform.position + new Vector3(Random.Range(-2.5f, -10.02f), -3.29f, 0);
                    coin.SetActive(true);
                    
                }

                }
              
           // StartCoroutine(WaitAfter10Seconds());
            //coin.SetActive(false);




            Cactus = PoolMethod.Instance.Get("Cactus");
            if(Cactus!=null)
            {
                if (timer > 10.0f)
                {
                    Cactus.transform.position = this.transform.position + new Vector3(Random.Range(0.0f, -1.0f), -3.9f, 0);
                    Cactus.SetActive(true);
                }
            }
            Crystal = PoolMethod.Instance.Get("Crystal");
            if(Crystal!=null)
            {
                if(timer>5.0f)
                {
                    Crystal.transform.position = this.transform.position + new Vector3(Random.Range(-0.89f, -2.17f),Random.Range(-1.5f, 0.27f), 0);
                    Crystal.SetActive(true);
                }
            }
           

        }
    }
  

}
