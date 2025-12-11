using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed, lifeTime;
    public Rigidbody theRigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRigidbody.linearVelocity = transform.forward * bulletSpeed;

        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
