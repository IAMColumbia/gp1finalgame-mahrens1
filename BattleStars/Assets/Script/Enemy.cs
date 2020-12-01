using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState { Dragon, Bug, Seacreature}

public class Enemy : MonoBehaviour
{
    public EnemyState state;

    private int enemyInt;

    public void EnemyKilled()
    {
        this.enemyInt++;
        ChangeEnemy();
    }

    private void ChangeEnemy()
    {
        switch (enemyInt)
        {
            case 1:
                state = EnemyState.Dragon;
                break;

            case 2:
                state = EnemyState.Bug;
                break;

            case 3:
                state = EnemyState.Seacreature;
                break;
        }
    }
}
