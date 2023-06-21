using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;


public class Enemy : MonoBehaviour
{
    public float speed = 5;
    public GameObject target = null;
    // Start is called before the first frame update
    void Start()
    {
        // 태어날 때 방향을 정하고싶다
        // 30% 확률로 플레이어 방향, 나머지 확률로 아래로 정하고 싶다.
        // 살아가면서 그 방향으로 이동하고 싶다.
        int rValue = Random.Range(1,10);
        if (rValue <= 3)
        {
            GameObject target = GameObject.Find("Player");
            Vector3 direction = target.transform.position - this.transform.position;
            direction.Normalize();
        } 
        else
        {
            Vector3 direction = Vector3.down;
        }
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