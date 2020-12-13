using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon Axe;
    public Weapon Sword;
    public Weapon Bow;
    public Weapon fists;

    // Start is called before the first frame update
    void Start()
    {
        fists = new Weapon();
        fists.damage = 0;
        Player.Instance.weapon = fists;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PurchasedAxe()
    {
        Axe.PurchasedWeapon(Axe.cost, Axe);
        Axe.EquipWeapon(Axe, Player.Instance.weapon);
    }

    public void PurchasedSword()
    {
        Sword.PurchasedWeapon(Sword.cost, Sword);
        Sword.EquipWeapon(Sword, Player.Instance.weapon);
    }

    public void PurchasedBow()
    {
        Bow.PurchasedWeapon(Bow.cost, Bow);
        Bow.EquipWeapon(Bow, Player.Instance.weapon);
    }
}
