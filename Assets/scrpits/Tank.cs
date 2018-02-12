using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tank : MonoBehaviour {

    [SerializeField]
    private Transform goal;
    private NavMeshAgent agent;
    [SerializeField]
    private float speedBppstDuration = 3;
    [SerializeField]
    private ParticleSystem boostParticleSystem;
    [SerializeField]
    private float shieldDeuration = 3f;
    [SerializeField]
    private GameObject shield;

    private float regularSpeed = 3.5f;
    private float boostedSpeed = 7.0f;
    private bool canBoost = true;
    private bool canShield = true;

    private bool gasShield = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.position);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (canBoost)
            {
                StartCoroutine(Boost());
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (canShield)
            {
                StartCoroutine(Shield());
            }
        }

    }

    private IEnumerator Shield()
    {
        canShield = false;
        shield.SetActive(true);
        float shieldCounter = 0f;
        while (shieldCounter < shieldDeuration)
        {
            shieldCounter += Time.deltaTime;
            yield return null;
        }
        canShield = true;
        shield.SetActive(false);
    }

    private IEnumerator Boost()
    {
        canBoost = false;
        agent.speed = boostedSpeed;
        boostParticleSystem.Play();
        float boostCounter = 0f;
        while (boostCounter < speedBppstDuration)
        {
            boostCounter += Time.deltaTime;
            yield return null;
        }
        canBoost = true;
        boostParticleSystem.Pause();
        agent.speed = regularSpeed;
    }

}
