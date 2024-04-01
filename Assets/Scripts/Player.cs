using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ���ǵ�
    public float moveSpeed = 10.0f;

    void Update()
    {
        // x�� �� ���� vector ���� * �ð� * ���ǵ�
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //Mathf.Clamp(distanceX, -2.0f, 2.0f);
        // x�� �̵� ����
        gameObject.GetComponent<Rigidbody2D>().MovePosition(new Vector2(transform.position.x + distanceX, transform.position.y));
        //transform.Translate(distanceX, 0, 0);
    }
}
