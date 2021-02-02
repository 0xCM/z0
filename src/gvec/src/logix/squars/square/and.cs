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
               BL.and(u8(a), u8(b), ref u8(dst));
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