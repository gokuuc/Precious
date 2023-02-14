using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    [SerializeField] private float startingHeart;
    [SerializeField] private Transform teleport;
    public float currentHeart { get; private set;}

    private void Awake()
    {
        currentHeart = startingHeart;
    }

    private void OnTriggerEnter2D(Collider2D Spike)
    {
        if (Spike.tag == "Enemy")
        {
            currentHeart -= 1;
            transform.position = teleport.position;
        }
    }

    private void Update()
    {
        if (currentHeart == 0)
        {
            Time.timeScale = 0f;
        }
    }
}
