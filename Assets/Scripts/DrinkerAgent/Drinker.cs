using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drinker : GAgent
{
    new void Start()
    {
        base.Start();

        SubGoal s1 = new SubGoal("arriveCampus", 1, true);
        SubGoal s2 = new SubGoal("drink", 1, true);
        SubGoal s3 = new SubGoal("leaveCampus", 1, true);
        goals.Add(s1, 0);
        goals.Add(s2, 5);
        goals.Add(s3, 10);
    }
}