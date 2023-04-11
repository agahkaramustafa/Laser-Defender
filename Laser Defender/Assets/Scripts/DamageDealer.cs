using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int damage = 15;

    public int GetDamage { get {return damage;} }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
