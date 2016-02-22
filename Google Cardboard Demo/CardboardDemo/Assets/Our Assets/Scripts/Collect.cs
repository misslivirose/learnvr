using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Collider))]

public class Collect : MonoBehaviour
{

    //Create game controller
    private GameController gameController;

    /*Our Start() function finds the instance of our GameController and by default sets our 
    collectable so that we're not looking at it*/
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
        SetGazedAt(false);
    }

    /*LateUpdate() will close the app if user presses back button on both Android and iOS*/
    void LateUpdate()
    {
        Cardboard.SDK.UpdateState();
        if (Cardboard.SDK.BackButtonPressed)
        {
            Application.Quit();
        }
    }

    /*SetGazedAt() changes the color of the collectable based on whether or not we're looking at it. 
    Red for not, green for yes.*/
    public void SetGazedAt(bool gazedAt)
    {
        GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
    }

    /*Collected() increments our score value held by our GameController and deactivates the collectable*/
    public void Collected()
    {
        gameController.AddOne();
        gameObject.SetActive(false);
    }

}


