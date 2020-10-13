using UnityEngine;

public abstract class EmptyLogic : MonoBehaviour, ITouchable, IPooledObject
{
    public virtual void OnObjectSpawn() { }

    public virtual void TouchAction(GameObject obj)
    {
        Death();
    }

    public virtual void Death()
    {
        gameObject.SetActive(false);
    }
}
