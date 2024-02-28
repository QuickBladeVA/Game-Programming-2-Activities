using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falinks: Pokemon
{
    private void Start()
    {
        name = "Falinks";
        lvl = 20;
        hp = 19;
        atk = 10;
        type = Types.Fighting;
        gender = Gender.Genderless;
    }
}
