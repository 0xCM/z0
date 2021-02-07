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
        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static void nor<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.nor(u8(a), u8(b), ref u8(dst));
            else if(typeof(T) == typeof(ushort))
                nor(w, a, b, ref dst);
            else if(typeof(T) == typeof(uint))
                nor(w, 4, 8, a, b, ref dst);
            else if(typeof(T) == typeof(ulong))
                nor(w, 16, 4, a, b, ref dst);
            else
                throw no<T>();
        }
    }
}
