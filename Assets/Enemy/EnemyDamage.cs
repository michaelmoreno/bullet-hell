using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject playerSword;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // playerSword.SetActive(true);
            // Destroy(gameObject);
            Debug.Log("Enemy hit by sword");
        }
    }
}
