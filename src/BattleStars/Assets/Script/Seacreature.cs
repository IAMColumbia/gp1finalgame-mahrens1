using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seacreature : Enemy
{

    //public Button hitBox1;

    private void Awake()
    {
        isDead = false;
        hitBox1 = (Button)FindObjectOfType(typeof(Button));
        health = 30;
    }

    private void Update()
    {
        if (health <= 0)
        {
            EnemyKilled();
            EnemyManager.Instance.OnEmyDeath();
            StartCoroutine(Wait(0.5f));
            Destroy(gameObject);
        }
    }
    /*
    public void Hit()
    {
        health -= Player.Instance.damage;
        ChangeHitboxLocation();
    }

    public void ChangeHitboxLocation()
    {
        hitBox1.transform.position = new Vector2(Random.Range(400, 600), Random.Range(300, 500));
    }
    */
}
