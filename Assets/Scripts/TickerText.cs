using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickerText : MonoBehaviour
{
    private const int tickerTextOffset = 170;
    private float tickerWidth;
    private float pixelsPerSecond;
    RectTransform rectOfText;

    public float GetXPosition { get { return rectOfText.anchoredPosition.x; } }
    public float GetWidth {  get { return rectOfText.rect.width; } }

    public void Initialize(float tickerWidth, float pixelsPerSecond, string message)
    {
        this.tickerWidth = tickerWidth;
        this.pixelsPerSecond = pixelsPerSecond;
        rectOfText = GetComponent<RectTransform>();
        GetComponent<Text>().text = message;
        rectOfText.anchoredPosition = new Vector2(tickerTextOffset + tickerWidth, rectOfText.anchoredPosition.y);   
    }

    private void Update()
    {
        rectOfText.position += Vector3.left * pixelsPerSecond * Time.deltaTime;
        if (GetXPosition <= -tickerTextOffset - tickerWidth - GetWidth) 
        {
            Destroy(this.gameObject);
        }
    }
}
