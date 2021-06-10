//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;

public class SymbolAttribute : Attribute
{
    object _Symbol {get;}

    public Type SourceType
        => _Symbol.GetType();

    public string Symbol
        => _Symbol.ToString();

    public string Description {get;}

    public string Expansion {get;}

    public SymbolAttribute(object symbol)
    {
        _Symbol = symbol;
        Description = string.Empty;
        Expansion = string.Empty;
    }

    public SymbolAttribute(object symbol, string description)
    {
        _Symbol = symbol;
        Description = description;
        Expansion = string.Empty;
    }

    public SymbolAttribute(object symbol, string description, string expansion)
    {
        _Symbol = symbol;
        Description = description;
        Expansion = expansion;
    }

    // public SymbolAttribute(object symbol)
    // {
    //     _Symbol = symbol;
    //     Description = string.Empty;
    // }

}