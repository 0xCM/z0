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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit testz<T>(in T a, in T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testz(u8(a), u8(b));
            else if(typeof(T) == typeof(ushort))
               return testz(w, a, b);
            else if(typeof(T) == typeof(uint))
               return testz(w, 4, 8, u32(a), u32(b));
            else if(typeof(T) == typeof(ulong))
               return testz(w, 16, 4, u64(a), u64(in b));
            else
                throw no<T>();
        }
    }
}