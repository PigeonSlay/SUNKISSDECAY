using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static int EnHealth = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
