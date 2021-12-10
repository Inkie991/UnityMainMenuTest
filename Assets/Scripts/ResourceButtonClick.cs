using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceButtonClick : MonoBehaviour
{
    [SerializeField] private GameObject popupWindow;
    [SerializeField] private Image pointer;
    bool isPressed;

    private void Start()
    {
        isPressed = false;
    }

    public void OnResourceButtonClick()
    {
        if (isPressed == false)
        {
            RectTransform popupRectTransform = popupWindow.GetComponent<RectTransform>();
            popupRectTransform.anchoredPosition = new Vector3(gameObject.GetComponent<RectTransform>().anchoredPosition.x, popupWindow.GetComponent<RectTransform>().anchoredPosition.y);
            pointer.GetComponent<RectTransform>().SetPositionAndRotation(pointer.GetComponent<RectTransform>().position, Quaternion.Euler(0, 0, 0));
            popupWindow.GetComponent<PopupWindow>().OpenPopupWindow();
            isPressed = true;
        } else
        {
            pointer.GetComponent<RectTransform>().SetPositionAndRotation(pointer.GetComponent<RectTransform>().position, Quaternion.Euler(180, 0, 0));
            popupWindow.GetComponent<PopupWindow>().ClosePopupWindow();
            isPressed = false;
        }
    }
}
