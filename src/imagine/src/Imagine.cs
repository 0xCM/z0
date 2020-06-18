//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    


    using static Konst;

    /// <summary>
    /// Presents the world as one wishes it to be, though usage could be disastrous if reality and expectation diverge
    /// </summary>
    [ApiHost("api")]
    public readonly partial struct Imagine
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]   
        internal static T[] alloc<T>(int length)
            => new T[length];

    }

    public static partial class XTend
    {
        
    }
}