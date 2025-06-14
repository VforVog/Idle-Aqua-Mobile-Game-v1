using UnityEngine;

[System.Serializable]
public class BuildingStats : MonoBehaviour
{
    public string buildingName;
    public string buildingInfo;
    public double startingUpgradeCost;
    public double upgradeCost;
    public double level;
    public double startingProduction;
    public double production;
    public float startingProductionSpeed;
    public float productionSpeed;
    public float startingMinProductionSpeed;
    public float minProductionSpeed;
    public bool buildingHasBeenReset = true;


    public void buildingReset()
    {
        level = 0;
        upgradeCost = startingUpgradeCost;
        production = startingProduction;
        productionSpeed = startingProductionSpeed;
        minProductionSpeed = startingMinProductionSpeed;
        buildingHasBeenReset = true;
    }
}
