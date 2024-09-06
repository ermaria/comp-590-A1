using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepscore : MonoBehaviour
{
    public static int Score = 0;
    public static int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI(){
        GUI.Box(new Rect(50, 100, 100, 50), Score.ToString());
    }
}
