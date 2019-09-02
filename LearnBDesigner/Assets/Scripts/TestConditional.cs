using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class TestConditional : Conditional {

    public SharedTransform SharedTarget;
    public override TaskStatus OnUpdate()
    {
        return TaskStatus.Failure;
    }
}
