using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timer = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer)
        {
            Debug.Log("Cae en tu cabeza!!");
        }
        
    }
}
