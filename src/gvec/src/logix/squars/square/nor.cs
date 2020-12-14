//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    using BL = BitLogic.Bytes;

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquare
    {
        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static void nor<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.nor(u8(A), u8(B), ref u8(Z));
            else if(typeof(T) == typeof(ushort))
                nor(w, A, B, ref Z);
            else if(typeof(T) == typeof(uint))
                nor(w, 4, 8, A, B, ref Z);
            else if(typeof(T) == typeof(ulong))
                nor(w, 16, 4, A, B, ref Z);
            else
                throw no<T>();
        }
    }
}
