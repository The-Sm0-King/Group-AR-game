using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardOverlay : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI element;
    //public TextMeshProUGUI Name;
    GameObject confirmCanvas;

    // Start is called before the first frame update
    void Start()
    {
        confirmCanvas = GameObject.FindGameObjectWithTag("ConfirmCanvas");
        GenerateNumber();
        //GenerateElement();
    }

    public void GenerateNumber()
    {
        PickRandomNumber(10);
    }

    private void PickRandomNumber(int maxInt)
    {
        int randomNum = Random.Range(1, maxInt + 1);
        text.text = randomNum.ToString();
    }

    private void OnMouseDown()
    {
        //confirmCanvas = GameObject.FindGameObjectWithTag("ConfirmCanvas");
        confirmCanvas.transform.Find("Confirm").gameObject.SetActive(true);
        confirmCanvas.transform.Find("Cancel").gameObject.SetActive(true);
        //Debug.Log(Input.mousePosition);
        //string num = GetComponent<Text>().text;
        //Debug.Log("Number:" + text.text);
        //Debug.Log("Element:" + element.text);
    }

    public void confirmSelection()
    {
        Debug.Log("Number:" + text.text);
        Debug.Log("Element:" + element.text);
    }

    public void cancelSelection()
    {
        confirmCanvas.SetActive(false);
    }

}
