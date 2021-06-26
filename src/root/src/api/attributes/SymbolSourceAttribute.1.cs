//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;


public class SymbolClassifierAttribute : Attribute
{
    public SymbolClassifierAttribute(Type src)
    {
        Classified = src;
    }

    public Type Classified{get;}
}