using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    [SerializeField] private float retreatDistance = 5f;
    public void MoveTo(NavMeshAgent agent,float speed, Vector2 targetPosition)
    {
        // Establece la velocidad del agente
        agent.speed = speed;

        // Si la distancia al objetivo es mayor a 1.5 unidades, mueve el agente hacia el objetivo
        if (Vector2.Distance(transform.position, targetPosition) > 1.5f)
        {
            agent.SetDestination(targetPosition);
        }
    }
    public void Wander(NavMeshAgent agent, float speed, float wanderRadius)
    {
        // Generar una posición aleatoria dentro de un círculo con radio wanderRadius
        Vector2 randomDirection = Random.insideUnitCircle * wanderRadius;
        Vector2 wanderPosition = (Vector2)transform.position + randomDirection;

        // Establecer la velocidad del agente
        agent.speed = speed;

        // Mover el agente hacia la posición deambulatoria
        agent.SetDestination(wanderPosition);
    }
    public void Escape(NavMeshAgent agent, Vector2 dangerPosition, float speed)
    {
        Vector2 directionAway = (Vector2)transform.position - dangerPosition;
        Vector2 escapePosition = (Vector2)transform.position + directionAway.normalized * retreatDistance;

        // Set the agent's destination to the calculated escape position
        agent.speed = speed;
        agent.SetDestination(escapePosition);
    }
    public void Build(Vector2 buildingPos)
    {

    }
    public void Attack()
    {

    }
    public void DistanceAttack()
    {

    }
    public void Infect()
    {

    }
}
