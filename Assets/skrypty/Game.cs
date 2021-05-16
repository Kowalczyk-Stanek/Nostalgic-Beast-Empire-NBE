using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update

    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    //Shop
    public int shop1prize;
    public Text shop1text;

    public int shop2prize;
    public Text shop2text;

    public int shop3prize;
    public Text shop3text;

    public int shop4prize;
    public Text shop4text;
    //Amount

    public Text amounttext;
    public int amountsum;

    public int amount1;
    public float amount1Profit;

    public int amount2;
    public float amount2Profit;

    public int amount3;
    public float amount3Profit;

    public int amount4;
    public float amount4Profit;


    //Upgrade
    public int upgradePrize;
    public Text upgradeText;
    public Text hitpowerText;

    public int allUpgradePrize;
    public Text allUpgradeText;




    void Start()
    {
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;


        //ŁADOWANIE TRZEBA PODPIĄĆ POD PRZYCISK

        ////set to defaults
        //shop1prize = 25;
        //shop2prize = 125;
        //amount1 = 0;
        //amount1Profit = 1;
        //amount2 = 0;
        //amount2Profit = 5;

        ////reset
        //PlayerPrefs.DeleteAll();

        ////load

        //currentScore = PlayerPrefs.GetInt("currentScore", 0);
        //hitPower = PlayerPrefs.GetInt("hitPower", 1);
        //x = PlayerPrefs.GetInt("x", 0);

        //shop1prize = PlayerPrefs.GetInt("shop1prize", 25);
        //shop2prize = PlayerPrefs.GetInt("shop2prize", 125);
        //amount1 = PlayerPrefs.GetInt("amount1", 0);
        //amount1Profit = PlayerPrefs.GetInt("amount1Profit", 0);
        //amount2=  PlayerPrefs.GetInt("amount2", 0);
        //amount2Profit = PlayerPrefs.GetInt("amount2Profit", 0);
        //upgradePrize = PlayerPrefs.GetInt("upgradePrize", 50);

        //allUpgradePrize = 500;

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)currentScore + " zł";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        //Shop
        shop1text.text = "  " + shop1prize + " zł";
        shop2text.text = "  " + shop2prize + " zł";
        shop3text.text = "  " + shop3prize + " zł";
        shop4text.text = "  " + shop4prize + " zł";

        //Amount 
        amountsum = Mathf.RoundToInt(amount1Profit + (float)amount2Profit);
        amounttext.text = Mathf.RoundToInt((float)x)+" ";

        //Upgrade
        upgradeText.text = "" + upgradePrize + " zł";
        hitpowerText.text = "" + hitPower;

        //SAVE TRZEBA PODPIAC POD PRZYCISK
        ////save
        //PlayerPrefs.SetInt("currentScore", (int)currentScore);
        //PlayerPrefs.SetInt("hitPower", (int)hitPower);
        //PlayerPrefs.SetInt("x", (int)x);
        //PlayerPrefs.SetInt("shop1prize", (int)shop1prize);
        //PlayerPrefs.SetInt("shop2prize", (int)shop2prize);
        //PlayerPrefs.SetInt("amount1", (int)amount1);
        //PlayerPrefs.SetInt("amount1Profit", (int)amount1Profit);
        //PlayerPrefs.SetInt("amount2", (int)amount2);
        //PlayerPrefs.SetInt("amount2Profit", (int)amount2Profit);
        //PlayerPrefs.SetInt("upgradePrize", (int)upgradePrize);

        allUpgradeText.text =""+allUpgradePrize + " zł";
    }

    public void Hit()
    {
        currentScore += hitPower;
    }

    //Shop

    public void shop1()
    {
        if (currentScore >= shop1prize)
        {
            currentScore -= shop1prize;
            amount1 = Mathf.RoundToInt((float)amount1 * (float)1.5);
            amount1Profit = 1;
            x += 1;
            shop1prize = Mathf.RoundToInt((float)shop1prize * (float)1.5);
        } 
    }

    public void shop2()
    {
        if (currentScore >= shop2prize)
        {
            currentScore -= shop2prize;
            amount2 += 1;
            amount2Profit += 5;
            x += 5;
            shop2prize = Mathf.RoundToInt((float)shop1prize * (float)1.5);
        }
    }

    public void shop3()
    {
        if (currentScore >= shop3prize)
        {
            currentScore -= shop3prize;
            amount3 += 1;
            amount3Profit += 10;
            x += 10;
            shop3prize = Mathf.RoundToInt((float)shop1prize * (float)1.5);
        }
    }

    public void shop4()
    {
        if (currentScore >= shop4prize)
        {
            currentScore -= shop4prize;
            amount4 += 1;
            amount4Profit += 15;
            x += 15;
            shop4prize = Mathf.RoundToInt((float)shop1prize * (float)1.5);
        }
    }

    public void Upgrade()
    {
        if (currentScore >= upgradePrize)
        {
            currentScore -= upgradePrize;
            hitPower *= 2;
            upgradePrize *= 3;

        }
    }

    public void AllProfitsUpgrade()
    {
        if(currentScore>=allUpgradePrize)
        {
            currentScore -= allUpgradePrize;
            x *= 2;
            allUpgradePrize *= 3;
            amount1Profit *= 2;
            amount2Profit *= 2;
        }
    }

}
