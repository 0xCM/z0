//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void apply<T>(Func<uint,T> f, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0u; i<dst.Length; i++)
                seek(dst,i) = f(i);            
        }
    }
}