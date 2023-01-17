using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singer : GAgent
{
    new void Start()
    {
        base.Start();

        SubGoal s1 = new SubGoal("arriveScenario", 1, true);
        SubGoal s2 = new SubGoal("perform", 1, true);
        SubGoal s3 = new SubGoal("leaveScenario", 1, true);
        goals.Add(s1, 5);
        goals.Add(s2, 10);
        goals.Add(s3, 10);
    }
}
