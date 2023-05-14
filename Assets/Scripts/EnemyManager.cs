using UnityEngine;

public class EnemyManager : MonoBehaviour
{
	[SerializeField] private int maxHealth = 2;
    [SerializeField] private GameObject spriteMask;
    [SerializeField] private float[] alphaCutoffValues;
	private int currentHealth;
    private int arrayLength;
    void Start()
    {
        currentHealth = maxHealth;
        arrayLength = alphaCutoffValues.Length - 1;
        spriteMask.GetComponent<SpriteMask>().enabled = false;
    }
    

    public void TakeDamage(int damage)
    {
        spriteMask.GetComponent<SpriteMask>().enabled = true;
        currentHealth -= damage;
        EraseEnemy();
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void EraseEnemy()
    {
        spriteMask.GetComponent<SpriteMask>().alphaCutoff = alphaCutoffValues[arrayLength--];
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
