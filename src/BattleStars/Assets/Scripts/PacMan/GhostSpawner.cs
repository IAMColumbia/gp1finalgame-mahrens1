using UnityEngine;
using System.Collections;

public class GhostSpawner : Spawner
{

    public GameObject enemy;

    protected override void setupSpawnObject(GameObject go)
    {
        base.setupSpawnObject(go);
        if(go.GetComponent<Enemy>() != null)
        {
            Enemy gs = go.GetComponent<Enemy>();
            gs.health = 50;
            gs.xpDrop = 10;
            gs.SetUpEnemy();
           
        }
    }

    void Update()
    {
        base.removeObjectInListToRemove();
        addDeadGhostsToRemoveList();
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
