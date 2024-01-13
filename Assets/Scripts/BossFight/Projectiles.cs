using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{

    private int Damage = 10;
    private float speed = 5;
    public float clampY = -2f;

    private bool isFalling = true;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFalling)
        {
            Fall();
        }
    }

    private void Fall()  // Move the projectile down and destroy at clam position
    {
        Vector2 currentPosition = transform.position;

        currentPosition.y = Mathf.Clamp(currentPosition.y - speed * Time.deltaTime, -Mathf.Infinity, clampY);

        rb.MovePosition(currentPosition);

        if (currentPosition.y <= clampY)
        {
            rb.isKinematic = false;
            isFalling = false;

            StartCoroutine(DestroyAfterDelay(0.5f));
        }
    }

   
  /*  public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            coll.GetComponent<Player>().Health -= Damage;

            Destroy(gameObject);
        }
    }
  */

    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

}
