//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;

public class SymbolSourceAttribute : Attribute
{

    public SymbolSourceAttribute()
    {
        Category = "";
    }

    public SymbolSourceAttribute(string category)
    {
        Category = category;
    }

    public string Category {get;}
}