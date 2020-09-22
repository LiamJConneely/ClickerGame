using System.Collections;
using System.Collections.Generic;
using Fungus.TMProLinkAnimEffects;
using UnityEngine;
using UnityEngine.UI;

public class turnMusicOff : MonoBehaviour
{

    public AudioSource music;

    public Toggle mute;
    // Start is called before the first frame update
    void Start()
    {
        music.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (mute.isOn)
        {
            music.volume = 0;

        }
        else
        {

            music.volume = 1;
        }
    }
}
