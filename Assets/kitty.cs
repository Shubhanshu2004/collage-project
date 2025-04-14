 using UnityEngine;

public class Kitty : MonoBehaviour
{
    public Animator Anim { get; private set; }
    public float speed = 5f;

    private float translation;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        Anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        translation = Input.GetAxis("Horizontal");

        // Move the kitty
        transform.Translate(Vector3.right * translation * speed * Time.deltaTime);

        // Set animation speed parameter
        Anim.SetFloat("speed", Mathf.Abs(translation));

        // Flip the sprite based on direction
        TurnPlayer();
    }

    void TurnPlayer()
    {
        if (translation != 0)
        {
            spriteRenderer.flipX = translation < 0;
        }
    }
}