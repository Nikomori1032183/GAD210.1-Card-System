using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager current;

    private void Awake()
    {
        current = this;
    }

    public event Action<int> onDrawCards;
    public void DrawCards(int amount)
    {
        Debug.Log("Draw Cards");

        if (onDrawCards != null)
        {
            onDrawCards(amount);
        }
    }

    public event Action<int> onDiscardCards;
    public void DiscardCards(int amount)
    {
        Debug.Log("Discard Cards");

        if (onDiscardCards != null)
        {
            onDiscardCards(amount);
        }
    }
}