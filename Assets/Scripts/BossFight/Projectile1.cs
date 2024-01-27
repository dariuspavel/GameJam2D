using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
  

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(DestroyAfterDelay());
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            coll.GetComponent<PlayerTakeDamage>().TakeDamage(5);
            // Debug.Log("ShouldDestroy");

            Destroy(gameObject);
        }
    }


    private IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(7f);
        Destroy(gameObject);
    }

}
