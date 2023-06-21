using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력에따라 상하좌우로 이동하고싶다.
// 필요요소
// - 속력
public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        print(h + " , " + v);
        Vector3 dir = h * Vector3.right + v * Vector3.up;
        dir.Normalize();
        Vector3 velocity = dir * speed;
        // 사용자에 입력에따라 상하좌우로 이동하고 싶다.
        transform.position += velocity * Time.deltaTime;

    }
}
