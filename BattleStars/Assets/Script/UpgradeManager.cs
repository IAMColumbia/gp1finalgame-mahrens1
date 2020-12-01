using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    //public Button damageButton, moneyButton, xpButton;
    public Upgrade DamageUp;
    public Upgrade MoneyUp;
    public Upgrade XpUp;

    public void DamageUpgrade()
    {
        Debug.Log("Clicked");
        DamageUp.PurchasedUpgrade(Player.Instance.xp, Player.Instance.damage);   
    }

    public void MoneyUpgrade()
    {
        Debug.Log("Clicked");
        DamageUp.PurchasedUpgrade(Player.Instance.xp, Player.Instance.moneyModifier);
    }

    public void XpUpgrade()
    {
        Debug.Log("Clicked");
        DamageUp.PurchasedUpgrade(Player.Instance.xp, Player.Instance.xpModifier);
    }
}
