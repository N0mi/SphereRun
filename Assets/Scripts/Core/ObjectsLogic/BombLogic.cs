using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Conf;

public class BombLogic : EmptyLogic
{
    private void OnEnable()
    {
        StartCoroutine("DeathTimer");
    }

    public override void TouchAction(GameObject obj)
    {
        SceneReloader.ReloadScene();
        base.TouchAction(obj);
    }

    public override void Death()
    {
        StopCoroutine("DeathTimer");
        base.Death();
    }

    IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(Settings.timeToDeath);
        Death();
    }
}
