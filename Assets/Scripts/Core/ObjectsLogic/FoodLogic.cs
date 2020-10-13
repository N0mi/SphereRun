using UnityEngine;
using Conf;

public class FoodLogic : EmptyLogic
{
    public override void TouchAction(GameObject obj)
    {
        ScoreManager.Score += Settings.deltaScore;
        base.TouchAction(obj);
    }
}
