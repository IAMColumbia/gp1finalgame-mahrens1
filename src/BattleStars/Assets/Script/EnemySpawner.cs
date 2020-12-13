using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    public GameObject enemy;

    protected override void SetupSpawnObject(GameObject go)
    {
        base.SetupSpawnObject(go);
        if (go.GetComponent<Enemy>() != null)
        {
            Enemy gs = go.GetComponent<Enemy>();
            gs.health = 50;
            gs.xpDrop = 10;
            gs.moneyDrop = 10;


        }
    }

    private void checkIfDead()
    {
        Enemy es = FindObjectOfType<Enemy>();
        if (es == null)
        {
            Spawn();
        }
    }

    void Update()
    {
        base.removeObjectInListToRemove();
        addDeadGhostsToRemoveList();
        checkIfDead();
    }

    protected void addDeadGhostsToRemoveList()
    {
        Enemy gs;
        foreach (GameObject go in this.gameObjects)
        {
            gs = go.GetComponent<Enemy>();
            if (go.GetComponent<Enemy>() != null)
            {
                if (gs.isDead == true)
                {
                    //remove dead enemies
                    this.objectsToRemove.Add(gs.gameObject);

                }
            }
        }
    }
}
