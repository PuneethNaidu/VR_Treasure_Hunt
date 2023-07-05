using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void _Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
