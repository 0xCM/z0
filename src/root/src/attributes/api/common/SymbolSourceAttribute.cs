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
        Description = "";
    }

    public SymbolSourceAttribute(string category)
    {
        Category = category;
        Description = "";
    }

    public SymbolSourceAttribute(string category, string description)
    {
        Category = category;
        Description = description;
    }

    public string Category {get;}

    public string Description {get;}
}