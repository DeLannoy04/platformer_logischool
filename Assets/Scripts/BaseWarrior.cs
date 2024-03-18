using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarrior : BaseClass
{
    public BaseWarrior(int health, int strength, int intelligence, int agility, int damage, bool shoot)
    {
        ClassName = "Warrior";
        Health = health;
        Strength = strength;    
        Intelligence = intelligence;    
        Agility = agility;
        Damage = damage;
        Shoot = shoot;
    }
    public BaseWarrior()
    {
        ClassName = "Warrior";
        Health = 100;
        Strength = 20;
        Intelligence = 40;
        Agility = 10;
        Damage = 10;
        Shoot = false;
    }
}
