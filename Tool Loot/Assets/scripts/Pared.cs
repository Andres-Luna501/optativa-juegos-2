
using UnityEngine;

public class Pared : MonoBehaviour
{
    private Animator animator;
    private bool destruida = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

   private void OnCollisionEnter2D(Collision2D collision)
{
    if (!destruida && collision.gameObject.CompareTag("Player"))
    {
        destruida = true;

        animator.SetTrigger("romper");

        Destroy(gameObject, 1f);
    }
}
}