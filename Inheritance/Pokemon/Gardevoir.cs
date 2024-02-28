using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gardevoir: Pokemon
{
    private void Start()
    {
        name = "Gardevoir";
        lvl = 30;
        hp = 38;
        atk = 28;
        type = Types.Psychic;
        gender = Gender.Female;
    }
}
