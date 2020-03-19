using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_Panel_Potion_Main : MonoBehaviour
{
}
/*
    public GameObject Text_Merchant_Potion_01;
    public GameObject Text_Merchant_Potion_02;
    public GameObject Button_No;
    public GameObject Button_Yes;

    public GUIManager gUIManager;

    private int PotionPriceInt = 10; 

    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();

        Button_Yes.SetActive(true);
        Button_No.SetActive(true);
        Text_Merchant_Potion_01.GetComponent<Text>().text = "Are you buying Potions? I'm willing to sell each for...";
        Randomizer();
    }

    public void Refresh()
    {
        Button_Yes.SetActive(true);
        Button_No.SetActive(true);
        Text_Merchant_Potion_01.GetComponent<Text>().text = "Are you buying Potions? I'm willing to sell each for...";
        Randomizer();
    } 


    public void NoAnswer()
    {
        Randomizer();
        //Debug.Log("No= " + gUIManager.PriceRandomInt.ToString());
    }


    public void YesAnswer()
    {
        Text_Merchant_Potion_01.GetComponent<Text>().text = "Sold for...";
        if (gUIManager.ItemNewsString == "Potion")
        {
            if (gUIManager.ItemNewsInt == 1)
            {
                if (gUIManager.score >= PotionPriceInt * 1)
                {
                    gUIManager.moveCounter = gUIManager.moveCounter + 5;
                    gUIManager.score = gUIManager.score - (PotionPriceInt * 1);
                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 1).ToString();
                } 
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }
            }
            else if (gUIManager.ItemNewsInt == 2)
            {
                if (gUIManager.score >= PotionPriceInt * 2)
                {
                    gUIManager.moveCounter = gUIManager.moveCounter + 5;
                    gUIManager.score = gUIManager.score - (PotionPriceInt * 2);
                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 2).ToString();
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }
            }
            else if (gUIManager.ItemNewsInt == 3)
            {
                if (gUIManager.score >= PotionPriceInt * 3)
                {
                    gUIManager.moveCounter = gUIManager.moveCounter + 5;
                    gUIManager.score = gUIManager.score - (PotionPriceInt * 3);
                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 3).ToString();
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }
            }
        } 
        else
        {
            if (gUIManager.PriceRandomInt > 0 && gUIManager.PriceRandomInt < 50)
            {
                Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry! Not for sale!";
            }
            else if (gUIManager.PriceRandomInt > 50 && gUIManager.PriceRandomInt < 90)
            {
                if (gUIManager.score >= (PotionPriceInt * 3))
                {
                    gUIManager.moveCounter = gUIManager.moveCounter + 5;
                    gUIManager.score = gUIManager.score - (PotionPriceInt * 3);

                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 3).ToString() + " Gold!";
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }
            }
            else if (gUIManager.PriceRandomInt > 90 && gUIManager.PriceRandomInt < 99)
            {
                if (gUIManager.score >= (PotionPriceInt * 2))
                {
                    gUIManager.moveCounter = gUIManager.moveCounter + 5;
                    gUIManager.score = gUIManager.score - (PotionPriceInt * 2);

                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 2).ToString() + " Gold!";
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }
            }
            else if (gUIManager.PriceRandomInt > 99)
            {
                if (gUIManager.score >= (PotionPriceInt * 1))
                {
                    gUIManager.moveCounter = gUIManager.moveCounter + 5;
                    gUIManager.score = gUIManager.score - (PotionPriceInt * 1);

                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 1).ToString() + " Gold!";
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }

            }


        }

        gUIManager.ItemNewsString = "";
        gUIManager.ItemNewsInt = 0;

        gUIManager.moveCounterTxt.text = gUIManager.moveCounter.ToString(); //:Update displays globally
        gUIManager.scoreTxt.text = gUIManager.score.ToString();
        //gUIManager.PotionDotSumInt = 0;

        Button_No.SetActive(false);
        Button_Yes.SetActive(false);
        //Debug.Log("Yes= " + gUIManager.PriceRandomInt.ToString());
    }


    public void Randomizer()
    {
        if (gUIManager.ItemNewsString == "Potion")
        {
            if (gUIManager.ItemNewsInt == 1)
            {
                Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 1).ToString() + " Gold!";
            }
            else if (gUIManager.ItemNewsInt == 2)
            {
                Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 2).ToString() + " Gold!";
            } 
            else if (gUIManager.ItemNewsInt == 3)
            {
                Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 3).ToString() + " Gold!";
            }
        } 
        else
        {
            gUIManager.PriceRandomInt = Random.Range(1, 100);
            if (gUIManager.PriceRandomInt > 0 && gUIManager.PriceRandomInt < 50)
            {
                Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry! Not for sale!";
            }
            else if (gUIManager.PriceRandomInt > 50 && gUIManager.PriceRandomInt < 90)
            {
                if (gUIManager.score >= (PotionPriceInt * 3))
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 3).ToString() + " Gold!";
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }
            }
            else if (gUIManager.PriceRandomInt > 90 && gUIManager.PriceRandomInt < 99)
            {
                if (gUIManager.score >= (PotionPriceInt * 2))
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 2).ToString() + " Gold!";
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }
            }
            else if (gUIManager.PriceRandomInt > 99)
            {
                if (gUIManager.score >= (PotionPriceInt * 1))
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = (PotionPriceInt * 1).ToString() + " Gold!";
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Sorry, you don't have enough gold!";
                }

            }
        }

    }
}
*/