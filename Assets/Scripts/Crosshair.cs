using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public float smoothTime = 0.1f;
    private Vector2 velocity = Vector2.zero;

    private SpriteRenderer spriteRenderer;
    private UnityEngine.UI.Image imageRenderer;

    public Color normalColor = Color.white;
    public Color pressedColor = Color.blue;

    

    void Start()
    {
        Cursor.visible = false;

        spriteRenderer = GetComponent<SpriteRenderer>();


        imageRenderer = GetComponent<UnityEngine.UI.Image>();


        SetColor(normalColor);
    }

    void Update()
    {
        // Obtener la pos
        Vector2 mousePosition = Input.mousePosition;

        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref velocity, smoothTime);


        if (Input.GetMouseButton(0))
        {
            SetColor(pressedColor);
        }
        else
        {
            SetColor(normalColor);
        }
    }

    void SetColor(Color color)
    {

        if (spriteRenderer != null)
        {
            spriteRenderer.color = color;
        }
        else if (imageRenderer != null)
        {
            imageRenderer.color = color;
        }
    }
}
