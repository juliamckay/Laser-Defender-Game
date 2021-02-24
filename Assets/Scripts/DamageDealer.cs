﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    //config
    [SerializeField] int damage = 100;

    //getters
    public int GetDamage()
    {
        return damage;
    }
    
    public void Hit()
    {
        Destroy(gameObject);
    }

}
