using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadAbility : Ability
{
    public BadAbility()
    {
        Name = "MISSING";
    }

    public override IEnumerator UseAbility(AbilityData data)
    {
        Debug.Log("Tried to use Bad Ability.");
        yield break;
    }
    protected override void CalcSpecificScore(BattleChar user, BattleChar target)
    {
        //Score remains at 0
    }

    public override bool IsUsable(BattleChar battleChar)
    {
        return false;
    }
}