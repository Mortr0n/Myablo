using UnityEngine;

public class SkeletonFSMAI : BasicAI
{
    // current ai state
    private SkeletonStateBase currentState;

    [SerializeField] float maxWanderDistance = 6;
    Vector3 startPosition = Vector3.zero;

    public UnityEngine.AI.NavMeshAgent Agent
    {
        get { return agent; }
    }

    //public UnityEngine.AI.NavMeshAgent Agent { get { return agent; } }
    public float MaxWanderDistance { get { return maxWanderDistance; } }
    public Vector3 StartPosition { get { return startPosition; } }

    private void Start()
    {
        Debug.Log("Start FSMAI");
        startPosition = transform.position;
        ChangeState(new WanderingState(maxWanderDistance, startPosition));
    }


    protected override void RunAI()
    {
        if (currentState != null)
        {
            currentState.Update(this);
        }
    }

    public void ChangeState(SkeletonStateBase newState)
    {
        if (currentState != null && newState != null)
        {
            currentState.Exit(this);
        }
        currentState = newState;
        currentState.Enter(this);
    }

    public void TriggerWandering()
    {
        ChangeState(new WanderingState(maxWanderDistance, startPosition));
    }

    public void TriggerPursuing()
    {
        ChangeState(new PursuingState());
    }

    public void TriggerAttacking()
    {
        ChangeState(new AttackingState());
    }

    public override void TriggerDeath()
    {
        ChangeState(new DeadState());   
    }
}
