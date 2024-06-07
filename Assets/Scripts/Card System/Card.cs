using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Card : MonoBehaviour
{
    protected string cardName;

    protected Text nameText;
    protected Image cardImage;

    protected void Start()
    {
        nameText.text = cardName;
    }

    protected virtual void Play()
    {
        // Play Noise

        Hand.current.DiscardCard(this);
    }

    public void EnableCard()
    {
        nameText.enabled = true;
        cardImage.enabled = true;
    }

    public void DisableCard()
    {
        nameText.enabled = false;
        cardImage.enabled = false;
    }

    private void OnMouseOver()
    {
        // Hover Noise
    }
}
