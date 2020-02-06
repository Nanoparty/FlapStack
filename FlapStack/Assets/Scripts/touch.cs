using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if(SceneManager.GetActiveScene().name == "Menu")
                SceneManager.LoadScene("Main", LoadSceneMode.Single);
            if (SceneManager.GetActiveScene().name == "Shop")
                SceneManager.UnloadSceneAsync("Shop");
        }
        //if (Input.GetMouseButtonDown(0))
           // SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
