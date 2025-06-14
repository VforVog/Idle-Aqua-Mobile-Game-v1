
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShowResetButton : MonoBehaviour
{
    public GameObject resetButton;
    public double resetThreshold = 100;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ButtonAppear());
    }

    public void HideButton()
    {
        resetButton.SetActive(false);
        StartCoroutine(ButtonAppear());
    }

    IEnumerator ButtonAppear()
    {
        yield return new WaitUntil(() => PlayerStats.currentRunWater >= resetThreshold);
        resetButton.SetActive(true);
    }

}
