using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCounter : MonoBehaviour
{
    public static bool questSolved = false;

    void Update()
    {
        questSolved=true;
    }

    public static bool isQuestSolved()
    {
        return questSolved;
    }
}
