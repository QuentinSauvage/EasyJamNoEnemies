﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Salable : Item
{
    [SerializeField] protected float price;

    public override bool IsSalable { get { return true; } }
}
