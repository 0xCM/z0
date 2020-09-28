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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bit32 testz<T>(in T a, in T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testz(in uint8(in a), in uint8(in b));
            else if(typeof(T) == typeof(ushort))
               return testz(w, in a, in b);
            else if(typeof(T) == typeof(uint))
               return testz(w, 4, 8, in uint32(in a), in uint32(in b));
            else if(typeof(T) == typeof(ulong))
               return testz(w, 16, 4, in uint64(in a), in uint64(in b));
            else
                throw no<T>();
        }
    }
}