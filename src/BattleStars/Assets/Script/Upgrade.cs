using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public int bonus;
    public int cost;

    public void PurchasedUpgrade(float currency, float stat)
    {
        if(currency >= cost)
        {
            Debug.Log("Made It");
            currency -= this.cost;

            stat += this.bonus;
        }
    }
}
