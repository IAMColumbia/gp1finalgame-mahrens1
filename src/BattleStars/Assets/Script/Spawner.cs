using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour, IUnitySpawner
{
    public bool SpawnerEnabled { get; set; }

    public GameObject SpawnObject;
    public bool Enabled = true;

    protected List<GameObject> gameObjects;
    protected List<GameObject> objectsToRemove;
    // Use this for initialization 
    void Start()
    {
        this.gameObjects = new List<GameObject>();
        this.objectsToRemove = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        removeObjectInListToRemove();

        Spawn();

    }

    protected void removeObjectInListToRemove()
    {
        //remove objects in Object to remove list
        foreach (GameObject go in this.objectsToRemove)
        {
            this.gameObjects.Remove(go);
            Object.Destroy(go); //Not preffered better to reuse
        }
    }

    public void Spawn()
    {
        if (Enabled)
        {
            GameObject spawn = (GameObject)Instantiate(SpawnObject, this.transform.position, Quaternion.identity, this.transform);
            setupSpawnObject(spawn); //virtual hook for setting up game object
            this.addGameObject(spawn);
        }
    }

    public virtual void addGameObject(GameObject spawn)
    {
        gameObjects.Add(spawn);
    }

    protected virtual void SetupSpawnObject(GameObject go)
    {
        //Nothing todo should override with specific type
    }

    public void setupSpawnObject(GameObject go)
    {

    }

}
