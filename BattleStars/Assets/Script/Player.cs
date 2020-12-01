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

    public int money;

    public int xp;

    public void Start()
    {
        xp = 0;
        money = 0;

        moneyText.text = "$ " + money.ToString();
        xpText.text = "XP: " + xp.ToString();
    }

    public void Update()
    {
        moneyText.text = "$ " + money.ToString();
        xpText.text = "XP: " + xp.ToString();
    }
}
