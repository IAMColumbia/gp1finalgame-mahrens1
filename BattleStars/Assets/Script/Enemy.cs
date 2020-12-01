using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public bool isDead;
    public int health;
    public int xpDrop;
    public int moneyDrop;

    public Button hitBox1;

    private void Update()
    {
        if (health <= 0)
        {
            EnemyKilled();
        }
    }

    public void EnemyKilled()
    {
        Player.Instance.money += (moneyDrop * Player.Instance.moneyModifier);
        Player.Instance.xp += (xpDrop * Player.Instance.xpModifier);

        isDead = true;
        //this.gameObject.SetActive(false);
    }

    public void Hit()
    {
        health -= Player.Instance.damage;
        ChangeHitboxLocation();
    }

    public virtual void ChangeHitboxLocation()
    {
        hitBox1.transform.position = new Vector2(Random.Range(400, 600), Random.Range(300, 500));
    }
}
