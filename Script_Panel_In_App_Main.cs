using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Monetization;

public class Script_Panel_In_App_Main : MonoBehaviour
{
    //public GameObject Text_Merchant_In_App_01;
    public GameObject Text_Merchant_In_App_02;
    public GameObject Button_In_App;
    public GameObject Button_Watch_Ads;

    public GUIManager gUIManager;

    //private string store_id = "3154739"; // Apple App ID
    private string store_id = "3154738"; // Android App ID

    private string rewarded_video_ad = "rewardedVideo";


    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();

        Monetization.Initialize(store_id, false);

    }

    /*
    private void Update()
    {
        //Used only as test- copied from a video tutorial
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Is video ready to be played
            if (Monetization.IsReady(rewarded_video_ad))
            {
                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent(rewarded_video_ad) as ShowAdPlacementContent;

                if (ad != null)
                {
                    ad.Show();
                }
            }
        }

    }
    */
    /*
    public void Buy_Moves()
    {

    }
    */

    public void Watch_Ads()
    {
            //Is video ready to be played
            if (Monetization.IsReady(rewarded_video_ad))
            {
                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent(rewarded_video_ad) as ShowAdPlacementContent;

                if (ad != null)
                {
                    ad.Show();

                    gUIManager.moveCounter = gUIManager.moveCounter + 10;
                    gUIManager.moveCounterTxt.text = gUIManager.moveCounter.ToString();
                } else
                {
                    Text_Merchant_In_App_02.GetComponent<Text>().text = "No Ad to display at the moment. Please try again later.";
                }
            }

    }

}






