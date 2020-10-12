using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLogic : EmptyLogic
{
    public override void TouchAction(GameObject obj)
    {
        SceneReloader.ReloadScene();
        base.TouchAction(obj);
    }    
}
