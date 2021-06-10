//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;

public class SymbolSourceAttribute : Attribute
{
    public SymbolSourceAttribute()
    {
        Description = "";
    }

    public SymbolSourceAttribute(string description)
    {
        Description = description;
    }

    public string Description {get;}
}