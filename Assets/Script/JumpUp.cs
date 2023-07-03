using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUp : ItemBase2D
{

    public override void Activate()
    {
        FindObjectOfType<UsagiJump>()._moveJumpPower = 25;
        FindObjectOfType<UsagiJump>()._jumpPower = 25;
    }
}
