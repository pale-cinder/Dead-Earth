﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum AIStateType { None, Idle, Alerted, Patrol, Attack, Feeding, Pursuit, Dead }
public enum AITargerTyoe { None, Waypoint, Visual_Player, Visual_Light, Visual_Food, Audio }


// Potential targets to the AI System
public struct AITarget
{
    //Target type
    private AIStateType _type; 

    private Collider _collider;

    //Current possition in the world
    private Vector3 _position;

    //Distance from player
    private float _distance;

    //Time the target was ping'd at last
    private float _time;
}


public abstract class AIStateMachine : MonoBehaviour
{

    //First of all - what the current state is

    //Key to the dictionary                   

    //Private

    private Dictionary<AIStateType, AIState>    _states = new Dictionary<AIStateType, AIState > ();

    protected virtual void Start ()
    {
        AIState[] states = GetComponent<AIState>();
        
        //Make shure that the dictionary doesn't have an AI state that has AIState key

        //Check the valid
        //Loop through all states and addd them to the state dictionary


        foreach (AIState state in states)
        {
            if (state! = null && !_states.ContainsKey(state.GetStateType)))
                {
                _states[state.GetStateType()] = state;
            }
        }
    }

}
