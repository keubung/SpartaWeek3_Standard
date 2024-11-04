using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedZone : MonoBehaviour
{
    public int damage;
    public float damageRate;

    List<IDamagalbe> things = new List<IDamagalbe>();

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Dealdmage", 0, damageRate);
    }

    void Dealdmage()
    {
        for (int i = 0; i < things.Count; i++)
        {
            things[i].TakePhysicalDamage(damage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamagalbe damagalbe))
        {
            things.Add(damagalbe);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out IDamagalbe damagalbe))
        {
            things.Remove(damagalbe);
        }
    }
}