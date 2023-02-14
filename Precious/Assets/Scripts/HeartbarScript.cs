using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartbarScript : MonoBehaviour
{

    [SerializeField] private HeartScript playerheart;
    [SerializeField] private Image Emptyheart;
    [SerializeField] private Image Fullheart;

    void Start()
    {
        Emptyheart.fillAmount = playerheart.currentHeart / 10;
    }

    void Update()
    {
        Fullheart.fillAmount = playerheart.currentHeart / 10;
    }
}
