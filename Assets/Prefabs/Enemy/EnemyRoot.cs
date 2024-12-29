using UnityEngine;
using UnityEngine.AI;

public class EnemyRoot : ConstantHolder
{
    [Header("Gülücük")]
    [SerializeField] public EnemyMeleeAttack enemyMeleeAttack;
    [SerializeField] public EnemyMovement enemyMovement;
    [SerializeField] public NavMeshAgent agent;
    [SerializeField] public Transform target;
    [SerializeField] public GameObject hitBox;
}
