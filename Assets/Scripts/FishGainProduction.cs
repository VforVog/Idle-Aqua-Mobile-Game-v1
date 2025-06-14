using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishGainProduction : MonoBehaviour
{
    public Text fishText;
    public double fishProductionRate;
    public float fishProductionDelay;

    void Start()
    {
        StartCoroutine(FishProductionCalc());
    }

  
IEnumerator FishProductionCalc()
    {
        while (true)
        {
            // execute block of code here

          
            double fishProduced = PlayerStats.lake * fishProductionRate;
            PlayerStats.GainFish(fishProduced);
            fishText.text = PlayerStats.fish.NumberFormating() + " fishes";
 
            // delay till next gain
            yield return new WaitForSeconds(fishProductionDelay);
        }
    }
}
