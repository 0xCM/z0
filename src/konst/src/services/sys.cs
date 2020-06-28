//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;


    [ApiHost]
    public readonly partial struct sys
    {
        const NumericKind Closure = Numeric8u | Numeric64u;

        const MethodImplOptions Options = MethodImplOptions.NoInlining;                    
    }
}