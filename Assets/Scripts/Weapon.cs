using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]private BaseWarrior parentWarrior;
    [SerializeField] private BoxCollider2D boxCollider;

    [SerializeField] private Animator animator;


   
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var warrior = collision.GetComponent<BaseWarrior>();

        if(warrior != null && warrior != parentWarrior)
        {
            Destroy(collision.gameObject);
        }
    }

    public void Attack()
    {
        animator.SetTrigger("Attack");
    }

    public void AttackStart()
    {
        boxCollider.enabled = true;
    }
    public void AttackEnd()
    {
        boxCollider.enabled = false;
    }
}
