using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class textBizzy : MonoBehaviour
{
    public GameObject danielleSpeech;
    void Start()
    {
        danielleSpeech.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D Abby)
    {
        if (Abby.gameObject.tag == "Abby")
        {
            object value = textBizzy.SetActive(true);
            StartCoroutine("destroyTime");
        }
    }

    private static object SetActive(bool v)
    {
        throw new NotImplementedException();
    }

    IEnumerator destroyTime()
    {
        yield return new WaitForSeconds(10);
        Destroy(danielleSpeech);
    }
}

