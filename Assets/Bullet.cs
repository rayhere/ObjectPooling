using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : AutoDestroyPoolableObject
{
    public Rigidbody2D RigidBody;
    public Vector2 Speed = new Vector2(20, -1);


    private void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
    }


    public override void OnEnable()
    {
        base.OnEnable();


        RigidBody.velocity = Speed;
    }


    public override void OnDisable()
    {
        base.OnDisable();


        RigidBody.velocity = Vector2.zero;
    }
}
