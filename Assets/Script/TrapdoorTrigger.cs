using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorTrigger : MonoBehaviour
{

    // count until furnace is filled X times - then trigger trapdoor audio/shake
    //or count silently the whole game, reacting at X seconds?

    public Animator _trapdoorAnim;
    public AudioSource _trapdoorAudio;

    private void Start()
    {
        StartCoroutine(WaitThenKnock());

    }

    private void Update()
    {



    }

    public IEnumerator WaitThenKnock()
    {
        yield return new WaitForSeconds(5);
        _trapdoorAudio.Play();
        _trapdoorAnim.SetTrigger("trapdoor_shake");

    }

}
