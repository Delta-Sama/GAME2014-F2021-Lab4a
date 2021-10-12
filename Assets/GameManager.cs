using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rect screen;
    public Rect safeArea;

    public Rect backButtonRect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        screen = new Rect(0,0,Screen.width, Screen.height);
        safeArea = Screen.safeArea;

        CheckOrientation();
    }

    private void CheckOrientation()
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.LandscapeLeft:
                {

                    break;
                }
            case ScreenOrientation.LandscapeRight:
                {

                    break;
                }
            case ScreenOrientation.Portrait:
                {

                    break;
                }
        }
    }
}
