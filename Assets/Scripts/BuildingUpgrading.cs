using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUpgrading : MonoBehaviour
{
    public BuildingStats buildingToUpgrade;
    public Text buildingTitleAndQuantity;
    public Text upgradeLevelPriceText;
    public Text buildingProductionInfo;
    public Text upgradeSpeedPriceText;

    private int[] multipliers = new int[] { 1, 5, 25, 100, 999 };
    private int currentMultiplier = 0;
    public int multiplier = 1;
    public Text multiplierButtonText;

    void Start()
    {
        buildingToUpgrade.productionSpeed = buildingToUpgrade.startingProductionSpeed;
        RefreshPricesAndInfoTexts();
        StartCoroutine(RefreshMaxPrice());
        StartCoroutine(BuildingHasBeenReset());

    }

    IEnumerator RefreshMaxPrice()
    {
        while (true)
        { 
            yield return new WaitUntil(() => multiplier >= 999);
            RefreshPricesAndInfoTexts();
        }
    }


    IEnumerator BuildingHasBeenReset()
    {
        while (true)
        {
            yield return new WaitUntil(() => buildingToUpgrade.buildingHasBeenReset);
            RefreshPricesAndInfoTexts();
            buildingToUpgrade.buildingHasBeenReset = false;
        }
    }
    

    public void UpgradeBuildingLevel()
    {
        if (PlayerStats.water < MultiplyPrice(buildingToUpgrade.upgradeCost))
        {
            Debug.Log("Not Enough water");
            return;
        }

        buildingToUpgrade.level += MultiplyQuantity(buildingToUpgrade.upgradeCost);
        RefreshPricesAndInfoTexts();
        PlayerStats.water -= MultiplyPrice(buildingToUpgrade.upgradeCost);
        return;
    }

    public void UpgradeBuildingSpeed()
    {
        if (PlayerStats.water < MultiplyPrice(buildingToUpgrade.upgradeCost))
        {
            Debug.Log("Not Enough water");
            return;
        }
        
        float setupQuantityWithPow = buildingToUpgrade.productionSpeed * Mathf.Pow(0.9f, (float)MultiplyQuantity(buildingToUpgrade.upgradeCost));
        buildingToUpgrade.productionSpeed =  Mathf.Max(setupQuantityWithPow, buildingToUpgrade.minProductionSpeed);
        RefreshPricesAndInfoTexts();
        PlayerStats.water -= MultiplyPrice(buildingToUpgrade.upgradeCost);
        return;
    }

    private double MultiplyPrice(double startingPrice)
    {
        return MultiplyQuantity(startingPrice) * startingPrice;
    }

    private double MultiplyQuantity(double Price)
    {
        //max is 999
        if (multiplier < 900)
        {
            return multiplier;
        }
        else
        {
            return Math.Floor(PlayerStats.water / Price);
        }
    }


    public void RotateMultiplayer()
    {
        currentMultiplier++;
        if (currentMultiplier >= multipliers.Length)
        {
            currentMultiplier = 0;
        }
        multiplier = multipliers[currentMultiplier];
        //999 is max
        if (multiplier < 900)
        {
            multiplierButtonText.text = "x" + multiplier;
        }
        else
        {
            multiplierButtonText.text = "Max";
        }
        RefreshPricesAndInfoTexts();
    }

    public void RefreshPricesAndInfoTexts()
    {
        buildingTitleAndQuantity.text = buildingToUpgrade.level.NumberFormating() + " " + buildingToUpgrade.buildingName;
        buildingProductionInfo.text = (buildingToUpgrade.production * buildingToUpgrade.level).NumberFormating() + " water every " + buildingToUpgrade.productionSpeed.ToString("F2") + " sec";
        upgradeLevelPriceText.text = MultiplyPrice(buildingToUpgrade.upgradeCost).NumberFormating() + " water for " + MultiplyQuantity(buildingToUpgrade.upgradeCost).NumberFormating();
        upgradeSpeedPriceText.text = MultiplyPrice(buildingToUpgrade.upgradeCost).NumberFormating() + " water for " + MultiplyQuantity(buildingToUpgrade.upgradeCost).NumberFormating();

    }

}
