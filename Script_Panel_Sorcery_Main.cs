using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_Panel_Sorcery_Main: MonoBehaviour
{
    public GameObject Panel_Potion;
    public GameObject Panel_In_App;

    public GameObject Text_Merchant_In_App_02;
    public GameObject Text_Merchant_Potion_01;
    public GameObject Text_Merchant_Potion_02;

    public GameObject Button_Yes_Potion;

    public GUIManager gUIManager;

    private int PotionPriceInt = 20; //The amount in gold of 10 moves

    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();

    }

    public void OpenPanel_Potion()
    {
        if (Panel_Potion != null)
        {
            gUIManager.ItemCurrentString = "Potion";

            Panel_Potion.SetActive(true);
            Button_Yes_Potion.SetActive(true);

            if (Panel_Potion != null)
            {
                gUIManager.ItemCurrentString = "Potion";

                Panel_Potion.SetActive(true);
                Button_Yes_Potion.SetActive(true);

                Text_Merchant_Potion_01.GetComponent<Text>().text = "Would you like to buy 10 moves for...";

                gUIManager.SoldPotionPriceInt = PotionPriceInt / Random.Range(1,4) ; 

                if (gUIManager.SoldPotionPriceInt > gUIManager.score)
                {
                    Button_Yes_Potion.SetActive(false);
                    Text_Merchant_Potion_02.GetComponent<Text>().text = "Oops! You don't have enough Gold!";
                }
                else
                {
                    Text_Merchant_Potion_02.GetComponent<Text>().text = gUIManager.SoldPotionPriceInt.ToString() + " Gold?";
                }

            }
        }
    }

    public void BuyPotion()
    {
        gUIManager.moveCounter = gUIManager.moveCounter + 10;
        gUIManager.moveCounterTxt.text = gUIManager.moveCounter.ToString();

        gUIManager.score = gUIManager.score - gUIManager.SoldPotionPriceInt;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally

        ClosePanel_Potion();
    }

    public void OpenPanel_In_App()
    {
        if (Panel_In_App != null)
        {
            gUIManager.ItemCurrentString = "In_App";
            //Debug.Log("Plant");

            Text_Merchant_In_App_02.GetComponent<Text>().text = "Watch Ads - Watch an Ad to get 10 more moves to continue playing the game.";


            Panel_In_App.SetActive(true);

        }
    }

    public void ClosePanel_Potion()
    {
        if (Panel_Potion != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Potion.SetActive(false);
        }
    }

    public void ClosePanel_In_App()
    {
        if (Panel_In_App != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");



            Panel_In_App.SetActive(false);
        }
    }
}
