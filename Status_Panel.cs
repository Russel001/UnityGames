using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Status_Panel : MonoBehaviour
{
    public GameObject Panel_Status;


    public void OpenPanel()
    {
        if (Panel_Status != null)
        {
            Panel_Status.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (Panel_Status != null)
        {
            Panel_Status.SetActive(false);
        }
    }


}
