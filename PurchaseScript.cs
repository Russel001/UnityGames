using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseScript : MonoBehaviour
{
    public GUIManager gUIManager;

    // Start is called before the first frame update
    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();
    }

    // Update is called once per frame
    /*
    void Update()
    {
        
    }
    */
    public void BuyComplete(UnityEngine.Purchasing.Product product)
    {
        gUIManager.moveCounter = gUIManager.moveCounter + 50;
        gUIManager.moveCounterTxt.text = gUIManager.moveCounter.ToString();
        //Debug.Log("Purchase Complete");
    }

    public void BuyFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)
    {
        //Debug.Log("Purchase Failed");
    }
}
