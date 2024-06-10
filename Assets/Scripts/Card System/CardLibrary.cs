using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLibrary : MonoBehaviour
{
    public static CardLibrary current;

    public GameObject emptyCardPrefab;

    private void Awake()
    {
        current = this;
    }
}
