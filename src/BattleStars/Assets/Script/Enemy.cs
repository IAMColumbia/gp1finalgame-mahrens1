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
    }

    public IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(sec);
    }
}
