using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menucounter : MonoBehaviour
{
    public Text Startext;
    public Text Cointext;



    public void Update()
    {
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

        Cointext.text = " " + CoinCounter.Counter;
    }
}
