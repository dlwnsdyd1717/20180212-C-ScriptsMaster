using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : MonoBehaviour {

    public float firecool;
    public float fireDelay;
    public GameObject bullet;
    public Transform FirePosition;
    public List<GameObject> Lookobj;
    bool lookbool = false;
    GameObject Look;
    public float rotationSpeed = 60f;


    void Start () {
		
	}

    void Update()
    {
 
        //if (lookbool == true)
        //{
        //    //Vector3 lookatY = Look.gameObject.transform.position;
        //    //lookatY.x = 0f;
        //    //lookatY.z = 0f;
        //    //gameObject.transform.LookAt(lookatY);
        //    gameObject.transform.LookAt(Look.gameObject.transform.position);
        //}
        
        if (Lookobj.Count > 0)
        {
            if(Lookobj[0] != null)
            {
                Vector3 dir = Lookobj[0].transform.position - transform.position;
                dir.y = 0.0f;
                dir.Normalize();
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), rotationSpeed * Time.deltaTime);
                //transform.LookAt(Lookobj.transform);
                //transform.rotation = Quaternion.Euler(0,transform.rotation.y,0);
                firecool += Time.deltaTime;
                if (firecool > fireDelay)
                {

                    GameObject towerbullet = Instantiate(bullet) as GameObject;
                    FirePosition.transform.LookAt(Lookobj[0].transform);
                    towerbullet.transform.position = FirePosition.position;
                    towerbullet.transform.localRotation = FirePosition.rotation;
                    //Instantiate(bullet, FirePosition.position, FirePosition.rotation);
                    firecool = 0;
                }
            }
            else
            {
                Lookobj.RemoveAt(0);
            }
           
        }


        

    }

    void OnTriggerEnter(Collider col)
    {
        
        if(col.gameObject.tag == "Enemy")
        {
            //Look = col.gameObject;
            //lookbool = true;
            Lookobj.Add(col.gameObject);
            
        }
    }
    void OnTriggerExit(Collider col)
    {
        //    if (col.gameObject.tag == "Enemy")
        //    {
        //        lookbool = false;
        //    }
        Lookobj.Remove(col.gameObject);
    }
}
