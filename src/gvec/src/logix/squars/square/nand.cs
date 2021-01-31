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
        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static void nand<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.nand(in u8(in A), in u8(in B), ref u8(Z));
            else if(typeof(T) == typeof(ushort))
                nand(w, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                nand(w, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                nand(w, 16, 4, in A, in B, ref Z);
            else
                throw no<T>();
        }
    }
}