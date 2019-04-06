using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSManager : MonoBehaviour
{
    // This isn't the actual framerate, unity still runs around 10-15 FPS more than the target you set
    private int target = 45;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = target;
    }

    void Update()
    {
        if(Application.targetFrameRate != target)
            Application.targetFrameRate = target;
    }
}
