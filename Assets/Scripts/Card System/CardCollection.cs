using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardCollection : MonoBehaviour
{
    protected List<Card> cardList;
    
    public virtual void AddCard(Card card)
    {
        Debug.Log("Card Added");

        cardList.Add(card);
        card.transform.parent = transform;
    }

    public virtual void RemoveCard(Card card)
    {
        Debug.Log("Card Removed");
        if (cardList.Contains(card))
        {
            cardList.Remove(card);
        }
    }
}
