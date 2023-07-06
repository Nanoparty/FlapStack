using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pancake;
    public GameObject butter;
    public GameObject donut;
    public GameObject egg;

    int sel;
    int state = 1;
    int height = 5;

    public int count = 0;
    
    GameObject panStack;
    public int numCakes;
    //public Text uiText;
    public Text coinText;
    // Start is called before the first frame update
    Canvas shopCanvas;
    void Start()
    {
        panStack = new GameObject("PancakeStack");
        numCakes = stats.Coins;
        sel = 1;
        
        
    }
    public int State
    {
        get
        {
            return state;
        }
        set
        {
            state = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case 1:

                //GameObject.FindWithTag("shopCanvas").GetComponent<Canvas>().enabled = false;
                GameObject.FindGameObjectWithTag("gameCanvas").GetComponent<Canvas>().enabled = true;

                if (Input.GetKeyUp(KeyCode.Mouse0)) //(Input.touchCount > 0 || Input.GetKeyDown("space"))
                {
                    //Touch touch = Input.GetTouch(0); 
                    if (true)
                    {
                        switch (sel)
                        {
                            case 1:
                                //pancake.GetComponent<Rigidbody>().mass = 100 - numCakes;
                                if(numCakes%10 == 0 && numCakes > 1)
                                {
                                    InstantiateSingle(butter, 0, height);
                                }else
                                {
                                    InstantiateSingle(pancake, 0, height);
                                }
                                
                                break;
                            case 2:
                                InstantiateSingle(butter, 0, height);
                                break;
                            case 3:
                                InstantiateSingle(egg, 0, height);
                                break;
                            case 4:
                                InstantiateSingle(donut, 0, height);
                                break;
                        }

                        numCakes++;
                    }

                }
                if (Input.GetKeyDown("1"))
                {
                    sel = 1;
                }
                if (Input.GetKeyDown("2"))
                {
                    sel = 2;
                }
                if (Input.GetKeyDown("3"))
                {
                    sel = 3;
                }
                if (Input.GetKeyDown("4"))
                {
                    sel = 4;
                }

                //uiText.text = "◆" + numCakes + "";
                coinText.text = "◆" + count + "";
                break;
            case 2:
                GameObject.FindGameObjectWithTag("gameCanvas").GetComponent<Canvas>().enabled = false;
                GameObject.FindGameObjectWithTag("shopCanvas").GetComponent<Canvas>().enabled = true;
                break;
        }
        
       
    }

    public void setCakes(int i) { 
        //numCakes += i; 

    }

    void InstantiateSingle(GameObject prefab, float xCoord, float yCoord)
    {
        count++;
        // The position to be instantiated at is based on the coordinates.
        Vector3 position = new Vector3(xCoord, yCoord, 0f);

        // Create an instance of the prefab from the random index of the array.
        GameObject tileInstance = Instantiate(prefab, position, Quaternion.identity) as GameObject;

        // Set the tile's parent to the board holder.
        tileInstance.transform.parent = panStack.transform;
    }
}
