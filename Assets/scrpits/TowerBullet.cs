using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBullet : MonoBehaviour {

    public float bulletspeed;

    void Start()
    {
        Destroy(gameObject, 2f);

    }
    void Update()
    {
        gameObject.transform.Translate(0,0,bulletspeed *Time.deltaTime);
    }

}
