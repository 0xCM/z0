//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Part;


    [ApiHost("api")]
    public readonly partial struct sys
    {
        const NumericKind Closure = Integers;

        const string EmptyString = "";

        const MethodImplOptions Options = MethodImplOptions.NoInlining;                    
    }
}