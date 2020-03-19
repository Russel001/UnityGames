using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Help : MonoBehaviour
{
    public GameObject PanelHelp;
    public GameObject PanelHelp02;

    //public Text HealthStatusText;

    public void OpenPanel()
    {
        if (PanelHelp != null)
        {
            PanelHelp.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if ((PanelHelp != null) && (PanelHelp02 != null))
        {
            PanelHelp.SetActive(false);
            PanelHelp02.SetActive(true);
        }
    }

    public void ClosePanel02()
    {
        if ((PanelHelp != null) && (PanelHelp02 != null))
        {
            PanelHelp02.SetActive(false);
        }
    }
}
