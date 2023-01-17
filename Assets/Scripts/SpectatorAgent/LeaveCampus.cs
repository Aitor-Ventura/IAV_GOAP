using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveCampus : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        Destroy(gameObject);
        return true;
    }
}
