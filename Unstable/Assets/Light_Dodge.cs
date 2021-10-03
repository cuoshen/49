using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Dodge : MonoBehaviour
{
    private float player_hp;
    private float player_score;
    private Spot_Light casted;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        player_hp = 10;
        player_score = 0;
        counter = 60;

    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 600)
        {
            casted = GameObject.Find("SpotLight").GetComponent<Spot_Light>();
            if (casted.player_casted)
                player_hp--;
            counter = 0;
        }
        else
            counter++;
        
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width - 100, Screen.height - 50, 155, 30), "Player HP: " + player_hp);
    }
}
