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
        [MethodImpl(Inline), CImpl, Closures(Closure)]
        public static void cimpl<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.cimpl(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                cimpl(w, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                cimpl(w, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                cimpl(w, 16, 4, in A, in B, ref Z);
            else
                throw no<T>();
        }
    }
}