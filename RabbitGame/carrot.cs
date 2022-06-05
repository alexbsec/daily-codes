using UnityEngine;

public class carrot : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private float timeToGrowBackAgain = 5f;
    private float timer = 0f;
    private Sprite carrotSprite;

    private float calories = 0.2f;


    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        carrotSprite = spriteRenderer.sprite;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "rabbit" && spriteRenderer.sprite != null)
        {
            spriteRenderer.sprite = null;
            other.SendMessage("eat", calories);
        }
    }

    private void Update()
    {
        bool isDead = spriteRenderer.sprite == null;

        if (isDead)
        {
            timer += Time.deltaTime;

            if (timer >= timeToGrowBackAgain)
            {
                spriteRenderer.sprite = carrotSprite;
            }

        }

        else
        {
            timer = 0f;
        }
    }

}
