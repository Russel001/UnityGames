using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_Panel_Sorcery : MonoBehaviour
{
    public GameObject Panel_Sorcery;

    //public Text HealthStatusText;

    public void OpenPanel()
    {
        if (Panel_Sorcery != null)
        {
            Panel_Sorcery.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (Panel_Sorcery != null)
        {
            Panel_Sorcery.SetActive(false);
        }
    }


}
