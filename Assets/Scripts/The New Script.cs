using UnityEngine;

public class TheNewScript
{
    void start()
    {
        Debug.Log("call the update");
        update();
    }

    void update() {
        Debug.Log("call the start");
        start(); }


}
