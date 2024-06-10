using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class Card : MonoBehaviour
{
    public bool visible = false;
    [SerializeField] protected string cardName;

    [SerializeField] protected TMP_Text nameText;
    [SerializeField] protected Image cardImage;

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
        visible = true;
        nameText.enabled = true;
        cardImage.enabled = true;
    }

    public void DisableCard()
    {
        visible = false;
        nameText.enabled = false;
        cardImage.enabled = false;
    }

    private void OnMouseOver()
    {
        // Hover Noise
    }
}
