using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    public Button[] cardList = new Button[60];
    public static Button[] cards = new Button[60];
    public Text moneyUI;
    public Sprite sold;

    public static bool[] cardOwned = new bool[60];

    public Button shop;

    // Use this for initialization
    void Start()
    {
        shop.onClick.AddListener(MarkOwned);

        cards = cardList;

        for (int i = 0; i < 60; i++)
        {
            int cardNumber = i;
            cardList[i].GetComponent<Button>().onClick.AddListener(() => PurchaseCard(cardNumber));
            cardOwned[i] = false;
            Deck.AddOwnedCard(cardList[cardNumber].gameObject);
        }
    }

    void PurchaseCard(int cardNumber)
    {
        if (Money.moneyVal >= 100)
        {
            Money.moneyVal -= 100;
            //cardList[cardNumber].image.sprite = sold;
            cardList[cardNumber].enabled = false;
            cardOwned[cardNumber] = true;
            Deck.AddOwnedCard(cardList[cardNumber].gameObject);
        }

        moneyUI.text = Money.moneyVal.ToString();
    }

    public void MarkOwned()
    {

        /*for(int i = 0; i < 18; i++)
        {
            if (cardList[i].gameObject.GetComponent<Image>().sprite.name == Deck.startingCards[i].GetComponent<Image>().sprite.name)
            {
                Debug.Log(Deck.startingCards[i]);
                Debug.Log(cardList[i]);

                cardList[i].image.sprite = sold;
                cardList[i].enabled = false;
                cardOwned[i] = true;
            }
        }*/
    }
}