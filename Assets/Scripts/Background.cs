using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // 머티리얼 정보
    public Material bgMaterial;
    
    // 스크롤 속도
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 방향을 설정 아래로 내려가도록 (offset.y ++)
        Vector2 dir = Vector2.up;

        // 스크롤링 하자!! P = p0 + vt
        bgMaterial.mainTextureOffset += dir * speed * Time.deltaTime;
    }
}
