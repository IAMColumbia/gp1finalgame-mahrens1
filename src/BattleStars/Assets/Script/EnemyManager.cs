using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    static EnemyManager _instance;
    public static EnemyManager Instance
    {
        get { return _instance; }
    }

    [SerializeField] List<GameObject> enemyList;
    private Vector2 spawnLocation;
    private GameObject enemy;

    int spawnCount;
    int currentCount;

    public int CurrentEnemyCount
    {
        get { return currentCount; }
        set
        {
            currentCount = value;
            if(currentCount <= 0)
            {
                CreateEnemy();
            }
        }
    }

    void CreateEnemy()
    {
        enemy = enemyList[Random.Range(0, 3)];
        Instantiate(enemy, spawnLocation, Quaternion.identity, this.transform);
        currentCount++;
    }

    private void Start()
    {
        _instance = this;
        spawnLocation = new Vector2(500, 400);       
        CreateEnemy();
    }

    public void OnEmyDeath()
    {
        currentCount--;
    }

    public void HideEnemy()
    {
        if(enemy.activeInHierarchy == true)
        {
            enemy.SetActive(false);
        }
        else
        {
            enemy.SetActive(true);
        }
    }

}
