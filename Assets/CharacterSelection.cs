using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StatRoll : MonoBehaviour
{
    // public vars
    public string charName = "";
    public int profBonus = 0;
    public bool usingFinesseWep;
    public int STR = 0;
    public int DEX = 0;


    // private vars
    private int enemyAC = 0;
    private int hitMod = 0;
    private bool isEnemyHit;
    private int mainRoll = 0;
    private int damageRoll = 0;
    private string enemyStatus;



    void Start()
    {
        // call random number functions
        enemyAC = Random.Range(10,20);
        mainRoll = Random.Range(1,20);
        damageRoll = Random.Range(1,20) + hitMod;
        
        // default charName to Tav if charName is left empty
        if(charName == "")
        {
            charName = "Tav";
        }

        // setting boundaries for STR and DEX
        if(STR < -5 || STR > 5)
        {
            print("Please enter a valid STR integer between -5 and 5 for the program to work right!");
        }

        else if(DEX < -5 || DEX > 5)
        {
            print("Please enter a valid DEX integer between -5 and 5 for the program to work right!");
        }


        
        // are we using a finesse weapon? what happens if we are or arent?
        if(usingFinesseWep == true)
        {
            if(STR > DEX)
            {
                hitMod = profBonus + STR;
            }

            else if(STR < DEX)
            {
                hitMod = profBonus + DEX;
            }


            else if(STR == DEX)
            {
                hitMod = profBonus + DEX;
            }
        }
        
        else if(usingFinesseWep == false)
        {
            hitMod = profBonus + STR;
        }

        // is the damageRoll higher than enemyAC? what happens if it is or isnt?
        if(damageRoll > enemyAC)
        {
            isEnemyHit = true;
        }

        else if (damageRoll < enemyAC)
        {
            isEnemyHit = false;
        }


        // is the enemy hit? what happens if they are or arent?
        if(isEnemyHit == true)
        {
            enemyStatus = "hit!";
        }

        else if(isEnemyHit == false)
        {
            enemyStatus = "missed!";
        }



        //debug output
        //print("char name:" + charName);
        //print("hit mod:" + hitMod);
        //print("enemy ac:" + enemyAC);
        //print("mainroll:" + mainRoll);
        //print("enemy status: " + enemyStatus);
        //print("is enemy hit?:" + isEnemyHit);
        //print("damageroll: " + damageRoll);
        //print("using f wep?" + usingFinesseWep);
        //print("=====================================");

        // final output
        print(charName+"'s hit modifier is "+hitMod+".");
        print("Enemy AC is "+ enemyAC);
        print(charName + "rolled a "+ mainRoll);
        print("Enemy is "+ enemyStatus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
