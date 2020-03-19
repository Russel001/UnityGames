using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_Panel_Elf : MonoBehaviour
{
    public GameObject Panel_Elf;
    public GameObject Text_Ally_Elf_01;
    public GameObject Text_Ally_Elf_02;

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
        if (Panel_Elf != null)
        {
            Panel_Elf.SetActive(true);

            ValueRandomInt = Random.Range(1, 10);

            gUIManager.MineralDotSumInt = gUIManager.MineralDotSumInt + ValueRandomInt;

            //Below not working updated somewhere else in game maybe in status_panel
            //scriptTextPanelStatus.TextStatusMineral.GetComponent<Text>().text = gUIManager.MineralDotSumInt.ToString();

            Text_Ally_Elf_01.GetComponent<Text>().text = "Hello Friend! I would give you ... ";
            Text_Ally_Elf_02.GetComponent<Text>().text = ValueRandomInt.ToString() + " minerals! Goodbye!";
        }
    }

    public void ClosePanel()
    {
        if (Panel_Elf != null)
        {
            Panel_Elf.SetActive(false);
        }
    }
}
