using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorTrigger : MonoBehaviour
{

    // count until furnace is filled X times - then trigger trapdoor audio/shake
    //or count silently the whole game, reacting at X seconds?

    public FurnaceScript furnaceScript;
    public GeneratorScript generatorScript;
    public Animator _trapdoorAnim;
    public AudioSource _trapdoorAudio;

    bool triggered = false;

    private void Start()
    {

    }

    private void Update()
    {

        if (!triggered && furnaceScript.furnaceRefilled >= 3)
        {
            triggered = true;
            _trapdoorAudio.PlayOneShot(_trapdoorAudio.clip);
            _trapdoorAnim.SetTrigger("trapdoor_shake");

        }

        //if (furnaceScript.furnaceRefilled >= 5)
        //{
        //    _trapdoorAudio.Play();
        //    _trapdoorAnim.SetTrigger("trapdoor_shake");

        //}

        //if (generatorScript.generatorFilled >= 4)
        //{
        //    _trapdoorAudio.Play();
        //    _trapdoorAnim.SetTrigger("trapdoor_shake");

        //}

    }



}
