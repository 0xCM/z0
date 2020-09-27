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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void select<T>(in T A, in T B, in T C, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.select(in uint8(in A), in uint8(in B), in uint8(in C), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                select(w, in A, in B, in C, ref Z);
            else if(typeof(T) == typeof(uint))
                select(w, 4, 8, in A, in B, in C, ref Z);
            else if(typeof(T) == typeof(ulong))
                select(w, 16, 4, in A, in B, in C, ref Z);
            else
                throw no<T>();
        }
    }
}
