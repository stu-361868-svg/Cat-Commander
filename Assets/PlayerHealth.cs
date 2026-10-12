using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;
    public float maxHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth < 0)
        {
            playerHealth = 0;
        }

       
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Enemy")
    //    {
    //        playerHealth--;
    //        Debug.Log(playerHealth);
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerHealth--;
            Debug.Log(playerHealth);
            Destroy(collision.gameObject);

            if (playerHealth <= 0)
            {
                //death function
                gameObject.SetActive(false);
                GoToGameOver();
            }
        }
    }
    public void GoToGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
