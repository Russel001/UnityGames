using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_Panel_Fairy : MonoBehaviour
{
    public GameObject Panel_Fairy;
    public GameObject Text_Ally_Fairy_01;
    public GameObject Text_Ally_Fairy_02;

    public GUIManager gUIManager;
    public ScriptTextPanelStatus scriptTextPanelStatus;

    private int ValueRandomInt;

    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();
        scriptTextPanelStatus = FindObjectOfType<ScriptTextPanelStatus>();
    }

    public void OpenPanel()
    {
        if (Panel_Fairy != null)
        {
            Panel_Fairy.SetActive(true);

            ValueRandomInt = Random.Range(1, 15);

            gUIManager.HerbDotSumInt = gUIManager.HerbDotSumInt + ValueRandomInt; ;

            //Below not working updated somewhere else in game maybe in status_panel
            //scriptTextPanelStatus.TextStatusHerb.GetComponent<Text>().text = gUIManager.HerbDotSumInt.ToString();

            Text_Ally_Fairy_01.GetComponent<Text>().text = "Hello Friend! I would give you ... ";
            Text_Ally_Fairy_02.GetComponent<Text>().text = ValueRandomInt.ToString() + " herbs! Goodbye!";
        }
    }

    public void ClosePanel()
    {
        if (Panel_Fairy != null)
        {
            Panel_Fairy.SetActive(false);
        }
    }
}
