using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellScript : MonoBehaviour
{
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SellOranges(){
        if(ItemsBoughtScript.orangesBought > 0){
            MoneyScript.money += 1;
            ItemsBoughtScript.orangesBought -= 1;
            source.Play();
        }
    }
    public void SellEggs(){
        if(ItemsBoughtScript.eggsBought > 0){
            MoneyScript.money += 2;
            ItemsBoughtScript.eggsBought -= 1;
            source.Play();
        }
    }
    public void SellPie(){
        if(ItemsBoughtScript.piesBought > 0){
            MoneyScript.money += 5;
            ItemsBoughtScript.piesBought -= 1;
            source.Play();
        }
    }
    public void SellSandwich(){
        if(ItemsBoughtScript.sandwichesBought > 0){
            MoneyScript.money += 10;
            ItemsBoughtScript.sandwichesBought -= 1;
            source.Play();
        }
    }
    public void SellPizza(){
        if(ItemsBoughtScript.pizzasBought > 0){
            MoneyScript.money += 40;
            ItemsBoughtScript.pizzasBought -= 1;
            source.Play();
        }
    }
    public void SellMeatloaf(){
        if(ItemsBoughtScript.meatloafBought > 0){
            MoneyScript.money += 100;
            ItemsBoughtScript.meatloafBought -= 1;
            source.Play();
        }
    }
    public void SellSteak(){
        if(ItemsBoughtScript.steakBought > 0){
            MoneyScript.money += 500;
            ItemsBoughtScript.steakBought -= 1;
            source.Play();
        }
    }
}
