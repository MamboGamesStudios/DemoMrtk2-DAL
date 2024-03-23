using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update

    public void GoToMenu()
    {
        SCManager.instance.LoadScene("Menu");
    }

    public void GoToGame()
    {
        SCManager.instance.LoadScene("Game");
    }

    public void GoToCredits()
    {
        SCManager.instance.LoadScene("Credits");
    }

}
