using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int points = 10;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            gameManager.AddScore(points);
            Destroy(gameObject);
        }
    }
}
