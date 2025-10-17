using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float rayDistance;
    [SerializeField] private LayerMask obstacleLayer;
    private Transform rayOrigin;

    private MoveBehaviour _mb;
    private bool movingRight = true;

    private void Awake()
    {
        _mb = GetComponent<MoveBehaviour>();
    }

    void Update()
    {
        //Dirección de movimiento
        Vector2 direction = movingRight ? Vector2.right : Vector2.left;

        //Mover usando MoveBehaviour
        _mb.MoveCharacter(direction);

        //Raycast para detectar obstáculos
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin.position, direction, rayDistance, obstacleLayer);

        if (hit.collider != null)
        {
            //Cambiar de dirección si choca con algo
            movingRight = !movingRight;
        }
        //Visualización del raycast
        Debug.DrawRay(rayOrigin.position, direction * rayDistance, Color.red);
    }
}
