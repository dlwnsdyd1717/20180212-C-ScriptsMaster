using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTrigger : MonoBehaviour {

    static public int Score = 0;
    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.tag == "EnemyPoint")
        {

            Score -= 10;

            Destroy(gameObject);

        }
        if(col.gameObject.tag == "bullet")
        {

            Score += 10;
            Destroy(gameObject);
        }
    }
}
