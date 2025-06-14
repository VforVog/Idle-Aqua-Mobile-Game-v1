using UnityEngine.UI;
using UnityEngine;

public class StatsUI : MonoBehaviour
{

    public Text waterText;
    public Text currentRunWaterText;
    public Text lifetimeWaterText;
    public Text currentRunOxygenText;
    public Text lifetimeOxygenText;
    public Text currentRunFishText;
    public Text lifetimeFishText;

    //Εδω φτιαζνουμε τα tier για Millinio, Billion, και αυατ στο GameUI


    // Update is called once per frame
    void Update()
    {
        waterText.text = PlayerStats.water.NumberFormating() + " Water";
        currentRunWaterText.text = PlayerStats.currentRunWater.NumberFormating() + " Current run water";
        lifetimeWaterText.text = PlayerStats.lifetimeWater.NumberFormating() + " Lifetime water";
        currentRunOxygenText.text = PlayerStats.currentRunOxygen.NumberFormating() + " Current Oxygen";
        lifetimeOxygenText.text = PlayerStats.lifetimeOxygen.NumberFormating() + " Lifetime Oxygen";
        currentRunFishText.text = PlayerStats.currentRunFish.NumberFormating() + " Current Fishes";
        lifetimeFishText.text = PlayerStats.lifetimeFish.NumberFormating() + " Lifetime Fishes";

    }

}



