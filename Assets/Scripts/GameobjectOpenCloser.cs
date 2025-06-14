using UnityEngine;

public class GameobjectOpenCloser: MonoBehaviour
{

    public GameObject objectToChange;

    public void OpenObject()
    {
        if (objectToChange != null)
        {
            objectToChange.SetActive(true);
        }
    }

    public void CloseObect()
    {
        if (objectToChange != null)
        {
            objectToChange.SetActive(false);
        }
    }
}
