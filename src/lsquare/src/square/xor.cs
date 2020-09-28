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

    using BL = BitLogic.Bytes;

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquare
    {
        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static void xor<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.xor(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                xor(w, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                xor(w, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                xor(w, 16, 4, in A, in B, ref Z);
            else
                throw no<T>();
        }
    }
}