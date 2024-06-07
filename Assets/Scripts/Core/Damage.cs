using UnityEngine;

public class damage : MonoBehaviour
{
    [SerializeField] private float damagePlayer;
    private int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damagePlayer);
        }
        else
        {
            score++;
        }
    }
}