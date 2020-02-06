using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.EventSystems;

public class shopClick : MonoBehaviour
{
    public void clickShop() {
        Debug.Log("shop");
        //SceneManager.LoadScene("Shop", LoadSceneMode.Single);
        GameObject.FindGameObjectWithTag("gm").GetComponent<GameManager>().State = 2;
    }
}
