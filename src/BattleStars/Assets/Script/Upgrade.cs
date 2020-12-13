using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public int bonus;
    public int cost;

    public void PurchasedDamageUpgrade(float cost, float bonus)
    {
        if(Player.Instance.xp >= cost)
        {
            Player.Instance.xp -= cost;

            Player.Instance.damage += bonus;
        }
    }

    public void PurchasedXpUpgrade(float cost, float bonus)
    {
        if (Player.Instance.money >= cost)
        {
            Player.Instance.money -= cost;

            Player.Instance.xpModifier += bonus;
        }
    }

    public void PurchasedMoneyUpgrade(float cost, float bonus)
    {
        if (Player.Instance.xp >= cost)
        {
            Player.Instance.xp -= cost;

            Player.Instance.moneyModifier += bonus;
        }
    }
}
