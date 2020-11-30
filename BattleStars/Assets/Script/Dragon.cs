using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon : Enemy
{

    private Button hitBox1;
    public bool isClicked;

    private void Awake()
    {
        isDead = false;
        hitBox1 = GetComponent<Button>();
        health = 10;
    }

    private void Update()
    {
        if(health <= 0)
        {
            EnemyKilled();
        }
    }

    public void Hit()
    {
        health -= Player.Instance.weapon.damage;
    }
}
