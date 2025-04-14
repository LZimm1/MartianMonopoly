using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsBoughtScript : MonoBehaviour
{
    public static int orangesBought=0;
    public static int eggsBought=0;
    public static int piesBought=0;
    public static int sandwichesBought=0;
    public static int pizzasBought=0;
    public static int meatloafBought=0;
    public static int steakBought=0;

    public Text Oranges;
    public Text Eggs;
    public Text Pies;
    public Text Sandwiches;
    public Text Pizzas;
    public Text Meatloaf;
    public Text Steak;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Oranges){
            Oranges.text = orangesBought.ToString();
        }
        if(Eggs){
            Eggs.text = eggsBought.ToString();
        }
        if(Pies){
            Pies.text = piesBought.ToString();
        }
        if(Sandwiches){
            Sandwiches.text = sandwichesBought.ToString();
        }
        if(Pizzas){
            Pizzas.text = pizzasBought.ToString();
        }
        if(Meatloaf){
            Meatloaf.text = meatloafBought.ToString();
        }
        if(Steak){
            Steak.text = steakBought.ToString();
        }
    }
}
