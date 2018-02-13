using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytrigger1 : MonoBehaviour {

    public int Despoint = 0;

    void Update()
    {
        if(Despoint > 3)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "EnemyPoint")
        {

            EnemyTrigger.Score -= 20;

            Destroy(gameObject);

        }
        if (col.gameObject.tag == "bullet")
        {

            EnemyTrigger.Score += 20;
            Despoint += 1;
        }
    }
}
