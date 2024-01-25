using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    public float targetScale = 2f;
    public float duration = 1f;

    void Start()
    {
        StartCoroutine(ScaleOverTime());
    }

    private IEnumerator ScaleOverTime()
    {
        Vector3 originalScale = transform.localScale;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            // Interpolate between the original scale and the target scale
            transform.localScale = Vector3.Lerp(originalScale, new Vector3(targetScale, targetScale, 1), elapsedTime / duration);

            // Increment the elapsed time
            elapsedTime += Time.deltaTime;

            // Wait for the next frame
            yield return null;
        }

        // Ensure the final scale is exactly the target scale
        transform.localScale = new Vector3(targetScale, targetScale, 1);

        Destroy(gameObject);
    }
}
