using System.Collections;
using UnityEngine;

public class PetFollow : MonoBehaviour
{
    [Header("跟隨速度"),Range(1f,15f)]
    public float speed = 7.5f;

    private Transform followPoint;

    private void Start()
    {
        followPoint = GameObject.Find("跟隨點").transform;
    }

    private void LateUpdate()
    {
        if (Vector3.Distance(transform.position, followPoint.position) >= 3)
        {
            PetTrack();
        }
    }

    private void PetTrack()
    {
        Vector3 posFollow = followPoint.position;
        Vector3 posDragon = transform.position;

        transform.position = Vector3.Lerp(posDragon, posFollow, 0.5f * Time.deltaTime * speed);
        transform.LookAt(posFollow);
    }
}
