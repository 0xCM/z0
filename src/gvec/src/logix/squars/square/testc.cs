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
        public static bit testc<T>(in T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testc(u8(a));
            else if(typeof(T) == typeof(ushort))
               return vtestc(w, a);
            else if(typeof(T) == typeof(uint))
               return testc(w, 4, 8, a);
            else if(typeof(T) == typeof(ulong))
                return testc(w, 16, 4, a);
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit testc<T>(in T a, in T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testc(in u8(a),in u8(b));
            else if(typeof(T) == typeof(ushort))
               return vtestc(w, in a,in b);
            else if(typeof(T) == typeof(uint))
               return testc(w, 4, 8, in a, in b);
            else if(typeof(T) == typeof(ulong))
                return testc(w, 16, 4, in a, in b);
            else
                throw no<T>();
        }
    }
}