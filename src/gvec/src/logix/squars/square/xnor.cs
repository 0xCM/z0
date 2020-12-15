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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void xnor<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.xnor(u8(a), u8(b), ref u8(dst));
            else if(typeof(T) == typeof(ushort))
                xnor(w, a, b, ref dst);
            else if(typeof(T) == typeof(uint))
                xnor(w, 4, 8, a, b, ref dst);
            else if(typeof(T) == typeof(ulong))
                xnor(w, 16, 4, a, b, ref dst);
            else
                throw no<T>();
        }
    }
}