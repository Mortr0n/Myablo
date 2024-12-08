using UnityEngine;

public class AttackingState : SkeletonStateBase
{
    public override void Enter(SkeletonFSMAI ai)
    {
        base.Enter(ai);
        // start animation?  maybe animation would be in update?
    }
    
    public override void Update(SkeletonFSMAI ai)
    {
        //todo: something like?
        // if (!ai.TargetInAttackRange()) 
        //     ai.ChangeState(new PursuingState());
    }
}
