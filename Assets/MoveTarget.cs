using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public float speed = 3.0f;
    public float range = 5.0f;
    public float height = 2.0f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position + new Vector3(0, height, 0);
    }

    void Update()
    {
        transform.position = startPosition + new Vector3(Mathf.PingPong(Time.time * speed, range), 0, 0);
    }
}