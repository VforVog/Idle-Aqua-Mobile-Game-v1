using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenGainProduction : MonoBehaviour
{
    public Text oxygenText;
    public double oxygenProductionRate;
    public float oxygenProductionDelay;

    void Start()
    {
        StartCoroutine(OxygenProductionCalc());
    }

  
IEnumerator OxygenProductionCalc()
    {
        while (true)
        {
            // execute block of code here

          
            double oxygenProduced = PlayerStats.trees * oxygenProductionRate;
            PlayerStats.GainOxygen(oxygenProduced);
            oxygenText.text = PlayerStats.oxygen.NumberFormating() + " oxygen";
 
            // delay till next gain
            yield return new WaitForSeconds(oxygenProductionDelay);
        }
    }
}
