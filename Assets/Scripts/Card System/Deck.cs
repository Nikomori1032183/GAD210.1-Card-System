using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : CardCollection
{
    public static Deck current;

    private void Awake()
    {
        current = this;
    }

    private void Start()
    {
        DisableCards();
    }

    public Card GetTopCard()
    {
        return cardList[cardList.Count - 1];
    }

    public void RemoveTopCard()
    {
        cardList.Remove(GetTopCard());
    }
}
