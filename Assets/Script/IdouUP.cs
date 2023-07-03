using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdouUP : ItemBase2D
{

    public override void Activate()
    {
        FindObjectOfType<UsagiIdou>()._movePower = 35;
    }
}
