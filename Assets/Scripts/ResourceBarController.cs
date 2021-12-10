using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceBarController : MonoBehaviour
{
    [SerializeField] private GameObject moneyButton;
    [SerializeField] private GameObject resourcesButton;
    [SerializeField] private GameObject moneyBar;
    [SerializeField] private GameObject resourceBar;

    [SerializeField] private Sprite moneyBarPressed;
    [SerializeField] private Sprite moneyBarIdle;
    [SerializeField] private Sprite resourceBarPressed;
    [SerializeField] private Sprite resourceBarIdle;
    // Start is called before the first frame update
    void Start()
    {
        moneyBar.SetActive(true);
        moneyButton.GetComponent<Image>().sprite = moneyBarPressed;
        resourceBar.SetActive(false);
        resourcesButton.GetComponent<Image>().sprite = resourceBarIdle;
    }

    public void OnMoneyButtonClick()
    {
        moneyBar.SetActive(true);
        moneyButton.GetComponent<Image>().sprite = moneyBarPressed;
        resourceBar.SetActive(false);
        resourcesButton.GetComponent<Image>().sprite = resourceBarIdle;
    }

    public void OnResourceButtonClick()
    {
        moneyBar.SetActive(false);
        moneyButton.GetComponent<Image>().sprite = moneyBarIdle;
        resourceBar.SetActive(true);
        resourcesButton.GetComponent<Image>().sprite = resourceBarPressed;
    }
}
