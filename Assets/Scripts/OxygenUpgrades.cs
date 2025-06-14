using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UpgradeTypes{MinSpeedUpgrade, ProductionUpgrade, CostUpgrade};

public class OxygenUpgrades : MonoBehaviour
{
    public string upgradeName;
    public string upgradeInfo;

    public BuildingStats affectedBuilding;
    public double upgradePrice;
    public UpgradeTypes upgradeType;
    public double upgradePercentage;

    public void BuyUpgrade(){
        if (upgradeType == UpgradeTypes.MinSpeedUpgrade)
        {
            MinSpeedUpgrade();
        }else if (upgradeType == UpgradeTypes.ProductionUpgrade)
        {
            ProductionUpgrade();
        }else if (upgradeType == UpgradeTypes.CostUpgrade)
        {
            CostUpgrade();
        }
    }

    public void MinSpeedUpgrade(){
        if(useOxygen()){
            // i praksi gia na ginei % afksisi taxititas (100 simenei oti tha pesei i timi dia 2 ara tha ginei diplasio minSpeed)
            affectedBuilding.minProductionSpeed /= 1 + ((float)upgradePercentage / 100);
        }
    }

    public void ProductionUpgrade(){
        if(useOxygen()){
            affectedBuilding.production *= 1 + upgradePercentage/100;
        }
    }

    public void CostUpgrade(){
        if(useOxygen()){
            affectedBuilding.upgradeCost /= 1 + (upgradePercentage / 100);
        }
    }

    public bool useOxygen(){
        if (PlayerStats.oxygen < upgradePrice)
        {
            Debug.Log("Not Enough oxygen");
            return false;
        }
        PlayerStats.oxygen -= upgradePrice;
        return true;
    }

}
