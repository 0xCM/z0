//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Part;


    public static partial class XTend
    {

    }

    [ApiHost("api")]
    public readonly partial struct sys
    {
        const NumericKind Closure = Integers;

        const string EmptyString = "";

        const MethodImplOptions Options = MethodImplOptions.AggressiveInlining;                    
    }

    [ApiHost("xsys")]
    readonly partial struct xsys
    {

        const NumericKind Closure = Integers;

        const string EmptyString = "";

        const MethodImplOptions Options = MethodImplOptions.NoInlining;                    
                        
    }
}