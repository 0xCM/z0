//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static In;

    using BL = ByteLogic64;

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquare
    {
        [MethodImpl(Inline), And, Closures(Closure)]
        public static void and<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.and(in uint8(in a), in uint8(in b), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                and(w, in a, in b, ref dst);
            else if(typeof(T) == typeof(uint))
                and(w, 4, 8, in a, in b, ref dst);
            else if(typeof(T) == typeof(ulong))
                and(w, 16, 4, in a, in b, ref dst);
            else
                throw no<T>();
        }
    }
}