using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.
using TMPro;

public class LoggIn : MonoBehaviour
{
    TheGame playerInstance;
	public TMP_InputField name;
	public void Start()
	{
		playerInstance = GameObject.FindGameObjectWithTag("GameController").GetComponent<TheGame>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getValue(){
            string username = name.text;
            if(username.Equals("Carles"))
            {  
                playerInstance.SetName(username);
            }
    }
}
