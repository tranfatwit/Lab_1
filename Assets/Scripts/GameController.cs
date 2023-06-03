using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour

{
    public static int score = 0;
    public static int npcScore = 0;

    void OnGUI()
    {
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 24;
        scoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 200, 50), "Score: " + score, scoreStyle);
        GUI.Label(new Rect(10, 40, 200, 50), "NPC Score: " + npcScore, scoreStyle);
    }
    public void OnCubeGrabbed()
    {
        // Minus from NPC score when NPC collides with a cube
        npcScore--;
        // Destroy the cube
        Destroy(gameObject);

    }
}
