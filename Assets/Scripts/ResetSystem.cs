using System;
using UnityEngine;
using UnityEngine.UI;

public class ResetSystem : MonoBehaviour
{
    public BuildingStats building1;
    public BuildingStats building2;
    public BuildingStats building3;
    public BuildingStats building4;
    public BuildingStats building5;
    public BuildingStats building6;
    public BuildingStats building7;

    public static bool resetTriggered = false;

    public Text treesResetText;
    public Text lakeResetText;

    public Text currentTreesText;
    public Text currentLakeText;

    private double treesToGain;
    private double lakeToGain;


    // Update is called once per frame
    void Update()
    {
        //TODO na valoume ena sovaro sistima gia to posa na pereneis kathe reset (profanos thelei tests kai mathimatika)
        //rounds down because int rounds down by default
        treesToGain = Math.Floor(PlayerStats.currentRunWater / 100 );
        lakeToGain = Math.Floor(PlayerStats.currentRunWater / 1000);

        treesResetText.text = "Gain " + treesToGain + " trees";
        lakeResetText.text = "Gain " + lakeToGain + " lake water";
    }

    public void ResetForTrees()
    {
        ResetGame();
        PlayerStats.GainTrees(treesToGain);
        currentTreesText.text = PlayerStats.trees + " Trees";
    }

    public void ResetForLake()
    {
        ResetGame();
        PlayerStats.GainLake(lakeToGain);
        currentLakeText.text = PlayerStats.lake + " Lake size";
    }

    //ResetGame calls everything that has to do with reseting the game, this may become bigger
    private void ResetGame()
    {
        ResetStats();
        HideStuff();
    }

    //ResetStats resets the stats, this may become bigger
    private void ResetStats()
    {
        resetTriggered = true;

        building1.buildingReset();
        building2.buildingReset();
        building3.buildingReset();
        building4.buildingReset();
        building5.buildingReset();
        building6.buildingReset();
        building7.buildingReset();

        PlayerStats.currentRunWater = 0;
        PlayerStats.water = 0;

        resetTriggered = false;
    }

    //HideStuff hides buttons, upgrades etc after the reset, this will become bigger (does nothing at the moment)
    private void HideStuff()
    {
    }

}
