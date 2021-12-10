using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSpriteSwitch : MonoBehaviour
{
    [SerializeField] private Sprite spritePressed;
    [SerializeField] private Sprite spriteIdle;

    // Update is called once per frame
    public void OnButtonClick()
    {
        Sprite currentImage = GetComponent<Image>().sprite;
        if (currentImage == spritePressed)
        {
            currentImage = spriteIdle;
            GetComponent<Image>().sprite = currentImage;

        } else
        {
            currentImage = spritePressed;
            GetComponent<Image>().sprite = currentImage;
        }
    }
}
