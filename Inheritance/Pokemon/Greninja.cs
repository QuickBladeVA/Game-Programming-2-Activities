using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greninja: Pokemon
{
    private void Start()
    {
        name = "Greninja";
        lvl = 32;
        hp = 22;
        atk = 30;
        type = Types.Water;
        gender = Gender.Male;
    }
}
