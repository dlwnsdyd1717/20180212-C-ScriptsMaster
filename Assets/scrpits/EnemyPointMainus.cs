using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPointMainus : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Enemy")
        {
            EnemyTrigger.Score -= 10;
        }
    }

}
