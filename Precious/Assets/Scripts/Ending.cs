using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Apple)
    {
        if (Apple.tag == "Apple")
        {
            Time.timeScale = 0f;
        }
    }
}
