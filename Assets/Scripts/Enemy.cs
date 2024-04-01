using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ������ �ӵ��� ������ �ݴϴ�.
    public float moveSpeed = 1.3f;


    void Start()
    {
        
    }

    void Update()
    {
        // �������� ������ �����
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, -distanceY, 0);
    }

    // ȭ�� ������ ���� ī�޶� ������ ������
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
