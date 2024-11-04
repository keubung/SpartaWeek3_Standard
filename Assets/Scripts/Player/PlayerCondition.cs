using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagalbe
{
    void TakePhysicalDamage(int damage);
}

public class PlayerCondition : MonoBehaviour, IDamagalbe
{
    public UICondition uICondition;

    Condition health { get { return uICondition.health; } }
    Condition skillPoint { get { return uICondition.skillPoint; } }

    void Update()
    {
        if (health.curValue == 0f)
        {
            Die();
        }
    }

    public void Heal(float amout)
    {
        health.Add(amout);
    }

    public void SkillPointItem(float amount)
    {
        skillPoint.Add(amount);
    }

    public void Die()
    {
        Debug.Log("Die!");
    }

    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);
    }

    public void UseSkill(int point)
    {
        skillPoint.Subtract(point);
    }
}
