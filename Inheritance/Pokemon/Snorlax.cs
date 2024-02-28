using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snorlax: Pokemon
{
    private void Start()
    {
        name = "Snorlax";
        lvl = 30;
        hp = 50;
        type = Types.Normal;
        gender = Gender.Male;
    }
}
