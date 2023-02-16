using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{

    public GameObject ending;
    public GameObject pause;

    private void OnTriggerEnter2D(Collider2D Apple)
    {
        if (Apple.tag == "Apple")
        {
            ending.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
