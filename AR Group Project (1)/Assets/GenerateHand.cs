using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHand : MonoBehaviour
{
    public Card card;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            card.generateCard(i*6);
        }
    }
}
