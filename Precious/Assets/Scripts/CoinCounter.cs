using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text Countertext;
    private int Counter;
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
}
