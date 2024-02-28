using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ditto: Pokemon
{
    private void Start()
    {
        name = "Ditto";
        lvl = 1;
        hp = 1;
        atk = 1;
        type = Types.Normal;
        gender = Gender.Genderless;
    }
}
