using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    private List<int> _numbers;
    private int _multiplier = 1;

    private void Awake()
    {
        ListAdder();
        DisplayNumbers();
    }

    private void ListAdder()
    {
        _numbers = new List<int>();

        for (int i = 0; i < 10; i++)
            _numbers.Add(i * _multiplier);
    }

    private void DisplayNumbers()
    {
        for (int i = 0; i < 10; i++)
            Debug.Log(_numbers[i]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
            _multiplier++;
            ListAdder();
            DisplayNumbers();
        }
    }
}
