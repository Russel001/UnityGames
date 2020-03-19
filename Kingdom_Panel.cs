using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Kingdom_Panel : MonoBehaviour
{
    public GameObject Panel_Kingdom;

    //public Text HealthStatusText;

    public void OpenPanel()
    {
        if (Panel_Kingdom != null)
        {
            Panel_Kingdom.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (Panel_Kingdom != null)
        {
            Panel_Kingdom.SetActive(false);
        }
    }


}
