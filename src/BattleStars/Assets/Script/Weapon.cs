using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public int damage;
    public int cost;

    private void Start()
    {

    }

    public void PurchasedWeapon(float cost, Weapon w)
    {
        if(Player.Instance.money >= cost)
        {
            Player.Instance.money -= cost;
        }
    }

    public void EquipWeapon(Weapon weapon, Weapon pw)
    {
        Player.Instance.weapon = weapon;
        Player.Instance.UpdatePlayerDamage(pw, weapon);
    }
}
