using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour
{
    private void Update()
    {
        transform.LookAt(Vector3.zero);
    }
}
