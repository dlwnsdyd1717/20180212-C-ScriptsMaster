using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBullet : MonoBehaviour {

    public float bulletspeed;
    public GameObject Explosion;

    void Start()
    {
        Destroy(gameObject, 2f);

    }
    void Update()
    {
        gameObject.transform.Translate(0,0,bulletspeed *Time.deltaTime);
    }

    void OnTriggerEnter(Collider col)
    {
        GameObject explosion = Instantiate(Explosion) as GameObject;
        explosion.transform.position = gameObject.transform.position;
        explosion.transform.rotation = gameObject.transform.rotation;
        Destroy(gameObject);

    }

}
