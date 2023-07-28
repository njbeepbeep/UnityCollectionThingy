using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Keeps track of the total coin count
    public static int CoinCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Object Created");

        ++Coin.CoinCount;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        --Coin.CoinCount;
        if(Coin.CoinCount <= 1)
        {
            // Yay!
        }
    }
}
