using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : IEnemyFactory
{
    public IArme GetArme()
    {
        return new BaguetteMagique();
    }

    public IArmure GetArmure()
    {
        return new Cape();
    }
}
