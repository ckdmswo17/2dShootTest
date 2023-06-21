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
        // �Ʒ��� �̵��ϰ� �ʹ�. �ʼ� 5m/s 
        // P = P0 + vt
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ���װ� ������
        Destroy(collision.gameObject);
        Destroy(this.gameObject);

        //print(collision.gameObject.name);
    }

}