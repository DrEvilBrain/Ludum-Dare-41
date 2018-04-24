using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour {

    //bad spaghetti code ahead

    public GameObject[] deckCards = new GameObject[60];
    private List<GameObject> availableCards = new List<GameObject>();
    public List<GameObject> allCards = new List<GameObject>();

    public static GameObject[] startingCards = new GameObject[18];

    public static Sprite[] newHand = new Sprite[5];

    public GameObject[] hat = new GameObject[10];
    public GameObject[] glasses = new GameObject[10];
    public GameObject[] shirt = new GameObject[10];
    public GameObject[] pants = new GameObject[10];
    public GameObject[] shoes = new GameObject[10];
    public GameObject[] items = new GameObject[10];

    private int[] randomInt = { -1, -1, -1 };

    public Button turnEnd;

    private int numToAdd;

    private int nextArrayVal;

    // Use this for initialization
    void Start () {
        turnEnd.onClick.AddListener(MakeHand);

        /*for (int i = 0; i < 3; i++) //pick 3 sets
        {
            int numToAdd = Random.Range(0, 9);
            if (randomInt[0] == numToAdd || randomInt[1] == numToAdd || randomInt[2] == numToAdd)
            {
                numToAdd = Random.Range(0, 9);
            }
            randomInt[i] = numToAdd;

            deckCards[i] = hat[numToAdd];
            deckCards[i+3] = glasses[numToAdd];
            deckCards[i+6] = shirt[numToAdd];
            deckCards[i+9] = pants[numToAdd];
            deckCards[i+12] = shoes[numToAdd];
            deckCards[i+15] = items[numToAdd];
        }

        for (int i = 0; i < 18; i++)
        {
            startingCards[i] = deckCards[i];
        }

        nextArrayVal = 18;*/
    }

    public static void AddOwnedCard(GameObject card)
    {
        
    }

    void MakeHand()
    {
        int temp;

        for (int i = 0; i < 5; i++)
        {
            temp = Random.Range(0, 60);

            newHand[i] = deckCards[temp].GetComponent<Image>().sprite;
            Debug.Log(newHand[i]);
        }
    }
}
