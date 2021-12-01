using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    GameObject confirmCanvas;
    private string text;
    private string element;
    private string enemyText;
    private string enemyElement;
    public Card card;
    public bool startOfGame = true;
    public TextMeshProUGUI scoreText;
    int enemyScore = 0;
    int youScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        confirmCanvas = GameObject.FindGameObjectWithTag("ConfirmCanvas");
    }

    public void showConfirm(string t, string e)
    {
        confirmCanvas.transform.Find("Confirm").gameObject.SetActive(true);
        confirmCanvas.transform.Find("Cancel").gameObject.SetActive(true);
        text = t;
        element = e;
        Debug.Log("My Number" + t);
        Debug.Log("My Element" + e);
        
    }

    public void confirmSelection()
    {
        Debug.Log("Number:" + text);
        Debug.Log("Element:" + element);
        confirmCanvas.transform.Find("Confirm").gameObject.SetActive(false);
        confirmCanvas.transform.Find("Cancel").gameObject.SetActive(false);
        startOfGame = false;
        card.generateCard(-10);
    }

    public void cancelSelection()
    {
        confirmCanvas.transform.Find("Confirm").gameObject.SetActive(false);
        confirmCanvas.transform.Find("Cancel").gameObject.SetActive(false);
    }

    public void saveEnemyInfo(string t, string e)
    {
        Debug.Log("Enemy Number " + t);
        Debug.Log("Enemy Element " + e);
        enemyElement = e;
        enemyText = t;
        Compete();
    }

    //E: 0 - U: 0

    public void Compete()
    {
        if(enemyElement == element)
        {
            Debug.Log("Both are the same element, compare numbers");
            int enemy = int.Parse(enemyText);
            int you = int.Parse(text);
            if(enemy < you)
            {
                Debug.Log("You have higher number, you +1");
                youScore++;
            } else
            {
                Debug.Log("Enemy has higher number, enemy +1");
                enemyScore++;
            }
        } else
        {
            if(enemyElement == "Rock" && element == "Scissors")
            {
                Debug.Log("Rock beats scissors, enemy +1");
                enemyScore++;
            } else if (enemyElement == "Scissors" && element == "Paper")
            {
                Debug.Log("scissors beats paper, enemy +1");
                enemyScore++;
            } else if (enemyElement == "Paper" && element == "Rock")
            {
                Debug.Log("paper beats rock, enemy +1");
                enemyScore++;
            } else if (element == "Rock" && enemyElement == "Scissors")
            {
                Debug.Log("Rock beats scissors, you +1");
                youScore++;
            } else if (element == "Scissors" && enemyElement == "Paper")
            {
                Debug.Log("scissors beats paper, you +1");
                youScore++;
            } else if(element == "Paper" && enemyElement == "Rock")
            {
                Debug.Log("paper beats rock, you +1");
                youScore++;
            } else
            {
                Debug.Log("Something went wrong");
            }
        }
    }

    public void Update()
    {
        scoreText.text = "E: " + enemyScore + " - U: " + youScore;
    }
}
