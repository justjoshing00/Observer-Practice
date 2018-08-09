using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObserverPattern
{
    //Events
    public abstract class BoxEvents
    {
        public abstract string GetJumpForce();
    }


    public class JumpLittle : BoxEvents
    {
        public override string GetJumpForce()
        {

            return "alex";
        }
    }


    public class JumpMedium : BoxEvents
    {
        public override string GetJumpForce()
        {
            return "josh";
        }
    }


    public class JumpHigh : BoxEvents
    {
        public override string GetJumpForce()
        {
            return "name";
        }
    }
}