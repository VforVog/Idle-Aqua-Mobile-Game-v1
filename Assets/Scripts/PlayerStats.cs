using UnityEngine;
using System.Numerics;

public class PlayerStats : MonoBehaviour
{
    public double startWater = 0;
    public static double water;
    public static double waterTier ;
    public static double currentRunWater;
    public static double lifetimeWater;
    public static double currentRunOxygen;
    public static double lifetimeOxygen;
    public static double currentRunFish;
    public static double lifetimeFish;


    public static double trees;
    public static double lake;
    
    public static double oxygen;
    public static double fish;


    // Start is called before the first frame update
    void Start()
    {
        water = startWater;
        currentRunWater = startWater;
        lifetimeWater = startWater;
        waterTier = 0;
        currentRunOxygen = 0;
        lifetimeOxygen = 0;
        currentRunFish = 0;
        lifetimeFish = 0;
    }

    public static void GainWater(double waterGained)
    {
        water += waterGained;
        currentRunWater += waterGained;
        lifetimeWater += waterGained;
    }

        public static void GainOxygen(double oxygenGained)
    {
        oxygen += oxygenGained;
        currentRunOxygen += oxygenGained;
        lifetimeOxygen += oxygenGained;
    }

          public static void GainFish(double fishGained)
    {
        fish += fishGained;
        currentRunFish += fishGained;
        lifetimeFish += fishGained;
    }

    public static void GainTrees(double treesGained)
    {
        trees += treesGained;
    }

    public static void GainLake(double lakeGained)
    {
        lake += lakeGained;
    }

    


}

