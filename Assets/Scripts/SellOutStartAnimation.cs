using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellOutStartAnimation : MonoBehaviour
{
    [SerializeField] private Sprite[] spritesOfAnimation;
    [SerializeField] private GameObject discountButton;
    private Image imageOfButton;


    void Start()
    {
        discountButton.GetComponent<UISpriteAnimation>().enabled = false;
        imageOfButton = GetComponent<Image>();
        StartCoroutine(ButtonAnimation());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator ButtonAnimation()
    {
        for (int i = 0; i < spritesOfAnimation.Length; i++)
        {
            imageOfButton.sprite = spritesOfAnimation[i];
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;
        discountButton.GetComponent<UISpriteAnimation>().enabled = true;
        StartCoroutine(discountButton.GetComponent<UISpriteAnimation>().ButtonAnimation());

    }
}
