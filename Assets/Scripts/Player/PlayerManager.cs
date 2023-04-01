using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public FirstPersonController fpsc;
    public void Playermoving()
    {
        fpsc.CanMoving();
    }

    public void PickUpRight()
    {
        fpsc.PickUpObjRight();
    }
    public void PickUpLeft()
    {
        fpsc.PickUpObjLeft();
    }
}
