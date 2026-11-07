
using UnityEngine;

public class GoldCoinHighlighter : MonoBehaviour
{
    public GameObject[] coins;
    public int goldValue = 5;

    void Start()
    {
        int goldCount = 0;

        foreach (GameObject coin in coins)
        {
            CoinData data = coin.GetComponent<CoinData>();

            if (data != null && data.value >= goldValue)
            {
                coin.GetComponent<Renderer>().material.color = Color.yellow;

                goldCount++;

                Debug.Log("Gold coin: " + coin.name + " (" + data.value + ")");
            }
        }

        Debug.Log("Total gold coins: " + goldCount);
    }
}

