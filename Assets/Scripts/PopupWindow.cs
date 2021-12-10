using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupWindow : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void OpenPopupWindow()
    {
        gameObject.SetActive(true);
    }

    public void ClosePopupWindow()
    {
        gameObject.SetActive(false);
    }
}
