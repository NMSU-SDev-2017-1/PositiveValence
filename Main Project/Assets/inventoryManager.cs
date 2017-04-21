using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{
    //this text will tell us the number of items there are of each
    public Text foodText = null;
    public Text toyText = null;
    public Text cleaningText;
    public Text medicineText;

    //this variables represent the ammount of the item named
    static int foodNumber = 0;
    public int toyNumber = 0;
    public int cleaningNumner;
    public int medicineNumber;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void updateFood()
     {
        foodNumber = foodNumber + 1;
        foodText.text = foodNumber.ToString();
     }


    public void updatetoy()
    {
        toyNumber = toyNumber + 1;
        toyText.text = toyNumber.ToString();
    }

   

    

}