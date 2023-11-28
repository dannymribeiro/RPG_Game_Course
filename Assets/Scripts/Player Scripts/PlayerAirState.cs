using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirState : Player_State
{
    public PlayerAirState(Player _player, Player_State_Machine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {

    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if(player.IsWallDetected())
        {
            stateMachine.ChangeState(player.wallSlide);
        }

        if(xInput != 0)
        {
            player.SetVelocity(player.moveSpeed * .8f * xInput, rb.velocity.y);
        }

        if(player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
}
