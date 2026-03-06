using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;

    private Rigidbody2D rb;
    private float moveInput;

    public Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()

    {
        Debug.Log(Input.GetAxis("Horizontal"));
        // Detectar movimiento horizontal
        moveInput = Input.GetAxis("Horizontal");

        // Animación
        animator.SetFloat("movement", Mathf.Abs(moveInput));

        // Girar sprite
        if (moveInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (moveInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);
    }
}