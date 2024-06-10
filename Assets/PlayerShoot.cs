using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Bullet BulletPrefab;
    public int RateOfFire = 5;
    private ObjectPool BulletPool;

    private void Awake()
    {
        BulletPool = ObjectPool.CreateObjectPool(BulletPrefab, 100);
    }

    private void Start()
    {
        StartCoroutine(Fire());
    }

    private IEnumerator Fire()
    {
        WaitForSeconds Wait = new WaitForSeconds(1f / RateOfFire);

        while(true)
        {
            PoolableObject instance = BulletPool.GetObject();

            if (instance != null)
            {
                instance.transform.SetParent(transform, false);
                instance.transform.localPosition = Vector2.zero;
                instance.gameObject.SetActive(true);
            }

            yield return Wait;
        }
    }
}