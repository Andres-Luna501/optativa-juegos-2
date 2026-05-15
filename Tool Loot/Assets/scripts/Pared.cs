using UnityEngine;

public class Pared : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;

    private Animator animator;
    private bool destruida = false;

    public float speed = 3f;
    public float limitY = -6f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!destruida)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (transform.position.y < limitY && !destruida)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!destruida && collision.gameObject.CompareTag("Player"))
        {
            destruida = true;
            GetComponent<Collider2D>().enabled = false;
            speed = 0f;

            animator.SetTrigger("romper");

            Puntaje.instancia.SumarPuntos(cantidadPuntos);

            Destroy(gameObject, 1f);
        }
    }
}