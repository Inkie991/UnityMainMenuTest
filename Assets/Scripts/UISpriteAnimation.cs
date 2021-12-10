using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class UISpriteAnimation : MonoBehaviour
{
    [SerializeField] private float timeBetweenAnimations;
    [SerializeField] private Sprite[] spritesOfAnimation;
    [SerializeField] private Image imageOfButton;


    void Start()
    {
        imageOfButton = GetComponent<Image>();
        StartCoroutine(ButtonAnimation());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ButtonAnimation()
    {
        while (true)
        {
            for (int i = 0; i < spritesOfAnimation.Length; i++)
            {
                imageOfButton.sprite = spritesOfAnimation[i];
                yield return new WaitForSeconds(0.05f);
            }
            yield return new WaitForSeconds(timeBetweenAnimations);
        }
    }
}
