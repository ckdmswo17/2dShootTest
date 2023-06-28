using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory = null;
    public Transform firePosition = null;
    // Start is called before the first frame update
    public GameObject[] bulletArray;
    public int bulletLength = 10;
    void Start()
    {
        bulletArray = new GameObject[bulletLength];
        for(int i =0;i<bulletLength;i++){
            GameObject go = Instantiate(bulletFactory);
            bulletArray[i] = go;
            go.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자가 마우스 왼쪽 버튼을 누르면
        
        if (Input.GetButton("Fire1"))
        {
            for(int i=0;i<bulletLength;i++){
                if(bulletArray[i].activeSelf == false){
                    bulletArray[i].transform.position = firePosition.transform.position;
                    bulletArray[i].SetActive(true);
                    break;
                }
                //bulletArray[i]번째 총알이 비활성화되어있다면
                //파이어포지션의 위치에 옮겨놔라
                //활성화시켜라 (스위치를 켜라)
                //반복문을 종료해라
            }
            // 총알공장에서 총알을 만들어서
            // GameObject bullet = Instantiate(bulletFactory);
            // // 총구위치에 배치하고 싶다.
            // bullet.transform.position = firePosition.position;
            // bullet.transform.up = firePosition.up;

        }
    }
   
}
