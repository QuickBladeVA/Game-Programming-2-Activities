using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Pokemon")]
public class Charizard : Pokemon
{
    private void Start()
    {
        name = "Charizard";
        lvl = 30;
        hp = 40;
        atk = 20;
        type = Types.Fire;
        gender = Gender.Male;
    }
}
