using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    private Animator anim;
    private EnemyMovement enemyMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyMovement = GetComponent<EnemyMovement>();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0) && cooldownTimer > attackCooldown && enemyMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("Attack");
        cooldownTimer = 0;
    }
}
