using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;
    [SerializeField] private float CountDown = 0;

    // Start is called before the first frame update
    void Start()
    {
        CountDown = MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        //Count down
        CountDown -= Time.deltaTime;

        //Restart the level if the time runs out
        if(CountDown <= 0)
        {
            //Reset coin count and scene
            Coin.CoinCount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
