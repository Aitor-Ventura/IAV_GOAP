using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spectator : GAgent
{
    new void Start()
    {
        base.Start();

        SubGoal s1 = new SubGoal("arriveCampus", 1, true);
        SubGoal s2 = new SubGoal("watch", 1, true);
        SubGoal s3 = new SubGoal("leaveCampus", 1, true);
        goals.Add(s1, 0);
        goals.Add(s2, 5);
        goals.Add(s3, 10);
    }
}
