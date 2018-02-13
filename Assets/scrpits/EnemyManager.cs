using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public float Respawncool;
    public float Respawndelay;
    public GameObject enemy;
    public Transform RespawnPoint;
    public int enemyCnt;
    public GameObject Enemy2;
    public int enemy2cnt;
    public float RespawCool2;
    public float RespawnCool3;
    public int enemy3cnt;
    public GameObject Enemy3;

    void Start () {
		
	}
	void Update () {
        //Respawncool += Time.deltaTime;
        //if (Respawncool > Respawndelay)
        //{
        //    enemyCnt++;
        //    GameObject enemyInstantiate = Instantiate(enemy) as GameObject;
        //    enemyInstantiate.name = "Enemy" + enemyCnt;
        //    enemyInstantiate.transform.position = RespawnPoint.position;
        //    enemyInstantiate.GetComponent<CrowdAgent>().target = GameObject.FindGameObjectWithTag("EnemyPoint").transform;
        //    Respawncool = 0;
        //}
        //if(EnemyTrigger.Score > 100)
        //{
        //    RespawCool2 += Time.deltaTime;
        //    if (RespawCool2 > Respawndelay - 0.5f)
        //    {
        //        enemy2cnt++;
        //        GameObject enemy2Instatiate = Instantiate(Enemy2) as GameObject;
        //        enemy2Instatiate.name = "Enemy2" + enemy2cnt;
        //        enemy2Instatiate.transform.position = RespawnPoint.position + new Vector3(0,0,1);
        //        enemy2Instatiate.GetComponent<CrowdAgent>().target = GameObject.FindGameObjectWithTag("EnemyPoint").transform;
        //        RespawCool2 = 0;
        //    }
        //}
        //if(EnemyTrigger.Score > 200)
        //{
            RespawnCool3 += Time.deltaTime;
            if(RespawnCool3 > Respawndelay + 1)
            {
                enemy3cnt++;
                GameObject enemy3Instatiate = Instantiate(Enemy3) as GameObject;
                enemy3Instatiate.name = "enemy3" + enemy3cnt;
                enemy3Instatiate.transform.position = RespawnPoint.position;
                enemy3Instatiate.GetComponent<CrowdAgent>().target = GameObject.FindGameObjectWithTag("EnemyPoint").transform;
                RespawnCool3 = 0;
            }
        //}	
	}
}
