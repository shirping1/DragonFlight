using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 스피드
    public float moveSpeed = 10.0f;

    void Update()
    {
        // x쪽 값 설정 vector 방향 * 시간 * 스피드
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //Mathf.Clamp(distanceX, -2.0f, 2.0f);
        // x쪽 이동 설정
        gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(transform.position.x + distanceX, transform.position.y));
        //transform.Translate(distanceX, 0, 0);
    }
}
