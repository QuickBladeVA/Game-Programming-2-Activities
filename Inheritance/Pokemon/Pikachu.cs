using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : Pokemon
{
    private void Start()
    {
        name = "Pikachu";
        lvl = 10;
        hp = 25;
        atk = 12;
        type = Types.Electric;
        gender = Gender.Male;
    }
}
