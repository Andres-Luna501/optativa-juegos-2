
using UnityEngine;

public class Pared : MonoBehaviour
{
    private Animator animator;
    private bool destruida = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!destruida && collision.CompareTag("Player"))
        {
            destruida = true;

            animator.SetTrigger("romper");

            Destroy(gameObject, 1f);
        }
    }
}