//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [Flags]
    public enum MethodSemanticsAttributes
    {
        Setter = 1,
        
        Getter = 2,
        
        Other = 4,
        
        Adder = 8,
        
        Remover = 16,
        
        Raiser = 32,
    }
}