using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Skeleton : Enemy
{
    public SkeletonIdleState idleState;
    public SkeletonMoveState moveState;
    public SkeletonBattleState battleState;
    public SkeletonAttackState attackState;
    public SkeletonStunnedState stunnedState;

    protected override void Awake()
    {
        base.Awake();

        idleState = new SkeletonIdleState(this, stateMachine, "Idle", this);
        moveState = new SkeletonMoveState(this, stateMachine, "Move", this);
        battleState = new SkeletonBattleState(this, stateMachine, "Move", this);
        attackState = new SkeletonAttackState(this, stateMachine, "Attack", this);
        stunnedState = new SkeletonStunnedState(this, stateMachine, "Stunned", this);
    }

    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(idleState);
    }

    protected override void Update()
    {
        base.Update();

        if(Input.GetKeyDown(KeyCode.U))
        {
            stateMachine.ChangeState(stunnedState);
        }
    }

    protected override bool CanBeStunned()
    {
        if(base.CanBeStunned())
        {
            stateMachine.ChangeState(stunnedState);
            return true;
        }

        return false;
    }
}
