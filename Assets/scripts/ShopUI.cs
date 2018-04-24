using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour {

    public Button shopButton;
    public Button shopExit;
    public GameObject shopUI;

    void Start()
    {
        shopUI.SetActive(false);

        shopButton.onClick.AddListener(EnterShop);
        shopExit.onClick.AddListener(ExitShop);
    }

    void EnterShop()
    {
        Debug.Log("Entered Shop");
        shopUI.SetActive(true);
    }

    void ExitShop()
    {
        Debug.Log("Exited Shop");
        shopUI.SetActive(false);
    }
}
