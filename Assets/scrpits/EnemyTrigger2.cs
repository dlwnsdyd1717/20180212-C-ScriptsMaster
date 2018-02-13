using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger2 : MonoBehaviour {

    public int Despoint = 0;

    void Update()
    {
        if (Despoint > 10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "EnemyPoint")
        {

            EnemyTrigger.Score -= 50;

            Destroy(gameObject);

        }
        if (col.gameObject.tag == "bullet")
        {

            EnemyTrigger.Score += 50;
            Despoint += 1;
        }
    }
}
