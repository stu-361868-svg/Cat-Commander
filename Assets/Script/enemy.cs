using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public float moveSpeed;
    public Transform player;
    public NavMeshAgent agent;
    public GameObject UI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.updateRotation = false;

        agent.updateUpAxis = false;

        player = GameObject.FindGameObjectWithTag("Player").transform;
        UI = GameObject.FindGameObjectWithTag("UI");
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(player != null)
        //  {
        // Vector2 direction = (player.position - transform.position).normalized;
        // transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        // ;
        // }
        agent.SetDestination(player.position);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            UI.GetComponent<ScoreSystem>().AddScore();
            Destroy(gameObject);
        }
    }
}
