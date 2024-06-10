using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletNotPooled : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D RigidBody;
    public float DestroyTime = 1f;
    public Vector2 Speed = new Vector2(200, 0);

    private const string DestroyMethodName = "Destroy";

    private void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
    }

    public void OnEnable()
    {
        RigidBody.velocity = Speed;
        Invoke(DestroyMethodName, DestroyTime);
    }

    public void Destroy()
    {
        GameObject.Destroy(this.gameObject);
    }
}