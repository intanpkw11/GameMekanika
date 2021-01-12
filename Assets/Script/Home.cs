using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Home : MonoBehaviour
{
    /*[SerializeField] float startTime = 5f;
    [SerializeField] Slider slider1;
    [SerializeField] TextMeshProUGUI timerText;

    float timer = 0f;
    int playerCoin = 0;

    private Home coin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        coin = GameObject.FindGameObjectWithTag("Coins");
    }

    private IEnumerator Timer()
    {
        timer = startTime;

        do
        {
            timer -= Time.deltaTime;
            slider1.value = timer / startTime;
            FormatText1();
            yield return null;
        }

        while (timer > 0);
    }

    private void FormatText1()
    {
        int days = (int) (timer / 86400) % 365;
        int hours = (int) (timer / 3600) % 24;
        int minutes = (int) (timer / 60) % 60;
        int seconds = (int) (timer % 60);

        timerText.text = "";
        if (days > 0) { timerText.text += days + "d "; }
        if (hours > 0) { timerText.text += hours + "h "; }
        if (minutes > 0) { timerText.text += minutes + "m "; }
        if (seconds > 0) { timerText.text += seconds + "s "; }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void CollectCoins()
    {
        if (timer == 0)
        {
            coin.playerCoin += 50;
        }
    }*/
}
