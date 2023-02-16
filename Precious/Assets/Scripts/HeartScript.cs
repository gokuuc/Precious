using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartScript : MonoBehaviour
{
    [SerializeField] private float startingHeart;
    [SerializeField] private Transform teleport;
    public GameObject fail;
    public float currentHeart { get; private set;}
    public Text Startext;

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
            fail.SetActive(true);
        }
        if (CoinCounter.Counter == 30)
        {
            Startext.text = "3";
        }
        if (CoinCounter.Counter >= 20 && CoinCounter.Counter < 30)
        {
            Startext.text = "2";
        }
        if (CoinCounter.Counter >= 10 && CoinCounter.Counter < 20)
        {
            Startext.text = "1";
        }
        if (CoinCounter.Counter >= 0 && CoinCounter.Counter < 10)
        {
            Startext.text = "0";
        }
    }
}
