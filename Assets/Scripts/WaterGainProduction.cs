using UnityEngine;
using System.Collections;

public class WaterGainProduction : MonoBehaviour
{

    public BuildingStats thisBuilding;

    void Start()
    {
        StartCoroutine(Calculate());
    }


    IEnumerator Calculate()
    {
        while (true)
        {
            // execute block of code here

          
            double waterProduction = thisBuilding.production * thisBuilding.level;
            PlayerStats.GainWater(waterProduction);
            // delay till next gain
            yield return new WaitForSeconds(thisBuilding.productionSpeed);
        }
    }
}
