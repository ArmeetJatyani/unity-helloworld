using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    public float speed = 7;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacementFromTarget = target.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;

        Vector3 velocity = directionToTarget * speed;

        float distToTarget = displacementFromTarget.magnitude;
        if (distToTarget > 3f)
        {
            transform.Translate(velocity * Time.deltaTime);
        }

    }
}
