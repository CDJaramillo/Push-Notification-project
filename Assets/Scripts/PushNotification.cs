using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushNotification : MonoBehaviour 
{
 
void Start () 
{
    // Enable line below to enable logging if you are having issues setting up OneSignal. (logLevel, visualLogLevel)
    // OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.INFO, OneSignal.LOG_LEVEL.INFO);
  
  OneSignal.StartInit("e2fd4c6c-3911-4b0a-a823-4177a1a87436")
    .HandleNotificationOpened(HandleNotificationOpened)
    .EndInit();
  
  OneSignal.inFocusDisplayType = OneSignal.OSInFocusDisplayOption.Notification;
}

// Gets called when the player opens the notification.
private static void HandleNotificationOpened(OSNotificationOpenedResult result) 
{

}

}