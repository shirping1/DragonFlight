using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 움직일 속도를 지정해 줍니다.
    public float moveSpeed = 1.3f;


    void Start()
    {
        
    }

    void Update()
    {
        // 움직임을 변수로 만들기
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, -distanceY, 0);
    }

    // 화면 밖으로 나가 카메라에 보이지 않으면
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
