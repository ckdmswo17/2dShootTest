using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory = null;
    public Transform firePosition = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자가 마우스 왼쪽 버튼을 누르면
        
        if (Input.GetButton("Fire1"))
        {
            // 총알공장에서 총알을 만들어서
            GameObject bullet = Instantiate(bulletFactory);
            // 총구위치에 배치하고 싶다.
            bullet.transform.position = firePosition.position;
            bullet.transform.up = firePosition.up;

        }
    }
   
}
