using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eevee : Pokemon
{
    private void Start()
    {
        name = "Eevee";
        lvl = 10;
        hp = 25;
        atk = 12;
        type = Types.Normal;
        gender = Gender.Female;
    }
}
