using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallJumpState : Player_State
{
    public PlayerWallJumpState(Player _player, Player_State_Machine _stateMachine, string _animBoolName) : base (_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        stateTimer = .4f;
        player.SetVelocity(5 * -player.facingDir, player.jumpForce);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if (stateTimer < 0)
        {
            stateMachine.ChangeState(player.airState);
        }

        if (player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
}
