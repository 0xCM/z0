//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using LS = LogicSquares;

    partial class LogicSquared
    {
        [MethodImpl(Inline), And, Closures(Closure)]
        public static void and<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                LS.and(w64, default(T)).Invoke(a, b, ref dst);
            else if(typeof(T) == typeof(ushort))
                LS.and(w256, default(T)).Invoke(a, b, ref dst);
            else if(typeof(T) == typeof(uint))
                LS.and(w256, default(T)).Invoke(4, 8, a, b, ref dst);
            else if(typeof(T) == typeof(ulong))
                LS.and(w256, default(T)).Invoke(16, 4, a, b, ref dst);
            else
                throw no<T>();
        }
    }
}