public class Coin : MonoBehaviour

{
    //Keeps track of total coin count in scene

    public static int CoinCount = 0;

    void Start()

    {
        //Object created, increment coin count
        ++Coin.CoinCount;
    }

    //Called when object is destroyed

    void OnDestroy()

    {
        --Coin.CoinCount;

        if (Coin.CoinCount <= 0)

        {
            //We have won
        }
    }
}