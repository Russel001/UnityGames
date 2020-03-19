using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_Panel_Premium : MonoBehaviour
{
    public GameObject Panel_Premium;
    public GameObject Text_News_Premium_01;
    public GameObject Text_News_Premium_02;

    public GUIManager gUIManager;

    private string ItemNewsTempString;
    private int ItemNewsTempInt;
    private int ItemRandomInt;

    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();
    }

    public void OpenPanel()
    {
        if (Panel_Premium != null)
        {
            Panel_Premium.SetActive(true);

            ItemNewsTempInt = Random.Range(1, 4);
            ItemRandomInt = Random.Range(1, 10);

            gUIManager.ItemNewsInt = ItemNewsTempInt;

            switch (ItemRandomInt)
            {
                case 2:
                    gUIManager.ItemNewsString = "Plant";
                    break;
                case 3:
                    gUIManager.ItemNewsString = "Meat";
                    break;
                case 4:
                    gUIManager.ItemNewsString = "Fruit";
                    break;
                case 5:
                    gUIManager.ItemNewsString = "Herb";
                    break;
                case 6:
                    gUIManager.ItemNewsString = "Mineral";
                    break;
                case 7:
                    gUIManager.ItemNewsString = "Wood";
                    break;
                case 8:
                    gUIManager.ItemNewsString = "Weapon";
                    break;
                case 9:
                    gUIManager.ItemNewsString = "Tool";
                    break;
                default:
                    gUIManager.ItemNewsString = "Water";
                    break;
            }

            if (ItemRandomInt == 8 || ItemRandomInt == 9)
            {
                Text_News_Premium_01.GetComponent<Text>().text = "Good News! " + gUIManager.ItemNewsString + "s are being priced lower by...";
            }
            else
            {
                Text_News_Premium_01.GetComponent<Text>().text = "Good News! " + gUIManager.ItemNewsString + "s are being priced higher by...";
            }
            Text_News_Premium_02.GetComponent<Text>().text = ItemNewsTempInt.ToString() + " Times! Goodbye!";
        }
    }

    public void ClosePanel()
    {
        if (Panel_Premium != null)
        {
            Panel_Premium.SetActive(false);
        }

    }


    //public void ClosePanel()
    //{
      //  StartCoroutine(Delay());

        //if (Panel_Premium != null)
        //{
          //  Panel_Premium.SetActive(false);
        //}

    //}

    //IEnumerator Delay()
    //{
      //  yield return new WaitForSeconds(1);

        //if (Panel_Premium != null)
        //{
          //  Panel_Premium.SetActive(false);
        //}
    //}


}
