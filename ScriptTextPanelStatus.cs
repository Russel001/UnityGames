using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScriptTextPanelStatus : MonoBehaviour
{
    public GameObject TextStatusHealth;
    public GameObject TextStatusGold;
    public GameObject TextStatusWeapon;
    public GameObject TextStatusTool;
    public GameObject TextStatusWater;
    public GameObject TextStatusPlant;
    public GameObject TextStatusMeat;
    public GameObject TextStatusFruit;
    public GameObject TextStatusHerb;
    public GameObject TextStatusMineral;
    public GameObject TextStatusWood;

    public GUIManager gUIManager;
    //public int score; //<-

    // Start is called before the first frame update
    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();

        UpdateTextStatusFunction(); //<<-
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTextStatusFunction(); //<<-
    }

    public void UpdateTextStatusFunction() //<--
    {
        
        TextStatusHealth.GetComponent<Text>().text = gUIManager.moveCounterTxt.text;
        TextStatusGold.GetComponent<Text>().text = gUIManager.scoreTxt.text;
        TextStatusWeapon.GetComponent<Text>().text = gUIManager.WeaponDotSumInt.ToString();
        TextStatusTool.GetComponent<Text>().text = gUIManager.ToolDotSumInt.ToString();
        TextStatusWater.GetComponent<Text>().text = gUIManager.WaterDotSumInt.ToString();
        TextStatusPlant.GetComponent<Text>().text = gUIManager.PlantDotSumInt.ToString();
        TextStatusMeat.GetComponent<Text>().text = gUIManager.MeatDotSumInt.ToString();
        TextStatusFruit.GetComponent<Text>().text = gUIManager.FruitDotSumInt.ToString();
        TextStatusHerb.GetComponent<Text>().text = gUIManager.HerbDotSumInt.ToString();
        TextStatusMineral.GetComponent<Text>().text = gUIManager.MineralDotSumInt.ToString();
        TextStatusWood.GetComponent<Text>().text = gUIManager.WoodDotSumInt.ToString();
    }
}
