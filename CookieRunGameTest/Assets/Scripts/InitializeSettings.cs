using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSettings : MonoBehaviour
{
    [SerializeField] private GameObject[] objects;
    private void Awake()
    {   
            for (int i = 0; i < objects.Length; i++)
            {
                DontDestroyOnLoad(objects[i]);
            }
    }
}
