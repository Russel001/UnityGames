using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script_Panel_Kingdom: MonoBehaviour
{
    public GameObject Panel_Water;
    public GameObject Panel_Plant;
    public GameObject Panel_Meat;
    public GameObject Panel_Fruit;
    public GameObject Panel_Herb;
    public GameObject Panel_Mineral;
    public GameObject Panel_Wood;
    public GameObject Panel_Weapon;
    public GameObject Panel_Tool;

    public GameObject Text_Merchant_Tool_01;
    public GameObject Text_Merchant_Tool_02;
    public GameObject Text_Merchant_Weapon_01;
    public GameObject Text_Merchant_Weapon_02;

    public GameObject Text_Merchant_Water_01;
    public GameObject Text_Merchant_Water_02;
    public GameObject Text_Merchant_Plant_01;
    public GameObject Text_Merchant_Plant_02;
    public GameObject Text_Merchant_Meat_01;
    public GameObject Text_Merchant_Meat_02;
    public GameObject Text_Merchant_Fruit_01;
    public GameObject Text_Merchant_Fruit_02;
    public GameObject Text_Merchant_Herb_01;
    public GameObject Text_Merchant_Herb_02;
    public GameObject Text_Merchant_Mineral_01;
    public GameObject Text_Merchant_Mineral_02;
    public GameObject Text_Merchant_Wood_01;
    public GameObject Text_Merchant_Wood_02;

    public GameObject Button_Yes_Water;
    public GameObject Button_Yes_Plant;
    public GameObject Button_Yes_Meat;
    public GameObject Button_Yes_Fruit;
    public GameObject Button_Yes_Herb;
    public GameObject Button_Yes_Mineral;
    public GameObject Button_Yes_Wood;

    public GameObject Button_Yes_Weapon;
    public GameObject Button_Yes_Tool;

    public GUIManager gUIManager;

    private int ToolPriceInt = 100;
    private int WeaponPriceInt = 100;

    void Start()
    {
        gUIManager = FindObjectOfType<GUIManager>();

    }

    public void OpenPanel_Water()
    {
        if (Panel_Water != null)
        {
            gUIManager.ItemCurrentString = "Water";

            Panel_Water.SetActive(true);
            Button_Yes_Water.SetActive(true);

            Text_Merchant_Water_01.GetComponent<Text>().text = "Would you like to sell each water for ...";

            if (gUIManager.ItemNewsString == "Water")
            {
                gUIManager.SoldToolPriceInt = gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = Random.Range(1, 4);
            }

            if (gUIManager.WaterDotSumInt == 0)
            {
                Button_Yes_Water.SetActive(false);
                Text_Merchant_Water_02.GetComponent<Text>().text = "Oops! You have no water to sell!";
            }
            else
            {
                Text_Merchant_Water_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }
        }
    }

    public void SellWater()
    {
        gUIManager.score = gUIManager.score + (gUIManager.SoldToolPriceInt * gUIManager.WaterDotSumInt);
        gUIManager.WaterDotSumInt = 0;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        ClosePanel_Water();
    }


    public void OpenPanel_Plant()
    {
        if (Panel_Plant != null)
        {
            gUIManager.ItemCurrentString = "Plant";

            Panel_Plant.SetActive(true);
            Button_Yes_Plant.SetActive(true);

            Text_Merchant_Plant_01.GetComponent<Text>().text = "Would you like to sell each plant for ...";

            if (gUIManager.ItemNewsString == "Plant")
            {
                gUIManager.SoldToolPriceInt = gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = Random.Range(1, 4);
            }

            if (gUIManager.PlantDotSumInt == 0)
            {
                Button_Yes_Plant.SetActive(false);
                Text_Merchant_Plant_02.GetComponent<Text>().text = "Oops! You have no plant to sell!";
            }
            else
            {
                Text_Merchant_Plant_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }

        }
    }

    public void SellPlant()
    {
        gUIManager.score = gUIManager.score + (gUIManager.SoldToolPriceInt * gUIManager.PlantDotSumInt);
        gUIManager.PlantDotSumInt = 0;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        ClosePanel_Plant();
    }

    public void OpenPanel_Meat()
    {
        if (Panel_Meat != null)
        {
            gUIManager.ItemCurrentString = "Meat";

            Panel_Meat.SetActive(true);
            Button_Yes_Meat.SetActive(true);

            Text_Merchant_Meat_01.GetComponent<Text>().text = "Would you like to sell each meat for ...";

            if (gUIManager.ItemNewsString == "Meat")
            {
                gUIManager.SoldToolPriceInt = gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = Random.Range(1, 4);
            }

            if (gUIManager.MeatDotSumInt == 0)
            {
                Button_Yes_Meat.SetActive(false);
                Text_Merchant_Meat_02.GetComponent<Text>().text = "Oops! You have no meat to sell!";
            }
            else
            {
                Text_Merchant_Meat_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }
        }
    }

    public void SellMeat()
    {
        gUIManager.score = gUIManager.score + (gUIManager.SoldToolPriceInt * gUIManager.MeatDotSumInt);
        gUIManager.MeatDotSumInt = 0;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        ClosePanel_Meat();
    }

    public void OpenPanel_Fruit()
    {
        if (Panel_Fruit != null)
        {
            gUIManager.ItemCurrentString = "Fruit";

            Panel_Fruit.SetActive(true);
            Button_Yes_Fruit.SetActive(true);

            Text_Merchant_Fruit_01.GetComponent<Text>().text = "Would you like to sell each fruit for ...";

            if (gUIManager.ItemNewsString == "Fruit")
            {
                gUIManager.SoldToolPriceInt = gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = Random.Range(1, 4);
            }

            if (gUIManager.FruitDotSumInt == 0)
            {
                Button_Yes_Fruit.SetActive(false);
                Text_Merchant_Fruit_02.GetComponent<Text>().text = "Oops! You have no fruit to sell!";
            }
            else
            {
                Text_Merchant_Fruit_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }
        }
    }

    public void SellFruit()
    {
        gUIManager.score = gUIManager.score + (gUIManager.SoldToolPriceInt * gUIManager.FruitDotSumInt);
        gUIManager.FruitDotSumInt = 0;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        ClosePanel_Fruit();
    }

    public void OpenPanel_Herb()
    {
        if (Panel_Herb != null)
        {
            gUIManager.ItemCurrentString = "Herb";

            Panel_Herb.SetActive(true);
            Button_Yes_Herb.SetActive(true);

            Text_Merchant_Herb_01.GetComponent<Text>().text = "Would you like to sell each herb for ...";

            if (gUIManager.ItemNewsString == "Herb")
            {
                gUIManager.SoldToolPriceInt = gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = Random.Range(1, 4);
            }

            if (gUIManager.HerbDotSumInt == 0)
            {
                Button_Yes_Herb.SetActive(false);
                Text_Merchant_Herb_02.GetComponent<Text>().text = "Oops! You have no herb to sell!";
            }
            else
            {
                Text_Merchant_Herb_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }
        }
    }

    public void SellHerb()
    {
        gUIManager.score = gUIManager.score + (gUIManager.SoldToolPriceInt * gUIManager.HerbDotSumInt);
        gUIManager.HerbDotSumInt = 0;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        ClosePanel_Herb();
    }

    public void OpenPanel_Mineral()
    {
        if (Panel_Mineral != null)
        {
            gUIManager.ItemCurrentString = "Mineral";

            Panel_Mineral.SetActive(true);
            Button_Yes_Mineral.SetActive(true);

            Text_Merchant_Mineral_01.GetComponent<Text>().text = "Would you like to sell each mineral for ...";

            if (gUIManager.ItemNewsString == "Mineral")
            {
                gUIManager.SoldToolPriceInt = gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = Random.Range(1, 4);
            }

            if (gUIManager.MineralDotSumInt == 0)
            {
                Button_Yes_Mineral.SetActive(false);
                Text_Merchant_Mineral_02.GetComponent<Text>().text = "Oops! You have no mineral to sell!";
            }
            else
            {
                Text_Merchant_Mineral_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }
        }
    }

    public void SellMineral()
    {
        gUIManager.score = gUIManager.score + (gUIManager.SoldToolPriceInt * gUIManager.MineralDotSumInt);
        gUIManager.MineralDotSumInt = 0;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        ClosePanel_Mineral();
    }

    public void OpenPanel_Wood()
    {
        if (Panel_Wood != null)
        {
            gUIManager.ItemCurrentString = "Wood";

            Panel_Wood.SetActive(true);
            Button_Yes_Wood.SetActive(true);

            Text_Merchant_Wood_01.GetComponent<Text>().text = "Would you like to sell each wood for ...";

            if (gUIManager.ItemNewsString == "Wood")
            {
                gUIManager.SoldToolPriceInt = gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = Random.Range(1, 4);
            }

            if (gUIManager.WoodDotSumInt == 0)
            {
                Button_Yes_Wood.SetActive(false);
                Text_Merchant_Wood_02.GetComponent<Text>().text = "Oops! You have no wood to sell!";
            }
            else
            {
                Text_Merchant_Wood_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }
        }
    }

    public void SellWood()
    {
        gUIManager.score = gUIManager.score + (gUIManager.SoldToolPriceInt * gUIManager.WoodDotSumInt);
        gUIManager.WoodDotSumInt = 0;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        ClosePanel_Wood();
    }

    public void OpenPanel_Weapon()
    {
        if (Panel_Weapon != null)
        {
            gUIManager.ItemCurrentString = "Weapon";
            //Debug.Log("Weapon");

            Panel_Weapon.SetActive(true);
            Button_Yes_Weapon.SetActive(true);

            Text_Merchant_Weapon_01.GetComponent<Text>().text = "Would you like to buy a weapon for...";

            if (gUIManager.ItemNewsString == "Weapon")
            {
                gUIManager.SoldToolPriceInt = WeaponPriceInt / gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = WeaponPriceInt;
            }

            if (gUIManager.SoldToolPriceInt > gUIManager.score)
            {
                Button_Yes_Weapon.SetActive(false);
                Text_Merchant_Weapon_02.GetComponent<Text>().text = "Oops! You don't have enough Gold!";
            }
            else
            {
                Text_Merchant_Weapon_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }

        }
    }

    public void BuyWeapon()
    {
        gUIManager.WeaponDotSumInt = gUIManager.WeaponDotSumInt + 1;
        gUIManager.score = gUIManager.score - gUIManager.SoldToolPriceInt;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        ClosePanel_Weapon();
    }


    public void OpenPanel_Tool()
    {
        if (Panel_Tool != null)
        {
            gUIManager.ItemCurrentString = "Tool";

            Panel_Tool.SetActive(true);
            Button_Yes_Tool.SetActive(true);

            Text_Merchant_Tool_01.GetComponent<Text>().text = "Would you like to buy a tool for...";

            if (gUIManager.ItemNewsString == "Tool")
            {
                gUIManager.SoldToolPriceInt = ToolPriceInt / gUIManager.ItemNewsInt;
            }
            else
            {
                gUIManager.SoldToolPriceInt = ToolPriceInt;
            }

            if (gUIManager.SoldToolPriceInt > gUIManager.score) 
            {
                Button_Yes_Tool.SetActive(false);
                Text_Merchant_Tool_02.GetComponent<Text>().text = "Oops! You don't have enough Gold!";
            } 
            else
            {
                Text_Merchant_Tool_02.GetComponent<Text>().text = gUIManager.SoldToolPriceInt.ToString() + " Gold?";
            }

        }
    }

    public void BuyTool()
    {
        gUIManager.ToolDotSumInt = gUIManager.ToolDotSumInt + 1;
        gUIManager.score = gUIManager.score - gUIManager.SoldToolPriceInt;
        gUIManager.scoreTxt.text = gUIManager.score.ToString(); //:Update displays globally
        //Debug.Log("Check: " + gUIManager.SoldToolPriceInt);
        ClosePanel_Tool();
    }


    public void ClosePanel_Water()
    {
        if (Panel_Water != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Water.SetActive(false);
        }
    }

    public void ClosePanel_Plant()
    {
        if (Panel_Plant != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Plant.SetActive(false);
        }
    }


    public void ClosePanel_Meat()
    {
        if (Panel_Meat != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Meat.SetActive(false);
        }
    }


    public void ClosePanel_Fruit()
    {
        if (Panel_Fruit != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Fruit.SetActive(false);
        }
    }

    public void ClosePanel_Herb()
    {
        if (Panel_Herb != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Herb.SetActive(false);
        }
    }

    public void ClosePanel_Mineral()
    {
        if (Panel_Mineral != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Mineral.SetActive(false);
        }
    }

    public void ClosePanel_Wood()
    {
        if (Panel_Wood != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Wood.SetActive(false);
        }
    }

    public void ClosePanel_Weapon()
    {
        if (Panel_Weapon != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Weapon.SetActive(false);
        }
    }

    public void ClosePanel_Tool()
    {
    if (Panel_Tool != null)
        {
            gUIManager.ItemCurrentString = "";
            //Debug.Log("None");

            Panel_Tool.SetActive(false);
        }
    }

}
