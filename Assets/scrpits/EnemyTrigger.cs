using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour {
    

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "EnemyPoint")
        {
            Destroy(gameObject);
        }

    }
}
