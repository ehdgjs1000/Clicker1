using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public static MonsterSpawner instance;

    [SerializeField] private Monster[] monsterPrefabs;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    public void SpawnMonster(int _gameLevel)
    {
        Instantiate(monsterPrefabs[_gameLevel-1],
            new Vector3(0,0,0), Quaternion.identity);

    }

}
