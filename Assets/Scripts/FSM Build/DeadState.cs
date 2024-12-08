using UnityEngine;

public class DeadState : SkeletonStateBase
{
    public override void Enter(SkeletonFSMAI aI)
    {
        base.Enter(aI);
        // Trigger death animation
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: maybe remove or destroy object after a bit using Coroutine?
    }
}
