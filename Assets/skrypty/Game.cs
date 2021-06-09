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

    //Amount

    public Text amounttext;
    public int amountsum;

    public int amount1;
    public float amount1Profit;




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


        //Amount 
       
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

    public void DamagePerSecondUpgrade()
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


    public void HitDamageUprage()
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
            allUpgradePrize *= 3;
            hitPower *= 2;
            x += 1;
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
