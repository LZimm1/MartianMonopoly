using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class BuyScript : MonoBehaviour
{
    public Text Oranges;
    public Text Eggs;
    public Text Pies;
    public Text Sandwiches;
    public Text Pizzas;
    public Text Meatloaf;
    public Text Steak;

    public int baseOrange = 2;
    public int baseEgg = 4;
    public int basePie = 10;
    public int baseSandwich = 20;
    public int basePizza = 80;
    public int baseMeatloaf = 200;
    public int baseSteak = 1000;
    
    public double orangePrice;
    public double eggPrice;
    public double piePrice;
    public double sandwichPrice;
    public double pizzaPrice;
    public double meatloafPrice;
    public double steakPrice;

    public string orangePriceStr;
    public string eggPriceStr;
    public string piePriceStr;
    public string sandwichPriceStr;
    public string pizzaPriceStr;
    public string meatloafPriceStr;
    public string steakPriceStr;
    public AudioSource source;

    public static float priceFactor = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        orangePrice = (int)(priceFactor * (baseOrange * Math.Pow(1.02,ItemsBoughtScript.orangesBought)));
        
        
        eggPrice = (int)(priceFactor * (baseEgg * Math.Pow(1.03,ItemsBoughtScript.eggsBought)));
        
        
        piePrice = (int)(priceFactor * (basePie * Math.Pow(1.04,ItemsBoughtScript.piesBought)));
        
        
        sandwichPrice = (int)(priceFactor * (baseSandwich * Math.Pow(1.05,ItemsBoughtScript.sandwichesBought)));
        
       
        pizzaPrice = (int)(priceFactor *(basePizza * Math.Pow(1.06,ItemsBoughtScript.pizzasBought)));
        
       
        meatloafPrice = (int)(priceFactor *(baseMeatloaf * Math.Pow(1.08,ItemsBoughtScript.meatloafBought)));
        
        steakPrice = (int)(priceFactor *(baseSteak * Math.Pow(1.1,ItemsBoughtScript.steakBought))) ;

        ConvertPrices();
        if(Oranges){
            Oranges.text = "Buy-$" + orangePriceStr;
        }
        if(Eggs){
            Eggs.text = "Buy-$" + eggPriceStr;
        }
        if(Pies){
            Pies.text = "Buy-$" + piePriceStr;
        }
        if(Sandwiches){
            Sandwiches.text = "Buy-$" + sandwichPriceStr;
        }
        if(Pizzas){
            Pizzas.text = "Buy-$" + pizzaPriceStr;
        }
        if(Meatloaf){
            Meatloaf.text = "Buy-$" + meatloafPriceStr;
        }
        if(Steak){
            Steak.text = "Buy-$" + steakPriceStr;
        }
    }
    public void BuyOranges(){
        if(MoneyScript.money > orangePrice){
            ItemsBoughtScript.orangesBought += 1;
            MoneyScript.money -= orangePrice;
            source.Play();
        }
    }
    public void BuyEggs(){
        if(MoneyScript.money >= eggPrice){
            ItemsBoughtScript.eggsBought += 1;
            MoneyScript.money -= eggPrice;
            source.Play();
        }
    }
    public void BuyPie(){
        if(MoneyScript.money >= piePrice){
            ItemsBoughtScript.piesBought += 1;
            MoneyScript.money -= piePrice;
            source.Play();
        }
    }
    public void BuySandwich(){
        if(MoneyScript.money >= sandwichPrice){
            ItemsBoughtScript.sandwichesBought += 1;
            MoneyScript.money -= sandwichPrice;
            source.Play();
        }
    }
    public void BuyPizza(){
        if(MoneyScript.money >= pizzaPrice){
            ItemsBoughtScript.pizzasBought += 1;
            MoneyScript.money -= pizzaPrice;
            source.Play();
        }
    }
    public void BuyMeatloaf(){
        if(MoneyScript.money >= meatloafPrice){
            ItemsBoughtScript.meatloafBought += 1;
            MoneyScript.money -= meatloafPrice;
            source.Play();
        }
    }
    public void BuySteak(){
        if(MoneyScript.money >= steakPrice){
            ItemsBoughtScript.steakBought += 1;
            MoneyScript.money -= steakPrice;
            source.Play();
        }
    }
    void ConvertPrices(){
        //Orange 
        if(orangePrice >2000000000 || orangePrice < 0){
            orangePrice = 2000000000;
        }
        if(orangePrice < 1000){
            orangePriceStr = orangePrice.ToString();
        }
        if(orangePrice >= 1000 && orangePrice < 1000000){
            orangePriceStr = ((int)(100*(orangePrice/ 1000))/100).ToString() + "K";
        }
        if(orangePrice >=1000000 && orangePrice < 1000000000){
            orangePriceStr = ((int)(100*(orangePrice/1000000))/100).ToString() + "M";
        }
        if(orangePrice >=1000000000 && orangePrice <= 2000000000){
            orangePriceStr = ((int)(100*(orangePrice / 1000000000))/100).ToString() + "B";
        }
        
        //Egg
        if(eggPrice >2000000000 || eggPrice < 0){
            eggPrice = 2000000000;
        }
        if(eggPrice < 1000){
            eggPriceStr = eggPrice.ToString();
        }
        if(eggPrice >= 1000 && eggPrice < 1000000){
            eggPriceStr = ((int)(100*(eggPrice/ 1000))/100).ToString() + "K";
        }
        if(eggPrice >=1000000 && eggPrice < 1000000000){
            eggPriceStr = ((int)(100*(eggPrice/1000000))/100).ToString() + "M";
        }
        if(eggPrice >=1000000000 && eggPrice <= 2000000000){
            eggPriceStr = ((int)(100*(eggPrice / 1000000000))/100).ToString() + "B";
        }
        
        //Pie
        if(piePrice >2000000000 || piePrice < 0){
            piePrice = 2000000000;
        }
        if(piePrice < 1000){
            piePriceStr = piePrice.ToString();
        }
        if(piePrice >= 1000 && piePrice < 1000000){
            piePriceStr = ((int)(100*(piePrice/ 1000))/100).ToString() + "K";
        }
        if(piePrice >=1000000 && piePrice < 1000000000){
            piePriceStr = ((int)(100*(piePrice/1000000))/100).ToString() + "M";
        }
        if(piePrice >=1000000000 && piePrice <= 2000000000){
            piePriceStr = ((int)(100*(piePrice / 1000000000))/100).ToString() + "B";
        }
        
        //Sandwich
        if(sandwichPrice >2000000000 || sandwichPrice < 0){
            sandwichPrice = 2000000000;
        }
        if(sandwichPrice < 1000){
            sandwichPriceStr = sandwichPrice.ToString();
        }
        if(sandwichPrice >= 1000 && sandwichPrice < 1000000){
            sandwichPriceStr = ((int)(100*(sandwichPrice/ 1000))/100).ToString() + "K";
        }
        if(sandwichPrice >=1000000 && sandwichPrice < 1000000000){
            sandwichPriceStr = ((int)(100*(sandwichPrice/1000000))/100).ToString() + "M";
        }
        if(sandwichPrice >=1000000000 && sandwichPrice <= 2000000000){
            sandwichPriceStr = ((int)(100*(sandwichPrice / 1000000000))/100).ToString() + "B";
        }
        
        //Pizza
        if(pizzaPrice >2000000000 || pizzaPrice < 0){
            pizzaPrice = 2000000000;
        }
        if(pizzaPrice < 1000){
            pizzaPriceStr = pizzaPrice.ToString();
        }
        if(pizzaPrice >= 1000 && pizzaPrice < 1000000){
            pizzaPriceStr = ((int)(100*(pizzaPrice/ 1000))/100).ToString() + "K";
        }
        if(pizzaPrice >=1000000 && pizzaPrice < 1000000000){
            pizzaPriceStr = ((int)(100*(pizzaPrice/1000000))/100).ToString() + "M";
        }
        if(pizzaPrice >=1000000000 && pizzaPrice <= 2000000000){
            pizzaPriceStr = ((int)(100*(pizzaPrice / 1000000000))/100).ToString() + "B";
        }
        
        //Meatloaf
        if(meatloafPrice >2000000000 || meatloafPrice < 0){
            meatloafPrice = 2000000000;
        }
        if(meatloafPrice < 1000){
            meatloafPriceStr = meatloafPrice.ToString();
        }
        if(meatloafPrice >= 1000 && meatloafPrice < 1000000){
            meatloafPriceStr = ((int)(100*(meatloafPrice/ 1000))/100).ToString() + "K";
        }
        if(meatloafPrice >=1000000 && meatloafPrice < 1000000000){
            meatloafPriceStr = ((int)(100*(meatloafPrice/1000000))/100).ToString() + "M";
        }
        if(meatloafPrice >=1000000000 && meatloafPrice <= 2000000000){
            meatloafPriceStr = ((int)(100*(meatloafPrice / 1000000000))/100).ToString() + "B";
        }
        
        //Steak
        if(steakPrice >2000000000 || steakPrice < 0){
            steakPrice = 2000000000;
        }
        if(steakPrice < 1000){
            steakPriceStr = steakPrice.ToString();
        }
        if(steakPrice >= 1000 && steakPrice < 1000000){
            steakPriceStr = ((int)(100*(steakPrice/ 1000))/100).ToString() + "K";
        }
        if(steakPrice >=1000000 && steakPrice < 1000000000){
            steakPriceStr = ((int)(100*(steakPrice/1000000))/100).ToString() + "M";
        }
        if(steakPrice >=1000000000 && steakPrice <= 2000000000){
            steakPriceStr = ((int)(100*(steakPrice / 1000000000))/100).ToString() + "B";
        }
       
    }
}
