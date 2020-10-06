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
        public static void xor<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.xor(in uint8(in a), in uint8(in b), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                xor(w, in a, in b, ref dst);
            else if(typeof(T) == typeof(uint))
                xor(w, 4, 8, in a, in b, ref dst);
            else if(typeof(T) == typeof(ulong))
                xor(w, 16, 4, in a, in b, ref dst);
            else
                throw no<T>();
        }
    }
}