using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backClick : MonoBehaviour
{
    public void clickBack()
    {
        //Debug.Log("shop");
        //SceneManager.LoadScene("Shop", LoadSceneMode.Single);
        GameObject.FindGameObjectWithTag("gm").GetComponent<GameManager>().State = 1;
    }
}
