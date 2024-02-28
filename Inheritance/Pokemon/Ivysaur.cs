using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ivysaur : Pokemon
{
    private void Start()
    {
        name = "Ivysaur";
        lvl = 22;
        hp = 35;
        atk = 12;
        type = Types.Grass;
        gender = Gender.Female;
    }
}
