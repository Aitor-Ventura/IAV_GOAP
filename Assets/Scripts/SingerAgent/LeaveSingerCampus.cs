using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveSingerCampus : GAction
{
    public delegate void SingerDestroyed();
    public static event SingerDestroyed OnSingerDestroyed;
    
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        if (OnSingerDestroyed != null)
        {
            OnSingerDestroyed();
        }
        Destroy(gameObject);
        return true;
    }
}
