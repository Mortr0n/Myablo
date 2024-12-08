using UnityEngine;

public class SkeletonStateBase
{
    public virtual void Enter(SkeletonFSMAI ai) { }
    public virtual void Exit(SkeletonFSMAI ai) { }
    public virtual void Update(SkeletonFSMAI ai) { }
    
}
