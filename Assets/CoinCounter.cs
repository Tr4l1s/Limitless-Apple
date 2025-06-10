using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
 public static CoinCounter instance;

    public TMP_Text coinText;
    public int currentCoins = 0;
    void Awake()
    {
        instance = this;
    }
    // Start
    void Start()
    {
        coinText.text = "KİWİ: " + currentCoins.ToString();

    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "KİWİ: " + currentCoins.ToString();
    
    }
}
