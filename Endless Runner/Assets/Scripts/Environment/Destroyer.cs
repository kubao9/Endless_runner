using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;
    public bool firstIteration = false;
    public GameObject playerObject;
    void Start()
    {
        parentName = transform.name;
    }

    private void Update()
    {
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(1f);
        if (parentName == "Section(Clone)" || parentName == "StartSection(Clone)" || parentName == "StartSection")
        {
            if ((playerObject.transform.position.z - this.gameObject.transform.position.z) >= 120)
            {
                Destroy(gameObject);
            }
        }
    }
}
