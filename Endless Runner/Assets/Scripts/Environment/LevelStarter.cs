using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDownText1;
    public GameObject countDownText2;
    public GameObject countDownText3;
    public GameObject countDownTextGo;
    public GameObject fadeStart;
    public AudioSource countingSound;
    public AudioSource goSound;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(2);
        countDownText3.SetActive(true);
        countingSound.Play();
        yield return new WaitForSeconds(1);
        countDownText2.SetActive(true);
        countingSound.Play();
        yield return new WaitForSeconds(1);
        countDownText1.SetActive(true);
        countingSound.Play();
        yield return new WaitForSeconds(1);
        countDownTextGo.SetActive(true);
        goSound.Play();
        PlayerMove.canMove = true;
    }
}
