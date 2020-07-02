//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void apply<T>(Func<uint,T> f, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0u; i<dst.Length; i++)
                As.seek(dst,i) = f(i);            
        }
    }
}