using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardOverlay : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI element;
    public GameManager gameManager;
    //public TextMeshProUGUI Name;

    // Start is called before the first frame update
    void Start()
    {
        GenerateNumber();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void GenerateNumber()
    {
        PickRandomNumber(10);
    }

    public void PickRandomNumber(int maxInt)
    {
        int randomNum = Random.Range(1, maxInt + 1);
        text.text = randomNum.ToString();
        StartCoroutine(PullInfo());
    }

    public void OnMouseDown()
    {
        gameManager.showConfirm(text.text, element.text);
    }

    IEnumerator PullInfo()
    {
        //it cant find gameManager until a second after load
        yield return new WaitForSeconds(1);
        if (!gameManager.startOfGame)
        {
            gameManager.saveEnemyInfo(text.text, element.text);
        }
        
    }
}
