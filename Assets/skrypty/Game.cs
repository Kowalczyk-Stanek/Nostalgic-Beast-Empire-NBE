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


    //Particles

    public GameObject plusObject;
    public Text plusText;

    void Start()
    {
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;


      

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

        allUpgradeText.text =""+allUpgradePrize + " zł";

        plusText.text = "+ " + hitPower;
    }

    public void Hit()
    {
        currentScore += hitPower;

        plusObject.SetActive(false);

        plusObject.transform.position = new Vector3(Random.Range(400, 700 + 1), Random.Range(1000, 1200 + 1), 0);
        //
        //

        plusObject.SetActive(true);

        StopAllCoroutines();
        StartCoroutine(Fly());
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

    IEnumerator Fly()
    {
        for(int i=0;i<=19;i++)
        {
            yield return new WaitForSeconds(0.01f);

            plusObject.transform.position = new Vector3(plusObject.transform.position.x, plusObject.transform.position.y + 2, 0);
        }
    }

}
