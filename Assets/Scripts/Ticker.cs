using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ticker : MonoBehaviour
{
    [SerializeField] private TickerText tickerTextPrefab;
    [Range(1f, 10f)]
    [SerializeField] private float textDuration = 3.0f;
    [SerializeField] private string[] fillerItems;

    private float width;
    private float pixelsPerSecond;
    private TickerText currentItem;

    // Start is called before the first frame update
    void Start()
    {
        width = GetComponent<RectTransform>().rect.width;
        pixelsPerSecond = width / textDuration;
        AddTickerItem(fillerItems[0]);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentItem.GetXPosition <= -currentItem.GetWidth)
        {
            AddTickerItem(fillerItems[0]);
        }
    }

    private void AddTickerItem(string message)
    {
        currentItem = Instantiate(tickerTextPrefab, transform);
        currentItem.Initialize(width, pixelsPerSecond, message);
    }
}
