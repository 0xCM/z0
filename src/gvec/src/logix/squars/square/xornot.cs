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
        [MethodImpl(Inline), XorNot, Closures(Closure)]
        public static void xornot<T>(in T A, in T B, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.xornot(u8(A), u8(B), ref u8(dst));
            else if(typeof(T) == typeof(ushort))
                xornot(w, in A, in B, ref dst);
            else if(typeof(T) == typeof(uint))
                xornot(w, 4, 8, in A, in B, ref dst);
            else if(typeof(T) == typeof(ulong))
                xornot(w, 16, 4, in A, in B, ref dst);
            else
                throw no<T>();
        }
    }
}