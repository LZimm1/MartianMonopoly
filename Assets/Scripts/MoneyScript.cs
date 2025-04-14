using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class MoneyScript : MonoBehaviour
{
    public static double money = 3;
    public double moneyPerSecond;
    public Text Money;
    public Text MoneyPerSecond;
    public string moneyStr;
    public string moneyPerSecondStr;
    public static float incomeFactor = 1f;

    private float orangeIncome;
    private float eggIncome;
    private float pieIncome;
    private float sandwichIncome;
    private float pizzaIncome;
    private float meatloafIncome;
    private float steakIncome;
    
    private string orangeIncomeStr;
    private string eggIncomeStr;
    private string pieIncomeStr;
    private string sandwichIncomeStr;
    private string pizzaIncomeStr;
    private string meatloafIncomeStr;
    private string steakIncomeStr;

    public Text orangeIndividualIncome;
    public Text eggIndividualIncome;
    public Text pieIndividualIncome;
    public Text sandwichIndividualIncome;
    public Text pizzaIndividualIncome;
    public Text meatloafIndividualIncome;
    public Text steakIndividualIncome;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ConvertPrices();
        GainMoney();
        if(Money){
            Money.text = "Money: $" + moneyStr;
        }
        if(MoneyPerSecond){
            MoneyPerSecond.text = "MPS: $" + moneyPerSecondStr;
        }
        if(orangeIndividualIncome){
            orangeIndividualIncome.text = "$" + orangeIncomeStr + " Per Second Each";
        }
        if(eggIndividualIncome){
            eggIndividualIncome.text = "$" + eggIncomeStr + " Per Second Each";
        }
        if(pieIndividualIncome){
            pieIndividualIncome.text ="$" +  pieIncomeStr + " Per Second Each";
        }
        if(sandwichIndividualIncome){
            sandwichIndividualIncome.text = "$" + sandwichIncomeStr + " Per Second Each";
        }
        if(pizzaIndividualIncome){
            pizzaIndividualIncome.text = "$" + pizzaIncomeStr + " Per Second Each";
        }
        if(meatloafIndividualIncome){
            meatloafIndividualIncome.text = "$" + meatloafIncomeStr + " Per Second Each";
        }
        if(steakIndividualIncome){
            steakIndividualIncome.text = "$" + steakIncomeStr + " Per Second Each";
        }
        
    }
    void GainMoney(){
        
        orangeIncome = ItemsBoughtScript.orangesBought * 0.02f * incomeFactor;
        eggIncome =  ItemsBoughtScript.eggsBought * 0.1f*incomeFactor;
        pieIncome = ItemsBoughtScript.piesBought * 0.3f*incomeFactor;
        sandwichIncome= ItemsBoughtScript.sandwichesBought *incomeFactor;
        pizzaIncome = ItemsBoughtScript.pizzasBought * 5*incomeFactor;
        meatloafIncome = ItemsBoughtScript.meatloafBought * 20*incomeFactor;
        steakIncome =  ItemsBoughtScript.steakBought * 120*incomeFactor;
        moneyPerSecond = Math.Round((orangeIncome + eggIncome + pieIncome +sandwichIncome + pizzaIncome + meatloafIncome + steakIncome),2);
        money += moneyPerSecond*Time.deltaTime;
    }
    void ConvertPrices(){
        if(money > 2100000000){
            money = 2100000000;
        }
        if(money < 10){
            moneyStr = ((float)((int)(money * 100))/100).ToString("f2");
            if(moneyStr.Length == 1){
                moneyStr += ".00";
            }
            if(moneyStr.Length == 3){
                moneyStr += "0";
            }
        }
        if(money >= 10 && money < 100){
            moneyStr = ((float)((int)(money * 100))/100).ToString("f2");
            if(moneyStr.Length == 2){
                moneyStr += ".00";
            }
            if(moneyStr.Length == 4){
                moneyStr += "0";
            }
        }
        if(money >= 100 && money < 1000){
            moneyStr = ((float)((int)(money * 100))/100).ToString("f2");
            if(moneyStr.Length == 3){
                moneyStr += ".00";
            }
            if(moneyStr.Length == 5){
                moneyStr += "0";
            }
        }
        if(money >= 1000 && money < 1000000){

            moneyStr = ((float)((int)(money))/1000).ToString("f2") + "K";
            
        }
        if(money >= 1000000 && money < 1000000000){

            moneyStr = ((float)((int)(money))/1000000).ToString("f2");
            moneyStr = ((float)((int)(100*((float)((int)(money))/1000000)))/100).ToString("f2")+"M";
        }
        if(money >= 1000000000 && money <= 2100000000){
            moneyStr = ((float)((int)(100*((float)((int)(money))/1000000000)))/100).ToString("f2")+"B";
        }

        if(moneyPerSecond > 2100000000){
            moneyPerSecond = 2100000000;
        }
        if(moneyPerSecond < 10){
            moneyPerSecondStr = ((float)((int)(moneyPerSecond * 100))/100).ToString("f2");
            if(moneyPerSecondStr.Length == 1){
                moneyPerSecondStr += ".00";
            }
            if(moneyPerSecondStr.Length == 3){
                moneyPerSecondStr += "0";
            }
        }
        if(moneyPerSecond >= 10 && moneyPerSecond < 100){
            moneyPerSecondStr = ((float)((int)(moneyPerSecond * 100))/100).ToString("f2");
            if(moneyPerSecondStr.Length == 2){
                moneyPerSecondStr += ".00";
            }
            if(moneyPerSecondStr.Length == 4){
                moneyPerSecondStr += "0";
            }
        }
        if(moneyPerSecond >= 100 && moneyPerSecond < 1000){
            moneyPerSecondStr = ((float)((int)(moneyPerSecond * 100))/100).ToString("f2");
            if(moneyPerSecondStr.Length == 3){
                moneyPerSecondStr += ".00";
            }
            if(moneyPerSecondStr.Length == 5){
                moneyPerSecondStr += "0";
            }
        }
        if(moneyPerSecond >= 1000 && moneyPerSecond < 1000000){

            moneyPerSecondStr = ((float)((int)(moneyPerSecond))/1000).ToString("f2") + "K";
        }
        if(moneyPerSecond >= 1000000 && moneyPerSecond < 1000000000){

            moneyPerSecondStr = ((float)((int)(moneyPerSecond))/1000000).ToString("f2") + "M";
        }
        if(moneyPerSecond >= 1000000000 && moneyPerSecond <= 2100000000){
            moneyPerSecondStr =((float)((int)(moneyPerSecond))/1000000000).ToString("f2") + "B";
        }
        //Oranges
        if(0.02f * incomeFactor < 10){
            orangeIncomeStr = ((float)((int)((0.02f*incomeFactor) * 100))/100).ToString("f2");
            if(orangeIncomeStr.Length == 1){
                orangeIncomeStr += ".00";
            }
            if(orangeIncomeStr.Length == 3){
                orangeIncomeStr += "0";
            }
        }
        if(0.02f * incomeFactor >= 10 && 0.02f * incomeFactor < 100){
            orangeIncomeStr = ((float)((int)(0.02f * incomeFactor * 100))/100).ToString("f2");
            if(orangeIncomeStr.Length == 2){
                orangeIncomeStr += ".00";
            }
            if(orangeIncomeStr.Length == 4){
                orangeIncomeStr += "0";
            }
        }
        if(0.02f * incomeFactor >= 100 && 0.02f * incomeFactor < 1000){
            orangeIncomeStr = ((float)((int)(0.02f * incomeFactor * 100))/100).ToString("f2");
            if(orangeIncomeStr.Length == 3){
                orangeIncomeStr += ".00";
            }
            if(orangeIncomeStr.Length == 5){
                orangeIncomeStr += "0";
            }
        }
        if(0.02f * incomeFactor >= 1000 && 0.02f * incomeFactor < 1000000){

            orangeIncomeStr = ((float)((int)(0.02f * incomeFactor))/1000).ToString("f2") + "K";
        }
        if(0.02f * incomeFactor >= 1000000 && 0.02f * incomeFactor < 1000000000){

            orangeIncomeStr = ((float)((int)(0.02f * incomeFactor))/1000000).ToString("f2") + "M";
        }
        if(0.02f * incomeFactor >= 1000000000 && 0.02f * incomeFactor <= 2100000000){
            orangeIncomeStr =((float)((int)(0.02f * incomeFactor))/1000000000).ToString("f2") + "B";
        }
        // Eggs
        if(0.1f * incomeFactor < 10){
            eggIncomeStr = ((float)((int)((0.1f*incomeFactor) * 100))/100).ToString("f2");
            if(eggIncomeStr.Length == 1){
                eggIncomeStr += ".00";
            }
            if(eggIncomeStr.Length == 3){
                eggIncomeStr += "0";
            }
        }
        if(0.1f * incomeFactor >= 10 && 0.1f * incomeFactor < 100){
            eggIncomeStr = ((float)((int)(0.1f * incomeFactor * 100))/100).ToString("f2");
            if(eggIncomeStr.Length == 2){
                eggIncomeStr += ".00";
            }
            if(eggIncomeStr.Length == 4){
                eggIncomeStr += "0";
            }
        }
        if(0.1f * incomeFactor >= 100 && 0.1f * incomeFactor < 1000){
            eggIncomeStr = ((float)((int)(0.1f * incomeFactor * 100))/100).ToString("f2");
            if(eggIncomeStr.Length == 3){
                eggIncomeStr += ".00";
            }
            if(eggIncomeStr.Length == 5){
                eggIncomeStr += "0";
            }
        }
        if(0.1f * incomeFactor >= 1000 && 0.1f * incomeFactor < 1000000){

            eggIncomeStr = ((float)((int)(0.1f * incomeFactor))/1000).ToString("f2") + "K";
        }
        if(0.1f * incomeFactor >= 1000000 && 0.1f * incomeFactor < 1000000000){

            eggIncomeStr = ((float)((int)(0.1f * incomeFactor))/1000000).ToString("f2") + "M";
        }
        if(0.1f * incomeFactor >= 1000000000 && 0.1f * incomeFactor <= 2100000000){
            eggIncomeStr =((float)((int)(0.1f * incomeFactor))/1000000000).ToString("f2") + "B";
        }
        // pie
         if(0.3f * incomeFactor < 10){
            pieIncomeStr = ((float)((int)((0.3f*incomeFactor) * 100))/100).ToString("f2");
            if(pieIncomeStr.Length == 1){
                pieIncomeStr += ".00";
            }
            if(pieIncomeStr.Length == 3){
                pieIncomeStr += "0";
            }
        }
        if(0.3f * incomeFactor >= 10 && 0.3f * incomeFactor < 100){
            pieIncomeStr = ((decimal)((int)(0.3f * incomeFactor * 100))/100).ToString("f2");
            if(pieIncomeStr.Length == 2){
                pieIncomeStr += ".00";
            }
            if(pieIncomeStr.Length == 4){
                pieIncomeStr += "0";
            }
        }
        if(0.3f * incomeFactor >= 100 && 0.3f * incomeFactor < 1000){
            pieIncomeStr = ((float)((int)(0.3f * incomeFactor * 100))/100).ToString("f2");
            if(pieIncomeStr.Length == 3){
                pieIncomeStr += ".00";
            }
            if(pieIncomeStr.Length == 5){
                pieIncomeStr += "0";
            }
        }
        if(0.3f * incomeFactor >= 1000 && 0.3f * incomeFactor < 1000000){

            pieIncomeStr = ((float)((int)(0.3f * incomeFactor))/1000).ToString("f2") + "K";
        }
        if(0.3f * incomeFactor >= 1000000 && 0.3f * incomeFactor < 1000000000){

            pieIncomeStr = ((float)((int)(0.3f * incomeFactor))/1000000).ToString("f2") + "M";
        }
        if(0.3f * incomeFactor >= 1000000000 && 0.3f * incomeFactor <= 2100000000){
            pieIncomeStr =((float)((int)(0.3f * incomeFactor))/1000000000).ToString("f2") + "B";
        }
        //Sandwich
         if(incomeFactor < 10){
            sandwichIncomeStr = ((float)((int)((incomeFactor) * 100))/100).ToString("f2");
            if(sandwichIncomeStr.Length == 1){
                sandwichIncomeStr += ".00";
            }
            if(sandwichIncomeStr.Length == 3){
                sandwichIncomeStr += "0";
            }
        }
        if(incomeFactor >= 10 && incomeFactor < 100){
            sandwichIncomeStr = ((float)((int)(incomeFactor * 100))/100).ToString("f2");
            if(sandwichIncomeStr.Length == 2){
                sandwichIncomeStr += ".00";
            }
            if(sandwichIncomeStr.Length == 4){
                sandwichIncomeStr += "0";
            }
        }
        if(incomeFactor >= 100 && incomeFactor < 1000){
            sandwichIncomeStr = ((float)((int)(incomeFactor * 100))/100).ToString("f2");
            if(sandwichIncomeStr.Length == 3){
                sandwichIncomeStr += ".00";
            }
            if(sandwichIncomeStr.Length == 5){
                sandwichIncomeStr += "0";
            }
        }
        if(incomeFactor >= 1000 && incomeFactor < 1000000){

            sandwichIncomeStr = ((float)((int)(incomeFactor))/1000).ToString("f2") + "K";
        }
        if(incomeFactor >= 1000000 && incomeFactor < 1000000000){

            sandwichIncomeStr = ((float)((int)(incomeFactor))/1000000).ToString("f2") + "M";
        }
        if(incomeFactor >= 1000000000 && incomeFactor <= 2100000000){
            sandwichIncomeStr =((float)((int)(incomeFactor))/1000000000).ToString("f2") + "B";
        }
        // pizza
         if(5f * incomeFactor < 10){
            pizzaIncomeStr = ((float)((int)((5f*incomeFactor) * 100))/100).ToString("f2");
            if(pizzaIncomeStr.Length == 1){
                pizzaIncomeStr += ".00";
            }
            if(pizzaIncomeStr.Length == 3){
                pizzaIncomeStr += "0";
            }
        }
        if(5f * incomeFactor >= 10 && 5f * incomeFactor < 100){
            pizzaIncomeStr = ((float)((int)(5f * incomeFactor * 100))/100).ToString("f2");
            if(pizzaIncomeStr.Length == 2){
                pizzaIncomeStr += ".00";
            }
            if(pizzaIncomeStr.Length == 4){
                pizzaIncomeStr += "0";
            }
        }
        if(5f * incomeFactor >= 100 && 5f * incomeFactor < 1000){
            pizzaIncomeStr = ((float)((int)(5f * incomeFactor * 100))/100).ToString("f2");
            if(pizzaIncomeStr.Length == 3){
                pizzaIncomeStr += ".00";
            }
            if(pizzaIncomeStr.Length == 5){
                pizzaIncomeStr += "0";
            }
        }
        if(5f * incomeFactor >= 1000 && 5f * incomeFactor < 1000000){

            pizzaIncomeStr = ((float)((int)(5f * incomeFactor))/1000).ToString("f2") + "K";
        }
        if(5f * incomeFactor >= 1000000 && 5f * incomeFactor < 1000000000){

            pizzaIncomeStr = ((float)((int)(5f * incomeFactor))/1000000).ToString("f2") + "M";
        }
        if(5f * incomeFactor >= 1000000000 && 5f * incomeFactor <= 2100000000){
            pizzaIncomeStr =((float)((int)(5f * incomeFactor))/1000000000).ToString("f2") + "B";
        }
        // meatloaf
         if(20f * incomeFactor < 10){
            meatloafIncomeStr = ((float)((int)((20f*incomeFactor) * 100))/100).ToString("f2");
            if(meatloafIncomeStr.Length == 1){
                meatloafIncomeStr += ".00";
            }
            if(meatloafIncomeStr.Length == 3){
                meatloafIncomeStr += "0";
            }
        }
        if(20f * incomeFactor >= 10 && 20f * incomeFactor < 100){
            meatloafIncomeStr = ((float)((int)(20f * incomeFactor * 100))/100).ToString("f2");
            if(meatloafIncomeStr.Length == 2){
                meatloafIncomeStr += ".00";
            }
            if(meatloafIncomeStr.Length == 4){
                meatloafIncomeStr += "0";
            }
        }
        if(20f * incomeFactor >= 100 && 20f * incomeFactor < 1000){
            meatloafIncomeStr = ((float)((int)(20f * incomeFactor * 100))/100).ToString("f2");
            if(meatloafIncomeStr.Length == 3){
                meatloafIncomeStr += ".00";
            }
            if(meatloafIncomeStr.Length == 5){
                meatloafIncomeStr += "0";
            }
        }
        if(20f * incomeFactor >= 1000 && 20f * incomeFactor < 1000000){

            meatloafIncomeStr = ((float)((int)(20f * incomeFactor))/1000).ToString("f2") + "K";
        }
        if(20f * incomeFactor >= 1000000 && 20f * incomeFactor < 1000000000){

            meatloafIncomeStr = ((float)((int)(20f * incomeFactor))/1000000).ToString("f2") + "M";
        }
        if(20f * incomeFactor >= 1000000000 && 20f * incomeFactor <= 2100000000){
            meatloafIncomeStr =((float)((int)(20f * incomeFactor))/1000000000).ToString("f2") + "B";
        }
        //Steak
         if(120f * incomeFactor < 10){
            steakIncomeStr = ((float)((int)((120f*incomeFactor) * 100))/100).ToString("f2");
            if(steakIncomeStr.Length == 1){
                steakIncomeStr += ".00";
            }
            if(steakIncomeStr.Length == 3){
                steakIncomeStr += "0";
            }
        }
        if(120f * incomeFactor >= 10 && 120f * incomeFactor < 100){
            steakIncomeStr = ((float)((int)(120f * incomeFactor * 100))/100).ToString("f2");
            if(steakIncomeStr.Length == 2){
                steakIncomeStr += ".00";
            }
            if(steakIncomeStr.Length == 4){
                steakIncomeStr += "0";
            }
        }
        if(120f * incomeFactor >= 100 && 120f * incomeFactor < 1000){
            steakIncomeStr = ((float)((int)(120f * incomeFactor * 100))/100).ToString("f2");
            if(steakIncomeStr.Length == 3){
                steakIncomeStr += ".00";
            }
            if(steakIncomeStr.Length == 5){
                steakIncomeStr += "0";
            }
        }
        if(120f * incomeFactor >= 1000 && 120f * incomeFactor < 1000000){

            steakIncomeStr = ((float)((int)(120f * incomeFactor))/1000).ToString("f2") + "K";
        }
        if(120f * incomeFactor >= 1000000 && 120f * incomeFactor < 1000000000){

            steakIncomeStr = ((float)((int)(120f * incomeFactor))/1000000).ToString("f2") + "M";
        }
        if(120f * incomeFactor >= 1000000000 && 120f * incomeFactor <= 2100000000){
            steakIncomeStr =((float)((int)(120f * incomeFactor))/1000000000).ToString("f2") + "B";
        }
    }
}

