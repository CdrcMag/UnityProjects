using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    IEnemyFactory factory = null;

    public enum EnemyType
    {
        Guerrier, Mage
    };

    public void SpawnEnemy(EnemyType enemy)
    {
        switch(enemy)
        {
            case EnemyType.Guerrier: SpawnGuerrier(); break;
            case EnemyType.Mage: SpawnMage(); break;
            default: break;
        }
    }

    private void SpawnMage()
    {
        factory = new Mage();
        print("Mage fabriqué. STATS : " + factory.GetArme().Item() + " et " + factory.GetArmure().Item());
    }

    private void SpawnGuerrier()
    {
        factory = new Guerrier();
        print("Guerrier fabriqué. STATS : " + factory.GetArme().Item() + " et " + factory.GetArmure().Item());
    }

}
