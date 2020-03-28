//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    /// <summary>
    /// Generic vectorized intrinsics
    /// </summary>
    [ApiHost("api")]
    public static class Circuits
    {
        [MethodImpl(Inline)]
        public static ref readonly HalfAdder<T> halfadder<T>()
            where T : unmanaged 
                => ref HalfAdder<T>.Circuit;            
    }
}