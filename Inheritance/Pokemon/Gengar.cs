using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gengar: Pokemon
{
    private void Start()
    {
        name = "Gengar";
        lvl = 28;
        hp = 32;
        atk = 24;
        type = Types.Ghost;
        gender = Gender.Male;
    }
}
