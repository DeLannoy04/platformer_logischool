using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]private BaseWarrior parentWarrior;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var warrior = collision.GetComponent<BaseWarrior>();

        if(warrior != null && warrior != parentWarrior)
        {
            Destroy(collision.gameObject);
        }
    }


    public void AttackStart()
    {

    }
    public void AttackEnd()
    {

    }
}
