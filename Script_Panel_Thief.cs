using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_Panel_Thief : MonoBehaviour
{
    public GameObject Panel_Thief;
    public GameObject Text_Enemy_Thief_01;
    public GameObject Text_Enemy_Thief_02;

    public GUIManager gUIManager;

    private int AmountMaxInt;
    private int HealthDamageMaxInt;
    private int HealthDamageInt;

    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();
    }


    public void OpenPanel()
    {
        if (Panel_Thief != null)
        {
            Panel_Thief.SetActive(true);

            HealthDamageMaxInt = Mathf.RoundToInt(gUIManager.moveCounter / 5) - gUIManager.WeaponDotSumInt;
            HealthDamageInt = Mathf.Abs(Random.Range(1, HealthDamageMaxInt));
            Text_Enemy_Thief_01.GetComponent<Text>().text = "Damage to health = " + HealthDamageInt.ToString();
            gUIManager.moveCounter = gUIManager.moveCounter - HealthDamageInt;
            gUIManager.moveCounterTxt.text = gUIManager.moveCounter.ToString(); //:Update displays globally

            AmountMaxInt = Mathf.RoundToInt(gUIManager.score / 5);
            gUIManager.PriceRandomInt = Mathf.Abs(Random.Range(1, AmountMaxInt));
            Text_Enemy_Thief_02.GetComponent<Text>().text = "Gold Lost = " + gUIManager.PriceRandomInt.ToString();
            gUIManager.score = gUIManager.score - gUIManager.PriceRandomInt;
            gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
       
        }
    }

    public void ClosePanel()
    {
        if (Panel_Thief != null)
        {
            Panel_Thief.SetActive(false);
        }
    }
}
