using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaDeCarga : MonoBehaviour
{
    public float transitionTime = 1f;
    public Animator transition;
    private int actualScene;

    // Start is called before the first frame update
    void Start()
    {
        actualScene = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(PasarASiguientePantalla());
        Debug.Log(actualScene);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0) & actualScene == 0)
        {
            LoadNextLevel();
        } 
    }

    
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {

        // transition
        transition.SetTrigger("Start");

        // WAIT
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

    }

    IEnumerator PasarASiguientePantalla()
    {
        Debug.Log("NO SE ACTIVA EL DESNEGRO");
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5f);
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("LoggIn");
    }
}
