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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void select<T>(in T a, in T b, in T C, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.select(u8(a), u8(b), u8(C), ref u8(dst));
            else if(typeof(T) == typeof(ushort))
                select(w, in a, in b, in C, ref dst);
            else if(typeof(T) == typeof(uint))
                select(w, 4, 8, in a, in b, in C, ref dst);
            else if(typeof(T) == typeof(ulong))
                select(w, 16, 4, in a, in b, in C, ref dst);
            else
                throw no<T>();
        }
    }
}
