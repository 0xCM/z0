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
        [MethodImpl(Inline), CImpl, Closures(Closure)]
        public static void cimpl<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.cimpl(u8(a), u8(b), ref u8(dst));
            else if(typeof(T) == typeof(ushort))
                cimpl(w, in a, in b, ref dst);
            else if(typeof(T) == typeof(uint))
                cimpl(w, 4, 8, in a, in b, ref dst);
            else if(typeof(T) == typeof(ulong))
                cimpl(w, 16, 4, in a, in b, ref dst);
            else
                throw no<T>();
        }
    }
}