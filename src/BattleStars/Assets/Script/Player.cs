using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private static Player _instance;

    public Text moneyText, xpText;

    public static Player Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        _instance = this;
    }

    public Weapon weapon;

    public float damage;

    public float money;
    public float moneyModifier;

    public float xp;
    public float xpModifier;

    public void Start()
    {
        xp = 100;
        xpModifier = 1;
        money = 100;
        moneyModifier = 1;

        damage = 10;

        moneyText.text = "$ " + Math.Round(money).ToString();
        xpText.text = "XP: " + Math.Round(xp).ToString();
    }

    public void Update()
    {
        moneyText.text = "$ " + Math.Round(money).ToString();
        xpText.text = "XP: " + Math.Round(xp).ToString();
    }

    public void UpdatePlayerDamage(Weapon pw, Weapon nw)
    {
        damage = Math.Abs(pw.damage - nw.damage);
    }
}
