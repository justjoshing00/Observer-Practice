﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{

    public class Subject
    {
        List<Observer> observers = new List<Observer>();

        public void Notify()
        {
            for(int i = 0; i < observers.Count; i++)
                {
                //Notify all observers even though some may not be interested in what has happened
                //Each observer should check if it is interested in this event
                observers[i].OnNotify();
            }
        }
        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver( Observer observer )
        {
           
        }

    }
}
