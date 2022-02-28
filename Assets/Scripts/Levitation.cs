using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitation : MonoBehaviour
{
    float elapsedTime;
    [SerializeField] float rotationSpeed = 1.0f;
    [SerializeField] float yOffset = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float sinePos = Mathf.Sin(elapsedTime);

        transform.localPosition += Vector3.up * sinePos  * yOffset * Time.deltaTime;

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
