using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    public ParticleSystem myParticleSystem;
    //public GameObject effectPrefab;

    void Start()
    {
        myParticleSystem = GameObject.Find("Particle System").GetComponent<ParticleSystem>();
    }

    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

    }

    // 화면 밖으로 나가면 안보일경우 호풀이 되는 함수
    private void OnBecameInvisible()
    {
        // 미사일 지우기
        Destroy(gameObject);
    }

    // 트리거
    // 콜리젼
    //enter 1번 들어올때
    // stay 계속 충돌 시
    // exit 충돌이 끝날때 1번
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("Enemy"))
        {
            myParticleSystem.transform.position = gameObject.transform.position;
            myParticleSystem.Play();
            //GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject, 0.1f);

            Destroy(gameObject);

            //Destroy(effect, 0.1f);
        }
    }


}
