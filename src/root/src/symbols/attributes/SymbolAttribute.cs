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

    public SymbolAttribute(string symbol)
    {
        _Symbol = symbol;
        Description = string.Empty;
    }

    public SymbolAttribute(string symbol, string description)
    {
        _Symbol = symbol;
        Description = description;
    }

    public SymbolAttribute(char symbol)
    {
        _Symbol = symbol;
        Description = string.Empty;
    }

    public SymbolAttribute(char symbol, string description)
    {
        _Symbol = symbol;
        Description = description;
    }

    public SymbolAttribute(object symbol)
    {
        _Symbol = symbol;
        Description = string.Empty;
    }

    public SymbolAttribute(object symbol, string description)
    {
        _Symbol = symbol;
        Description = description;
    }
}