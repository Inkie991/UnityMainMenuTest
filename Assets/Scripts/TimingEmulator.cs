using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimingEmulator : MonoBehaviour
{
    [SerializeField] private Text dateLabel;
    [SerializeField] private Text moneyLabel;
    [SerializeField] private Text giftTimer;
    [SerializeField] private Text discountTimer;
    int dailyGainOfMoney = 100;

    // Start is called before the first frame update
    void Start()
    {
        dateLabel.text = "01.01.2010";
        moneyLabel.text = "5025";
        giftTimer.text = " ";
        discountTimer.text = " ";
        StartCoroutine(GiftTimer());
        StartCoroutine(DiscountTimer());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartTimingClick()
    {
        StartCoroutine(Timing());
    }

    public void OnStopTimingClick()
    {
        StopCoroutine(Timing());
    }

    private IEnumerator Timing()
    {
        string prevDate = dateLabel.text;
        string prevMoney = moneyLabel.text;
        yield return new WaitForSeconds(10f);
        int newMoney = int.Parse(prevMoney) + dailyGainOfMoney;
        moneyLabel.text = newMoney.ToString();
        string[] separatedDate = prevDate.Split('.');
        int day = int.Parse(separatedDate[0]);
        if (day < 10)
        {
            day = day + 1;
            string newDate = ("0" + day + ".01.2010");
            dateLabel.text = newDate;
        } else
        {
            day = day + 1;  
            string newDate = (day + ".01.2010");
            dateLabel.text = newDate;
        }
    }

    public IEnumerator GiftTimer()
    {
        giftTimer.text = "23:59";
        string prevTime = giftTimer.text;
        yield return new WaitForSeconds(60);
        int minutesChange = int.Parse(prevTime.Split(':')[1]) - 1;
        int hours = 23;
        if(minutesChange < 0)
        {
            hours = hours - 1;
            minutesChange = 59;
        }
        giftTimer.text = hours + ":" + minutesChange;
    }

    public IEnumerator DiscountTimer()
    {
        discountTimer.text = "23:59";
        string prevTime = giftTimer.text;
        yield return new WaitForSeconds(1);
        int secondsChange = int.Parse(prevTime.Split(':')[1]) - 1;
        int minutes = 23;
        if (secondsChange < 0)
        {
            minutes = minutes - 1;
            secondsChange = 59;
        }
        giftTimer.text = minutes + ":" + secondsChange;
    }
}
