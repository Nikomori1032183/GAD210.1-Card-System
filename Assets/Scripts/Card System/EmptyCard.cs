using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCard : Card
{
    protected override void Play()
    {
        Debug.Log("Card Played");
    }
}
