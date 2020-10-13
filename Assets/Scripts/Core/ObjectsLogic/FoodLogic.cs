using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodLogic : EmptyLogic
{
    public override void TouchAction(GameObject obj)
    {
        ScoreManager.Score += 1;
        base.TouchAction(obj);
    }
}
