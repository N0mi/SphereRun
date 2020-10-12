using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyLogic : MonoBehaviour, ITouchable, IPooledObject
{
    public virtual void OnObjectSpawn() { }

    public virtual void TouchAction(GameObject obj)
    {
        gameObject.SetActive(false);
    }
}
