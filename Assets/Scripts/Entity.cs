using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    EntityData entityData;

    void OnEnable()
    {
        entityData.ageState = EntityData.AgeState.Child;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetEntityData(EntityData data)
    {
        entityData = data;
    }

    public EntityData GetEntityData()
    {
        return entityData;
    }

    public void SetAgeState(EntityData.AgeState state)
    {
        entityData.ageState = state;
    }

    public EntityData.AgeState GetAgeState()
    {
        return entityData.ageState;
    }
}

public struct EntityData
{
    public enum AgeState
    {
        Child,
        Teen,
        Adult,
        Elderly,
        Dead
    }

    public enum Gender
    {
        Male,
        Female,
        NonBinary
    }

    public AgeState ageState;
    public Gender gender;

    public float
        age,
        health,
        fertility,
        lifespan,
        size,
        speed,
        attack,
        defense;
}
