using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text Countertext;
    //public int Counter { get; private set; }
    public static int Counter;
    public Text Startext;
    void Start()
    {
        Counter = 0;
        Countertext.text = "30 / " + Counter;
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "Goldcoin")
        {
            Counter += 1;
            Destroy(Coin.gameObject);
            Countertext.text = "30 / " + Counter;
        }
    }

    private void Update()
    {
        if (Counter == 30)
        {
            Startext.text = "3";
        }
        if (Counter >= 20 && Counter < 30)
        {
            Startext.text = "2";
        }
        if (Counter >= 10 && Counter < 20)
        {
            Startext.text = "1";
        }
        else
        {
            Startext.text = "0";
        }
    }
}
