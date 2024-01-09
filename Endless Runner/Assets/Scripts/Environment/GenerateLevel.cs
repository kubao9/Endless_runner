// This Script is for infinite generation

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public GameObject starterSection;
    public int zPos = 0;
    public bool creatingSection = false;
    public int secNum;


    private void Start()
    {
        Instantiate(starterSection, new Vector3(0,0, zPos), Quaternion.identity);
        zPos += 96;
    }
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 96;
        yield return new WaitForSeconds(6);
        creatingSection = false;
    }
}