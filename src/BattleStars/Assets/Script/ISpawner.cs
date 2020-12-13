using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawner 
{
    void Spawn();
}

public interface IUnitySpawner : ISpawner
{
    bool SpawnerEnabled { get; set; }

    void addGameObject(GameObject spawn);

    void setupSpawnObject(GameObject go);
}
