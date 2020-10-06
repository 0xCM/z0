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
        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static void impl<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.impl(in uint8(in a), in uint8(in b), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                impl(w, in a, in b, ref dst);
            else if(typeof(T) == typeof(uint))
                impl(w, 4, 8, in a, in b, ref dst);
            else if(typeof(T) == typeof(ulong))
                impl(w, 16, 4, in a, in b, ref dst);
            else
                throw no<T>();
        }
    }
}