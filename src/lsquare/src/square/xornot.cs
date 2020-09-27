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

    using BL = BitLogics.Bytes;

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquare
    {
        [MethodImpl(Inline), XorNot, Closures(Closure)]
        public static void xornot<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.xornot(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                xornot(w, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                xornot(w, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                xornot(w, 16, 4, in A, in B, ref Z);
            else
                throw no<T>();
        }
    }
}