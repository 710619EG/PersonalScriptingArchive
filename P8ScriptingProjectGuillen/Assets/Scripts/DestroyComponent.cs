using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponent : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
