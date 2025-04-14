using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    public float priceDownPrice;
    public float incomeUpPrice;
    private int priceDownTimes = 0;
    private int incomeUpTimes = 0;
    public string priceDownPriceStr;
    public string incomeUpPriceStr;
    public Text priceDownPriceText;
    public Text incomeUpPriceText;

    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        priceDownPrice = (float)(500 * Math.Pow(10,priceDownTimes));
        incomeUpPrice = (float)(500 * Math.Pow(10,incomeUpTimes));
        ConvertPrices();
        priceDownPriceText.text =  "Improve Equipment-Reduce Production Prices: $" + priceDownPriceStr;
        incomeUpPriceText.text = "Improve Sales-All Foods Generate More Profit: $" + incomeUpPriceStr;

    }
    public void priceDown(){
        if(MoneyScript.money >= priceDownPrice){
            MoneyScript.money -= priceDownPrice;
            BuyScript.priceFactor /= 1.5f;
            priceDownTimes += 1;
            source.Play();
        }
    }
    public void incomeUp(){
        if(MoneyScript.money >= incomeUpPrice){
            MoneyScript.money -= incomeUpPrice;
            MoneyScript.incomeFactor *= 1.5f;
            incomeUpTimes += 1;
            source.Play();
        }
    }
    void ConvertPrices(){
        if(priceDownPrice >2000000000 || priceDownPrice < 0){
            priceDownPrice = 2000000000;
        }
        if(priceDownPrice < 1000){
            priceDownPriceStr = priceDownPrice.ToString();
        }
        if(priceDownPrice >= 1000 && priceDownPrice < 1000000){
            priceDownPriceStr = ((int)(100*(priceDownPrice/ 1000))/100).ToString() + "K";
        }
        if(priceDownPrice >=1000000 && priceDownPrice < 1000000000){
            priceDownPriceStr = ((int)(100*(priceDownPrice/1000000))/100).ToString() + "M";
        }
        if(priceDownPrice >=1000000000 && priceDownPrice <= 2000000000){
            priceDownPriceStr = ((int)(100*(priceDownPrice / 1000000000))/100).ToString() + "B";
        }
         if(incomeUpPrice >2000000000 || incomeUpPrice < 0){
            incomeUpPrice = 2000000000;
        }
        if(incomeUpPrice < 1000){
            incomeUpPriceStr = incomeUpPrice.ToString();
        }
        if(incomeUpPrice >= 1000 && incomeUpPrice < 1000000){
            incomeUpPriceStr = ((int)(100*(incomeUpPrice/ 1000))/100).ToString() + "K";
        }
        if(incomeUpPrice >=1000000 && incomeUpPrice < 1000000000){
            incomeUpPriceStr = ((int)(100*(incomeUpPrice/1000000))/100).ToString() + "M";
        }
        if(incomeUpPrice >=1000000000 && incomeUpPrice <= 2000000000){
            incomeUpPriceStr = ((int)(100*(incomeUpPrice / 1000000000))/100).ToString() + "B";
        }
       
    }
}
