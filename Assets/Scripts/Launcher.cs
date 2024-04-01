using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;
    public AudioClip bulletClip;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //("함수이름",초기지연시간, 지연할시간)
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
        audioSource.clip = bulletClip;
        audioSource.Play();
    }

    void Update()
    {
        
    }
}
