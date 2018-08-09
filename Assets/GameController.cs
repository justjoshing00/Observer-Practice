using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is a test



namespace ObserverPattern
{
    public class GameController : MonoBehaviour
    {
        public GameObject sphereObj;
        // the boxes to be moved
        public GameObject box1obj;
        public GameObject box2obj;
        public GameObject box3obj;

        Subject subject = new Subject();

        // Use this for initialization
        void Start()
        {
            Box box1 = new Box(box1obj, new JumpLittle());
            Box box2 = new Box(box1obj, new JumpMedium());
            Box box3 = new Box(box1obj, new JumpHigh());

            subject.AddObserver(box1);
            subject.AddObserver(box2);
            subject.AddObserver(box3);
        }

        // Update is called once per frame
        void Update()
        {
            if ((sphereObj.transform.position).magnitude < 0.5f)
            {
                subject.Notify();
            }
        }
    }
}