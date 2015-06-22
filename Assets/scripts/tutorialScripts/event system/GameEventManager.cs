//////////////////////////////////////////////////////////////////////////////
// GameEventManager.cs
//////////////////////////////////////////////////////////////////////////////
// Stores a list of listeners and notifies them when an event is dispatched.
//////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GameEvents
{

   public class GameEventManager
   {
   
      static List<WeakReference> listeners = new List<WeakReference>();
      
      public static void registerListener(GameEventListener el)
      {      
         listeners.Add(new WeakReference(el));
      }
      
      public static void post(GameEvent e)
      {
         //Filter out the dead weak references
         var alive_list = (from el in listeners
                           where el.IsAlive
                           select el);
         
         //store the alive references
         listeners = alive_list.ToList();
         
         //iterate through alive references         
         foreach(WeakReference wref in alive_list)
         {           
            //call eventReceived on the listener
            (wref.Target as GameEventListener).eventReceived(e);
         }         
      }
      
      public static void unregisterListener(GameEventListener el)
      {
         listeners.RemoveAll(x => x.Target == el);
      }
      
   }
}