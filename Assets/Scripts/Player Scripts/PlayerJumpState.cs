using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : Player_State
{
    public PlayerJumpState(Player _player, Player_State_Machine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {

    }

    public override void Enter()
    {
        base.Enter();

        rb.velocity = new Vector2(rb.velocity.x, player.jumpForce);
    }

    public virtual void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if(rb.velocity.y < 0)
        {
            stateMachine.ChangeState(player.airState);
        }
    }
}
