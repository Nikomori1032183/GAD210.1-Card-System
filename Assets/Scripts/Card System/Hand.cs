using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : CardCollection
{
    public static Hand current;

    private void Awake()
    {
        current = this;
    }

    public override void AddCard(Card card)
    {
        base.AddCard(card);
        card.enabled = true;
    }

    public override void RemoveCard(Card card)
    {
        base.RemoveCard(card);
        card.enabled = false;
    }

    public void DrawCard()
    {
        AddCard(Deck.current.GetTopCard());

        Deck.current.RemoveTopCard();
    }

    public void DiscardCard(Card card)
    {
        RemoveCard(card);
    }

    public void DrawCards(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            DrawCard();
        }
    }
}
