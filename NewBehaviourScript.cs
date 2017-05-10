using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    //this variable will keep track of the currency
    static int currency=30;
    public Text CurrencyMessage = null;
    public Text currencyText = null;
    public int appleprice = 5;
    public int bearprice = 6;
    public int ballprice = 7;
    public int bucketprice = 5;
    public int mopprice = 3;
    public int broomprice = 3;
    public int knifeprice = 5;
    public int panprice = 7;
    public int bleachprice = 6;



    //---------------------------------------------------------------------------
    //the following variables belong to the shop scene
    //---------------------------------------------------------------------------
    public Text apple_text = null;
    static int apple_ammount = 0;

    public Text bear_text = null;
    static int bear_ammount = 0;

    public Text ball_text = null;
    static int ball_ammount = 0;

    public Text bucket_text = null;
    static int bucket_ammount = 0;

    public Text mop_text = null;
    static int mop_ammount = 0;

    public Text broom_text = null;
    static int broom_ammount = 0;

    public Text knife_text = null;
    static int knife_ammount = 0;

    public Text pan_text = null;
    static int pan_ammount = 0;

    public Text bleach_text = null;
    static int bleach_ammount = 0;


    //---------------------------------------------------------------------------
    //the following variables belong to the inventory scene
    //---------------------------------------------------------------------------
    public Text inventoryApple=null;
    static int applesStored = 0;
    public Text inventoryBear = null;
    static int bearsStored = 0;
    public Text inventoryBall = null;
    static int ballsStored = 0;

    public Text inventoryBucket = null;
    static int bucketsStored = 0;
    public Text inventoryMop = null;
    static int mopsStored = 0;
    public Text inventoryBroom = null;
    static int broomsStored = 0;

    public Text inventoryKnife = null;
    static int knivesStored = 0;
    public Text inventoryPan = null;
    static int pansStored = 0;
    public Text inventoryBleach = null;
    static int bleachesStored = 0;
    //---------------------------------------------------------------------------


    public int sum()
    {
        int summation = (apple_ammount*appleprice) + (bear_ammount*bearprice) + (ball_ammount*ballprice) + (bucket_ammount*bucketprice) + (mop_ammount*mopprice) + (broom_ammount*broomprice) + (knife_ammount*knifeprice) + (pan_ammount*bearprice) + (bleach_ammount*bleachprice);
        return summation;
    }

    public string showCurrency()
    {
        return currencyText.text = currency.ToString();
    }


    void Start()
    {
        showCurrency();
    }

    //these functions will add 1 to the ammount of items desired to purchase
    public void updateApple()
    {
        apple_ammount = apple_ammount + 1;
        apple_text.text = apple_ammount.ToString();
    }

    public void updateBear()
    {
        bear_ammount = bear_ammount + 1;
        bear_text.text = bear_ammount.ToString();
    }

    public void updateBall()
    {
        ball_ammount = ball_ammount + 1;
        ball_text.text = ball_ammount.ToString();
    }

    public void updateBucket()
    {
        bucket_ammount = bucket_ammount + 1;
        bucket_text.text = bucket_ammount.ToString();
    }

    public void updateMop()
    {
        mop_ammount = mop_ammount + 1;
        mop_text.text = mop_ammount.ToString();
    }

    public void updateBroom()
    {
        broom_ammount = broom_ammount + 1;
        broom_text.text = broom_ammount.ToString();
    }

    public void updateKnife()
    {
        knife_ammount = knife_ammount + 1;
        knife_text.text = knife_ammount.ToString();
    }

    public void updatePan()
    {
        pan_ammount = pan_ammount + 1;
        pan_text.text = pan_ammount.ToString();
    }

    public void updateBleach()
    {
        bleach_ammount = bleach_ammount + 1;
        bleach_text.text = bleach_ammount.ToString();
    }

    //this function shows the values of the apples in the inventory
    public void Appleshow()
    { inventoryApple.text = applesStored.ToString(); }

    //this function shows the values of the bears in the inventory
    public void Bearshow()
    { inventoryBear.text = bearsStored.ToString(); }

    //this function shows the values of the balls in the inventory
    public void Ballshow()
    { inventoryBall.text = ballsStored.ToString(); }

    //this function ahows the values of the buckets in the inventory
    public void Bucketshow()
    { inventoryBucket.text = bucketsStored.ToString(); }

    //this function adds the values of the mops selected at the store to the apples in the inventory
    public void Mopshow()
    { inventoryMop.text = mopsStored.ToString(); }

    //this function adds the values of the broom selected at the store to the apples in the inventory
    public void Broomshow()
    { inventoryBroom.text = broomsStored.ToString(); }

    //this function adds the values of the knives selected at the store to the apples in the inventory
    public void Knifeshow()
    { inventoryKnife.text = knivesStored.ToString(); }

    //this function adds the values of the pans selected at the store to the apples in the inventory
    public void Panshow()
    { inventoryPan.text = pansStored.ToString(); }


    //this function adds the values of the bleaches selected at the store to the apples in the inventory
    public void Bleachshow()
    { inventoryBleach.text = bleachesStored.ToString(); }






    //this function is made to add all purchases to the inventory and reset restart all the buttons and set them back to zero
    public void Purchase()
    {
        int check = sum();
        if(check==0)
            CurrencyMessage.text = "no items were selected";
        else
        if (check <= currency)
        {
            currency = currency - check;

            //this adds the values of the items selected at the store to the items in the inventory
            applesStored = applesStored + apple_ammount;
            inventoryApple.text = applesStored.ToString();

            bearsStored = bearsStored + bear_ammount;
            inventoryBear.text = bearsStored.ToString();

            ballsStored = ballsStored + ball_ammount;
            inventoryBall.text = ballsStored.ToString();

            bucketsStored = bucketsStored + bucket_ammount;
            inventoryBucket.text = bucketsStored.ToString();

            mopsStored = mopsStored + mop_ammount;
            inventoryMop.text = mopsStored.ToString();

            broomsStored = broomsStored + broom_ammount;
            inventoryBroom.text = broomsStored.ToString();

            knivesStored = knivesStored + knife_ammount;
            inventoryKnife.text = knivesStored.ToString();

            pansStored = pansStored + pan_ammount;
            inventoryPan.text = pansStored.ToString();

            bleachesStored = bleachesStored + bleach_ammount;
            inventoryBleach.text = bleachesStored.ToString();
            //call CancelPurchase to reset the store buttons
            currencyText.text = currency.ToString();
            CurrencyMessage.text = "items selected were purchased";

        }
        else
            CurrencyMessage.text = "not enought coins to purchase these items";
            reset();
    }

    public void CancelPurchase()
    {
        reset();
        CurrencyMessage.text = "purchase has been cancelled";
    }

    public void reset()
    {
        apple_text.text = " buy \n" + "apple";
        apple_ammount = 0;
        ball_text.text = " buy \n" + "ball";
        ball_ammount = 0;
        bear_text.text = " buy \n" + "bear";
        bear_ammount = 0;
        bucket_text.text = " buy \n" + "bucket";
        bucket_ammount = 0;
        mop_text.text = " buy \n" + "mop";
        mop_ammount = 0;
        broom_text.text = " buy \n" + "broom";
        broom_ammount = 0;
        knife_text.text = " buy \n" + "knife";
        knife_ammount = 0;
        pan_text.text = " buy \n" + "pan";
        pan_ammount = 0;
        bleach_text.text = " buy \n" + "bleach";
        bleach_ammount = 0;
    }


}
