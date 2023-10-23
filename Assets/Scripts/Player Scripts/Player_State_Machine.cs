using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_State_Machine
{
    public Player_State currentState;

    public void Initialize(Player_State _startState)
    {
        currentState = _startState;
        currentState.Enter();
    }

    public void ChangeState(Player_State _newState)
    {
        Debug.Log(_newState.animBoolName);
        Debug.Log(currentState.animBoolName);
        currentState.Exit();
        currentState = _newState;
        currentState.Enter();
    }
}
