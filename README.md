##P.E.T. INC

## PositiveValence

##ORGANIZATION
There are three main files included in this repository. 

1)Graphics - contains all the graphics used in the game. This is an extra copy for easy access in case more graphics need to be made.

2)Main Project - contains all the files in the main project. In order to be able to use it, the developer needs to have Unity already installed in their computer then select 
the option to open a project. Then select to open the folder located in PositiveValence\Main Project\P.E.T. INC. Developer should be able to access the program without any 
difficulty.

3) MiniGames - similarly to graphics, thsi folder is located here for convenince in case additions need to be implemented or tested.

##INSTALLATION - For Users
A playable file is available under Main Project\P.E.T. INC - playable game file . Download the files and click on the P.E.T. file to run the game.

##INSTALLATION - For Developers
The Unity project is under Main Project file. The folder titled P.E.T. INC hold the entire project. Download this file and you will be able to open using unity in your computer.
For more information about Unity or instructions on how to install it, please refer to the following link: https://store.unity.com/


##SCRIPTS
*public void ShakeCamera(float shakePower, float shakeDuration) Sets values for shakeamount and shaketimer to create the effect of an earthquake in the game.

*public void switchScene(int changeTheScene) Is a function used in every button that redirects from one scene to another in order to move around between scenes.

*public class DecreaseStatBar This whole class is to update the status bar that affect the pet and this information is used as the pet’s status.

*public class DefaultAllValues - defaults all global variables to desired amount.

*void Start () Is used to set all the values used in all the scenes, to a beginning default value

*void OnTriggerEnter2D(Collider2D other) Is used on the trashcan to get rid of the items that have no use left.

*void SpawnFireAlongOutline and void SpawnFireAtPosition(Vector2 position) Are both used to generate the fire effect in the kitchen scene

*public class GlobalCoin This whole class is used to keep track of the currency in every scene and update it everywhere whenever it is updated in one scene.

*public class GlobalTimer This whole class is used to keep track of the time the user has spent using the game to be able to age the pet after a specific amount of time played.

*void OnCollisionEnter2D (Collision2D col) Is used whenever the pet interacts with an item that will change its status, for example a toy that will make it happier.

*int returnLevel () Lets the script know in which stage the pet should be in

*public class PetDeaths This whole class interacts with the pet status and returns an image of the dead pet depending on the pet status. 

*public class PetEmotion : Program keeps track of the pet's state of being. Updated in May by Melissa to change the settings to a global so that the health will be kept constants throughout the different scenes.

*GameObject findClosestObject(GameObject[] gos ) Makes the pet move to the closest object it has to it.

*void RotateOnDeath () Since the images of the pet are not in the correct angle, this function rotates the image so that the pet’s death looks with a correct orientation.

*public int sum() this function returns the summation of all the items selected in the shop multiplied by the amount of times the items were selected.

*public string showCurrency() is a function that shows the currency in the shop scene

*public void updateApple(), public void updateBear(), public void updateBall(), public void updateBucket(), public void updateMop(), public void updateBroom(), public void updateKnife(), public void updatePan(), public void updateBleach()   these functions will add 1 to the ammount of items desired 
to purchase

*public void Appleshow(), public void Bearshow(), public void Ballshow(), public void Bucketshow(), public void Mopshow(), public void Broomshow(), public void Knifeshow(), public void Panshow(), public void Bleachshow()   these functions shows the values of the items in the inventory

*public void Purchase()  this function is made to add all purchases to the inventory and reset restart all the buttons and set them back to zero

*public void CancelPurchase()  this function us used when the user selected something wrong in the shop that does not want to purchase.

*public void reset()  this function resets all the values from the shop to 0

*public void Sell()  this function decreases the amount of items from the inventory and returns currency to the shop scene.

##Bugs
Deaths of the pet does not change the sprite when the pet dies when not in the livingroom.
