using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bug : Enemy
{

    public Button hitBox1;

    private void Awake()
    {
        isDead = false;
        hitBox1 = (Button)FindObjectOfType(typeof(Button));
        health = 50;
    }

    private void Update()
    {
        if (health <= 0)
        {
            EnemyKilled();
        }
    }

    public void Hit()
    {
        health -= Player.Instance.damage;
        ChangeHitboxLocation();
    }

    public override void ChangeHitboxLocation()
    {
        hitBox1.transform.position = new Vector2(Random.Range(400, 600), Random.Range(300, 500));
    }
}
