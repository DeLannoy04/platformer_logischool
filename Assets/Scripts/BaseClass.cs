using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
    public string ClassName {  get; protected set; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence {  get; protected set; }
    public int Agility { get; protected set; }
    public int Damage { get; protected set; }
    public bool Shoot { get; protected set; }  
}
