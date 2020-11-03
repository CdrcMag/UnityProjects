using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyFactory
{
    IArme GetArme();
    IArmure GetArmure();

}
