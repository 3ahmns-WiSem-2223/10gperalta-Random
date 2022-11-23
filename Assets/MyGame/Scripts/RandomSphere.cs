
using UnityEngine;

public class RandomSphere : MonoBehaviour
{
    private float randomValue;
    private Vector3 randomUnitSphere;
    private Color sphere;

    void Start()
    {
        randomValue = Random.value;
        randomUnitSphere = Random.insideUnitSphere;
        GetComponent<Renderer>().material.color = sphere = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        Debug.Log(randomValue);
        Debug.Log(randomUnitSphere);
        Debug.Log(sphere);
    }

}
