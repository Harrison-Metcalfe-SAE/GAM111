using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    // Navigation variables
    private NavMeshAgent agent;
    public GameObject target;
    GameObject player;

    /*
    public float playerDamage;
    public float enemyHealth = 100.0f;
    */

    // State Machine Enumerator 
    public enum EnemyState
    {
        Idle,
        Attack
    }

    public EnemyState enemyState;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        EnemyLogic();

        EnemyBehaviour();
    }
    // Taken from the inclass work (Survival FPS) and left mostly unchanged
    // Logical Transition Block
    void EnemyLogic()
    {
        // Raycast towards the player
        RaycastHit hit;

        if (Physics.Raycast(transform.position, (target.transform.position - transform.position).normalized, out hit)) { }
        // Hit Player
        if (hit.transform.tag == "Player")
        {
            // STATE TRANSITION ATTACK
            enemyState = EnemyState.Attack;
            Debug.DrawLine(transform.position, hit.point, Color.green);
        }
        // STATE TRANSITION IDLE
        else
        {
            enemyState = EnemyState.Idle;
            Debug.DrawLine(transform.position, hit.point, Color.red);
        }
    }

    void EnemyBehaviour()
    {
        switch (enemyState)
        {
            case EnemyState.Idle:
                break;

            case EnemyState.Attack:
                Attack();
                break;
        }
    }

    void Attack()
    {
        agent.SetDestination(target.transform.position);
    }
}