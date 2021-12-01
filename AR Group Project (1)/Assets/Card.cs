using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameObject[] cardBases;
    private float rotate = -90.0f;

    void Start()
    {
        //cardOverlay.GenerateNumber();
        //generateCard();
    }
    
    public void generateCard(int position)
    {
        //Generates Random Element
        GameObject ElementCard = cardBases[Random.Range(0, cardBases.Length)];
        //cardOverlay.GenerateNumber();
        //transform.rotation rotates the card -90 on the X so they face up towards the camera
        Instantiate(ElementCard, new Vector3(position, -5, 40), transform.rotation = Quaternion.Euler(rotate, 0, 0));
    }
}
