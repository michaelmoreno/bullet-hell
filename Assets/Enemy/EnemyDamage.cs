using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject playerSword;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerSword)
        {
            // Destroy(gameObject);
            Debug.Log("Enemy hit by sword");
        }
    }
}
