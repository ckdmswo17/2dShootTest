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
        // �¾ �� ������ ���ϰ�ʹ�
        // 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��� ���ϰ� �ʹ�.
        // ��ư��鼭 �� �������� �̵��ϰ� �ʹ�.
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