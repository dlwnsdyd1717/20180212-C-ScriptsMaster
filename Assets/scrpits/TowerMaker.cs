using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMaker : MonoBehaviour {

    public GameObject TowerPrefabs;
    
	
	void Update ()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Vector3.forward);
            //RaycastHit hit;
            //if (Physics.Raycast(transform.position, transform.forward, out hit))
            //{
            //    Debug.Log(hit.transform.position);
            //}
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                
                Debug.Log(hitInfo.transform.name);
                switch (hitInfo.transform.tag)
                {
                    case "wall":
                        GameObject InstanTower = Instantiate(TowerPrefabs);
                        TowerPrefabs.transform.position = hitInfo.transform.position + new Vector3 (0,1f,0);
                        break;
                    case "Plane":
                        Debug.Log("그곳에는 타워를 설치 할 수 없습니다!!!");
                        break;
                    case "Enemy":
                        Debug.Log("선택된 적의 이름은::::" + hitInfo.transform.name);
                        break;
                    default:
                        Debug.Log("아니 안돼:::");
                        break;
                        
                }
               
            }
        }
        
	}
}
