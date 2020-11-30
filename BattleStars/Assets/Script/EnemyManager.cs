using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyList;
    private Vector2 spawnLocation;

    private void Start()
    {
        spawnLocation = new Vector2(0, 0);
        enemyList = new List<GameObject>();
        LoadEnemy();
    }

    public void LoadEnemy()
    {
        var enemy = enemyList[Random.Range(0, 3)];
        Instantiate(enemy, spawnLocation, Quaternion.identity, this.transform);
    }

    private void Update()
    {
        var enemy = GameObject.FindGameObjectWithTag("Enemy");

        if(enemy.isDead == true)
        {
            LoadEnemy();
        }
    }
}
