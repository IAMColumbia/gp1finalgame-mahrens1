using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public bool isDead;
    public int health;

    public void EnemyKilled()
    {
        isDead = true;
        Destroy(gameObject);
    }

    public void ChangeHitboxLocation()
    {

    }
}
