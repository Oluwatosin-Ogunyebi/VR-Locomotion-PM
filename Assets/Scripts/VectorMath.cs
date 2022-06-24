using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMath : MonoBehaviour
{
    public Transform targetTransform;
    public float speed;

    public float vectorDistance;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TargetPositionCOroutine(targetTransform));
    }

    // Update is called once per frame
    void Update()
    {
       
        //if (vectorDistance > 0.03f)
        //{
        //    transform.position = Vector3.Lerp(transform.position, targetTransform.position, speed * Time.deltaTime);
        //    Debug.Log("Distance between player and target is: " + vectorDistance);
        //}
    }

    IEnumerator TargetPositionCOroutine(Transform target)
    {
        vectorDistance = Vector3.Distance(transform.position, targetTransform.position);
        while (vectorDistance > 0.03f)
        {
            transform.position = Vector3.Lerp(transform.position, targetTransform.position, speed * Time.deltaTime);
            Debug.Log("Distance between player and target is: " + vectorDistance);

            yield return null;
        }

        Debug.Log("Player Reahced Target Transform");

        yield return new WaitForSeconds(2f);

        Debug.LogWarning("Coroutine has finished");
    }
}
