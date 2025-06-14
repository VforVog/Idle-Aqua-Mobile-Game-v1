using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplier : MonoBehaviour
{
    private int[] multipliers = new int[] { 1, 5, 25, 100, 999 };
    private int currentMultiplier = 0;
    public static int multiplier = 1;
    public Text multiplierButtonText;

    public void RotateMultiplayer()
    {
        currentMultiplier++;
        if (currentMultiplier >= multipliers.Length)
        {
            currentMultiplier = 0;
        }
        multiplier = multipliers[currentMultiplier];
        //999 is max
        if (multiplier <900)
        {
            multiplierButtonText.text = "x" + multiplier;
        }
        else
        {
            multiplierButtonText.text = "Max";
        }
    }

}

