using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public GameObject target = null;
    public float speed = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ��ǥ�� ���ϴ� ������ ���ϰ�ʹ�.
        Vector3 direction = target.transform.position - this.transform.position;
        // direction�� ũ�⸦ 1�� �����ʹ�.
        direction.Normalize();
        // 2. �� �������� �̵��ϰ� �ʹ�.
        transform.position += direction * speed * Time.deltaTime;
    }
}
