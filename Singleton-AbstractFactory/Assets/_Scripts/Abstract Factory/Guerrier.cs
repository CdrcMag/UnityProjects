using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrier : IEnemyFactory
{
    public IArme GetArme()
    {
        return new Epee();
    }

    public IArmure GetArmure()
    {
        return new GrosseArmure();
    }

}
