using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    private float distance;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Closest();
    }

    void Closest()
    {
        GameObject[] taggedZombies = GameObject.FindGameObjectsWithTag("zombie");
        float closestDistance = Mathf.Infinity;
        Transform closestzombie = null;

        foreach (GameObject taggedZombie in taggedZombies)
        {
            Vector3 zombiepos = taggedZombie.transform.position;
            distance = (zombiepos - transform.position).sqrMagnitude;

            if(distance < closestDistance)
            {                
                closestDistance = distance;
                closestzombie = taggedZombie.transform;
            }
        }
        target = closestzombie;
        target.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
