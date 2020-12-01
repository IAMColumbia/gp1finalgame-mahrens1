﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public bool isDead;
    public int health;

    public void EnemyKilled()
    {
        Player.Instance.money++;
        Player.Instance.xp++;

        isDead = true;
        this.enabled = false;
        Destroy(this.gameObject);
    }

    public virtual void ChangeHitboxLocation()
    {

    }
}
