using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float DestroyTimeout;

    private Tank owner;
    public Tank Owner { set { owner = value; } }

    void Start()
    {
        Destroy(gameObject, DestroyTimeout);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Animal"))
        {
            var animal = collision.gameObject.GetComponent<AnimalHandler>();
            owner.GiveKill();
            animal.Sleep();
            Destroy(gameObject);
        }
    }
}
