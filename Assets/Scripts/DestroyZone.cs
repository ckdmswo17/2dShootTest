using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������� ���� �����浹 �Ǹ� ������ �ı��ϰ� �ʹ�.
public class DestroyZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Bullet")){
            other.gameObject.SetActive(false);
        } else {
            Destroy(other.gameObject);
        }

    }
}
