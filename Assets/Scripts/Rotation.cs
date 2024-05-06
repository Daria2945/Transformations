using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float _speed;

    void Update()
    {
        transform.RotateAround(transform.position, transform.up, _speed *  Time.deltaTime);
    }
}