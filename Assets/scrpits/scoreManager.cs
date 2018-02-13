using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {

    void Update () {
        gameObject.GetComponent<Text>().text = "Score : " + (EnemyTrigger.Score.ToString());
        if (EnemyTrigger.Score < 0)
        {
            EnemyTrigger.Score = 0;
        }
    }
}
