using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ExitGame(string level)
    {
        Debug.Log("Nivel al que moverse: "+level);
        SceneManager.LoadScene(level);
    }

    public void LoadGame(string level)
    {
        Debug.Log("Nivel al que moverse: "+level);
        SceneManager.LoadScene(level);
    }
}
