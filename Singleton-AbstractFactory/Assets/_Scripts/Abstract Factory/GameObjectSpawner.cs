using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
    Client client = new Client();

    private void Start()
    {
        client.SpawnEnemy(Client.EnemyType.Guerrier);
    }



}
