using System.Collections;
using UnityEngine;

public class PetFollow : MonoBehaviour
{
    [Header("跟隨速度")]
    public float speed = 7.5f;

    private void LateUpdate()
    {
        PetTrack();
    }

    private void PetTrack()
    {
        Vector3 posPlayer = GameObject.Find("野蠻人").GetComponent<Transform>().position;

        if (Vector3.Distance(posPlayer,transform.position) > 5)
        {
            transform.position = posPlayer;
        }
    }
}
