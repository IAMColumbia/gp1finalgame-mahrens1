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
        DamageUp.PurchasedDamageUpgrade(DamageUp.cost, DamageUp.bonus);   
    }

    public void MoneyUpgrade()
    {
        DamageUp.PurchasedMoneyUpgrade(MoneyUp.cost, MoneyUp.bonus);
    }

    public void XpUpgrade()
    {
        DamageUp.PurchasedXpUpgrade(XpUp.cost, XpUp.bonus);
    }
}
