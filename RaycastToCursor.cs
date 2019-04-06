using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RaycastToCursor
{
    public static GameObject CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
         
        if(Physics.Raycast(ray, out hit, 200))
        {
            return hit.transform.gameObject;
        }
        else
        {
            return null;
        }
    }
}
