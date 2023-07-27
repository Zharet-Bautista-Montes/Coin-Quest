using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    public static void resetScene()
    {
        lifeManager.lifes = 4;
        lifeManager.endSignal = false;
    }
}
