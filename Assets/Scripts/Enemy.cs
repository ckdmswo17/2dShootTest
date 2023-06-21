using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 아래로 이동하고 싶다. 초속 5m/s 
        // P = P0 + vt
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 너죽고 나죽자
        Destroy(collision.gameObject);
        Destroy(this.gameObject);

        //print(collision.gameObject.name);
    }

}