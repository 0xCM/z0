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
    public readonly partial struct As
    {
        const NumericKind Closure = NumericKind.All;    

        [MethodImpl(Inline)]   
        internal static T[] alloc<T>(int length)
            => new T[length];
    }


    [ApiHost]
    public readonly partial struct AsInternal
    {
        const NumericKind Closure = NumericKind.All;    

    }
}