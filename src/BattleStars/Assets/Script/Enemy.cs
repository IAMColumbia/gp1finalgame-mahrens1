using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public bool isDead;
    public float health;
    public int xpDrop;
    public int moneyDrop;

    public Button hitBox1;

    public List<Sprite> enemysprites;
    public Image enemyImage;

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
        if(isDead == true)
        {
            ResetEnemy();
        }
    }

    public void EnemyKilled()
    {
        Player.Instance.money += (moneyDrop * Player.Instance.moneyModifier);
        Player.Instance.xp += (xpDrop * Player.Instance.xpModifier);
        isDead = true;
    }

    public void ResetEnemy()
    {
        health = 50;

        if(this.health <= Player.Instance.damage)
        {
            this.health = Player.Instance.damage * 2.5f;
        }
        else
        {
            this.health = 50;
        }
        xpDrop = 10;
        moneyDrop = 10;
        isDead = false;
        enemyImage.sprite = enemysprites[Random.Range(0, 3)];
    }

    public IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
    }

    public void Hit()
    {
        health -= Player.Instance.damage;
        ChangeHitboxLocation();
    }

    public void ChangeHitboxLocation()
    {
        hitBox1.transform.position = new Vector2(Random.Range(400, 600), Random.Range(300, 500));
    }

}
