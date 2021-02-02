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

    using BL = ByteLogic64;

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquare
    {
        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.cnonimpl(in u8(a), in u8(b), ref u8(dst));
            else if(typeof(T) == typeof(ushort))
                cnonimpl(w, in a, in b, ref dst);
            else if(typeof(T) == typeof(uint))
                cnonimpl(w, 4, 8, in a, in b, ref dst);
            else if(typeof(T) == typeof(ulong))
                cnonimpl(w, 16, 4, in a, in b, ref dst);
            else
                throw no<T>();
        }
    }
}