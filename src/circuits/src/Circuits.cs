//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Generic vectorized intrinsics
    /// </summary>
    public class Circuits
    {
        [MethodImpl(Inline)]
        public static HalfAdder<T> half<T>()
            where T : unmanaged
                => default(HalfAdder<T>);
    }
}