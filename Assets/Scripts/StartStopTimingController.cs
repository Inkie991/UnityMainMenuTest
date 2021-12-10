using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartStopTimingController : MonoBehaviour
{
    [SerializeField] private Image stopTimingButton;
    [SerializeField] private Image startTimingButton;
    [SerializeField] private Image boostTimingButton;

    [SerializeField] private Sprite stopTimingPressed;
    [SerializeField] private Sprite stopTimingIdle;
    [SerializeField] private Sprite startTimingPressed;
    [SerializeField] private Sprite startTimingIdle;
    [SerializeField] private Sprite boostTimingPressed;
    [SerializeField] private Sprite boostTimingIdle;

    public void OnStopTimingClick()
    {
        stopTimingButton.sprite = stopTimingPressed;
        startTimingButton.sprite = startTimingIdle;
        boostTimingButton.sprite = boostTimingIdle;
    }

    public void OnStartTimingClick()
    {
        stopTimingButton.sprite = stopTimingIdle;
        startTimingButton.sprite = startTimingPressed;
        boostTimingButton.sprite = boostTimingIdle;
    }

    public void OnBoostTimingClick()
    {
        stopTimingButton.sprite = stopTimingIdle;
        startTimingButton.sprite = startTimingIdle;
        boostTimingButton.sprite = boostTimingPressed;
    }
}
