using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{ 

public abstract class Observer
    {

        public abstract void OnNotify();
    }

public class Box : Observer
    {
        GameObject boxObj;

        BoxEvents boxEvent;

        public Box(GameObject boxobj, BoxEvents boxEvent)
        {
            this.boxObj = boxobj;
            this.boxEvent = boxEvent;
        }
        //What the box will do if the event fits it (will always fit but you will probably change that on your own)
        public override void OnNotify()
        {
            Jump(boxEvent.GetJumpForce());
        }
        //The box will always jump in this case
        void Jump(string jumpforce)
        {
            //If the box is close to the ground
            if (boxObj.transform.position.y < 0.55f)
            {
                Debug.Log(jumpforce);
                //boxObj.GetComponent().AddForce(Vector3.up * jumpForce);
            }
        }
    }
}
