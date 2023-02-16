using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCard : MonoBehaviour
{
    public Text Starcard;

    private void Update()
    {
        if (CoinCounter.Counter == 30)
        {
            Starcard.text = "3";
        }
        if (CoinCounter.Counter >= 20 && CoinCounter.Counter < 30)
        {
            Starcard.text = "2";
        }
        if (CoinCounter.Counter >= 10 && CoinCounter.Counter < 20)
        {
            Starcard.text = "1";
        }
        if (CoinCounter.Counter >= 0 && CoinCounter.Counter < 10)
        {
            Starcard.text = "0";
        }
    }
}
