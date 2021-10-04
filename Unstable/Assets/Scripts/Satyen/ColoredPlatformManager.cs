using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredPlatformManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool greenUp;
    public bool blueUp;
    public bool redUp;
    public bool yellowUp;
    public bool purpleUp;

    public GameObject GreenUp;
    public GameObject BlueDown;
    public GameObject RedUp;
    public GameObject RedDown;
    public GameObject YellowDown;
    public GameObject PurpleDown;
    public GameObject GreenDown;
    public GameObject BlueUp;

    private Vector3 greenUpPos;
    private Vector3 blueDownPos;
    private Vector3 redUpPos;
    private Vector3 redDownPos;
    private Vector3 yellowDownPos;
    private Vector3 purpleDownPos;
    private Vector3 greenDownPos;
    private Vector3 blueUpPos;

    public float movementSpeed;
    public float upperHeight;
    public float lowerHeight;

    private float movementGreen;
    private float movementBlue;
    private float movementRed;
    private float movementYellow;
    private float movementPurple;

    void Start()
    {
        purpleUp = false;
        greenUp = false;
        yellowUp = false;
        redUp = false;
        blueUp = false;

        greenUpPos = GreenUp.transform.position;
        blueDownPos = BlueDown.transform.position;
        redUpPos = RedUp.transform.position;
        redDownPos = RedDown.transform.position;
        yellowDownPos = YellowDown.transform.position;
        purpleDownPos = PurpleDown.transform.position;
        greenDownPos = GreenDown.transform.position;
        blueUpPos = BlueUp.transform.position;

        movementGreen = 1f;
        movementBlue = 1f;
        movementPurple = 1f;
        movementRed = 1f;
        movementYellow = 1f;
    }


    // Update is called once per frame
    void Update()
    {
        if (greenUp)
        {
            GreenUp.transform.position = new Vector3(0, movementSpeed * movementGreen *-1, 0) + greenUpPos;
            GreenDown.transform.position = new Vector3(0, movementSpeed * movementGreen, 0) + greenDownPos;
            greenUpPos = GreenUp.transform.position;
            greenDownPos = GreenDown.transform.position;
        }
        if ((GreenUp.transform.position.y < lowerHeight ||
            GreenUp.transform.position.y > upperHeight) && greenUp)
        {
            greenUp = false;
            movementGreen *= -1;
        }

        if (blueUp)
        {
            BlueUp.transform.position = new Vector3(0, movementSpeed * movementBlue * -1, 0) + blueUpPos;
            BlueDown.transform.position = new Vector3(0, movementSpeed * movementBlue, 0) + blueDownPos;
            blueUpPos = BlueUp.transform.position;
            blueDownPos = BlueDown.transform.position;
        }
        if ((BlueUp.transform.position.y < lowerHeight ||
            BlueUp.transform.position.y > upperHeight) && blueUp)
        {
            blueUp = false;
            movementBlue *= -1;
        }

        if (redUp)
        {
            RedUp.transform.position = new Vector3(0, movementSpeed * movementRed * -1, 0) + redUpPos;
            RedDown.transform.position = new Vector3(0, movementSpeed * movementRed, 0) + redDownPos;
            redUpPos = RedUp.transform.position;
            redDownPos = RedDown.transform.position;
        }
        if ((RedUp.transform.position.y < lowerHeight ||
            RedUp.transform.position.y > upperHeight) && redUp)
        {
            redUp = false;
            movementRed *= -1;
        }

        if (yellowUp)
        {
            YellowDown.transform.position = new Vector3(0, movementSpeed * movementYellow, 0) + yellowDownPos;
            yellowDownPos = YellowDown.transform.position;
        }
        if ((YellowDown.transform.position.y < lowerHeight ||
            YellowDown.transform.position.y > upperHeight) && yellowUp)
        {
            yellowUp = false;
            movementYellow *= -1;
        }

        if (purpleUp)
        {
            PurpleDown.transform.position = new Vector3(0, movementSpeed * movementPurple, 0) + purpleDownPos;
            purpleDownPos = PurpleDown.transform.position;
        }
        if ((PurpleDown.transform.position.y < lowerHeight ||
            PurpleDown.transform.position.y > upperHeight) && purpleUp)
        {
            purpleUp = false;
            movementPurple *= -1;
        }

    }
}
