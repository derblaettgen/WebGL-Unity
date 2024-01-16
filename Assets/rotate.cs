using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(-1, 1, 0.5f) * 50 * Time.deltaTime;
        transform.Rotate(rot);
    }
}
