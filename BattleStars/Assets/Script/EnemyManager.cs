using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyList;
    private Vector2 spawnLocation;
    private GameObject enemy;
    private Enemy enemyMob;

    private void Start()
    {
        spawnLocation = new Vector2(500, 400);        
        LoadEnemy();
    }

    public void LoadEnemy()
    {
        enemy = (enemyList[Random.Range(0, 3)]);
        Instantiate(enemy, spawnLocation, Quaternion.identity, this.transform);
        enemyMob = enemy.GetComponent<Enemy>();
    }

    private void Update()
    {
        if(enemyMob.isDead == true)
        {
            Debug.Log("Dead");
            LoadEnemy();
        }
    }
}
