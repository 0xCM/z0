//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Part;


    [ApiHost("x")]
    public static partial class XTend
    {

    }

    [ApiHost("api")]
    public readonly partial struct sys
    {
        const NumericKind Closure = Integers;

        const string EmptyString = "";

        const MethodImplOptions NotInline = MethodImplOptions.NoInlining;                    

        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;                    
    }
}