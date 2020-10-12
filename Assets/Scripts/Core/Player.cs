using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ITouchable obj = collision.gameObject.GetComponent<ITouchable>();
        if(obj != null)
        {
            obj.TouchAction(this.gameObject);
        }
    }
}
