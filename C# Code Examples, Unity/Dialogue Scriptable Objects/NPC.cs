﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New NPC", menuName = "NPC")]
public class NPC : ScriptableObject
{
    public string npcName;
    public Color npcNameColor;
    public Sprite npcSprite;
}
