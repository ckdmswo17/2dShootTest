using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;


public class Enemy : MonoBehaviour
{
    public float speed = 5;
    public GameObject target = null;
    public Vector3 direction;

    public GameObject explosionFactory = null;
    // Start is called before the first frame update
    void Start()
    {
        // �¾ �� ������ ���ϰ��ʹ�
        // 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��� ���ϰ� �ʹ�.
        // ��ư��鼭 �� �������� �̵��ϰ� �ʹ�.
        int rValue = Random.Range(0,10);
        print(rValue);
        if (rValue <= 3)
        {
            GameObject target = GameObject.Find("Player");
            direction = target.transform.position - this.transform.position;
            direction.Normalize();
        } 
        else
        {
            direction = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // �Ʒ��� �̵��ϰ� �ʹ�. �ʼ� 5m/s 
        // P = P0 + vt
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;
        if(collision.gameObject.GetComponent<Bullet>()){
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.GetComponent<PlayerMove>()){
            Destroy(collision.gameObject);
        }
        //Destroy(collision.gameObject);
        Destroy(this.gameObject);

        //print(collision.gameObject.name);
    }

}