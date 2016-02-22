using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{

    //Global Variables
    public Text countText;
    public Text winText;

    private int count;


    // Use this for initialization
    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    //AddOne() increments the score count and updates the GUI Text
    public void AddOne()
    {
        count++;
        SetCountText();
    }

    //SetCountText() updates the count to the screen and displays 
    //"You Win" to the screen when collectables all collected
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
          
        }
    }
}
