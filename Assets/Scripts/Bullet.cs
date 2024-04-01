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

    // ȭ�� ������ ������ �Ⱥ��ϰ�� ȣǮ�� �Ǵ� �Լ�
    private void OnBecameInvisible()
    {
        // �̻��� �����
        Destroy(gameObject);
    }

    // Ʈ����
    // �ݸ���
    //enter 1�� ���ö�
    // stay ��� �浹 ��
    // exit �浹�� ������ 1��
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
