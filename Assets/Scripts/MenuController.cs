using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject ShopMenu;
    public GameObject LevelsMenu;

    CameraMovement camera;


    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMovement>();
    }



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


    public void ShowShop()
    {

        Debug.Log("Shop Opened");
        camera.ShowShopAnim();
        //ShopMenu.SetActive(true);
    }

    public void CloseShop()
    {
        Debug.Log("Shop Closed");
        camera.CloseShopAnim();
        //ShopMenu.SetActive(false);
    }

    public void ShowLevels()
    {

        Debug.Log("Levels Opened");
        camera.ShowLevelsAnim();
        //LevelsMenu.SetActive(true);
    }

    public void CloseLevels()
    {
        Debug.Log("Levels Closed");
        camera.CloseLevelsAnim();
        //LevelsMenu.SetActive(false);
    }
}
