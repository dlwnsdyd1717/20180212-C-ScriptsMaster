using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public float Respawncool;
    public float Respawndelay;
    public GameObject enemy;
    public Transform RespawnPoint;
    public int enemyCnt;

    void Start () {
		
	}
	void Update () {
        Respawncool += Time.deltaTime;
        if (Respawncool > Respawndelay)
        {
            enemyCnt++;
            GameObject enemyInstantiate = Instantiate(enemy) as GameObject;
            enemyInstantiate.name = "Enemy" + enemyCnt;
            enemyInstantiate.transform.position = RespawnPoint.position;
            enemyInstantiate.GetComponent<CrowdAgent>().target = GameObject.FindGameObjectWithTag("EnemyPoint").transform;
            Respawncool = 0;
        }	
	}
}
