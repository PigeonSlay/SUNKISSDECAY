using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Transform target;
    public float speed = 2f;

    private void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
