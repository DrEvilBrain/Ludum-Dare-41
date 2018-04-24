using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour {

    //i vow to one day maybe fix this and make it less messy

    public Button turnEnd;
    public GameObject[] hand = new GameObject[5];
    public Image[] model = new Image[6]; //in order of glasses, hat, item, shoe, pants, shirt

    public Sprite[] glasses = new Sprite[10];
    public Sprite[] hat = new Sprite[10];
    public Sprite[] item = new Sprite[10];
    public Sprite[] shoes = new Sprite[10];
    public Sprite[] pants = new Sprite[10];
    public Sprite[] shirt = new Sprite[10];

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 5; i++)
        {
            int cardNumber = i;
            hand[i].GetComponent<Button>().onClick.AddListener(() => PlayCard(cardNumber));
        }

        turnEnd.onClick.AddListener(ShuffleHand);
    }

    void PlayCard(int cardNumber)
    {
        //wall of if else spaghetti to determine card abilities and how it changes clothing on character

        if(hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_1") //GLASSES
        {
            model[0].sprite = glasses[0];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_2")
        {
            model[0].sprite = glasses[1];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_3")
        {
            model[0].sprite = glasses[2];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_4")
        {
            model[0].sprite = glasses[3];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_5")
        {
            model[0].sprite = glasses[4];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_6")
        {
            model[0].sprite = glasses[5];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_7")
        {
            model[0].sprite = glasses[6];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_8")
        {
            model[0].sprite = glasses[7];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_9")
        {
            model[0].sprite = glasses[8];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_glasses_10")
        {
            model[0].sprite = glasses[9];
        }
        //----------------------------------------------------------------------------
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_1") //HATS
        {
            model[1].sprite = hat[0];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_2")
        {
            model[1].sprite = hat[1];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_3")
        {
            model[1].sprite = hat[2];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_4")
        {
            model[1].sprite = hat[3];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_5")
        {
            model[1].sprite = hat[4];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_6")
        {
            model[1].sprite = hat[5];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_7")
        {
            model[1].sprite = hat[6];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_8")
        {
            model[1].sprite = hat[7];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_9")
        {
            model[1].sprite = hat[8];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_hat_10")
        {
            model[1].sprite = hat[9];
        }
        //----------------------------------------------------------------------------
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_1") //ITEM
        {
            model[2].sprite = item[0];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_2")
        {
            model[2].sprite = item[1];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_3")
        {
            model[2].sprite = item[2];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_4")
        {
            model[2].sprite = item[3];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_5")
        {
            model[2].sprite = item[4];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_6")
        {
            model[2].sprite = item[5];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_7")
        {
            model[2].sprite = item[6];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_8")
        {
            model[2].sprite = item[7];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_9")
        {
            model[2].sprite = item[8];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_item_10")
        {
            model[2].sprite = item[9];
        }
        //----------------------------------------------------------------------------
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_1") //SHOES
        {
            model[3].sprite = shoes[0];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_2")
        {
            model[3].sprite = shoes[1];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_3")
        {
            model[3].sprite = shoes[2];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_4")
        {
            model[3].sprite = shoes[3];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_5")
        {
            model[3].sprite = shoes[4];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_6")
        {
            model[3].sprite = shoes[5];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_7")
        {
            model[3].sprite = shoes[6];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_8")
        {
            model[3].sprite = shoes[7];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_9")
        {
            model[3].sprite = shoes[8];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shoes_10")
        {
            model[3].sprite = shoes[9];
        }
        //----------------------------------------------------------------------------
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_1") //PANTS
        {
            model[4].sprite = pants[0];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_2")
        {
            model[4].sprite = pants[1];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_3")
        {
            model[4].sprite = pants[2];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_4")
        {
            model[4].sprite = pants[3];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_5")
        {
            model[4].sprite = pants[4];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_6")
        {
            model[4].sprite = pants[5];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_7")
        {
            model[4].sprite = pants[6];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_8")
        {
            model[4].sprite = pants[7];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_9")
        {
            model[4].sprite = pants[8];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_pants_10")
        {
            model[4].sprite = pants[9];
        }
        //----------------------------------------------------------------------------
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_1") //SHIRTS
        {
            model[5].sprite = shirt[0];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_2")
        {
            model[5].sprite = shirt[1];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_3")
        {
            model[5].sprite = shirt[2];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_4")
        {
            model[5].sprite = shirt[3];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_5")
        {
            model[5].sprite = shirt[4];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_6")
        {
            model[5].sprite = shirt[5];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_7")
        {
            model[5].sprite = shirt[6];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_8")
        {
            model[5].sprite = shirt[7];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_9")
        {
            model[5].sprite = shirt[8];
        }
        else if (hand[cardNumber].GetComponent<Image>().sprite.name == "card_shirt_10")
        {
            model[5].sprite = shirt[9];
        }

        //end wall of if else spaghetti

        hand[cardNumber].SetActive(false);
    }

    void ShuffleHand()
    {
        for (int i = 0; i < 5; i++)
        {
            hand[i].SetActive(true);
            hand[i].GetComponent<Image>().sprite = Deck.newHand[i];
        }
    }
}