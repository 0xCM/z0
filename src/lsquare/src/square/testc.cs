//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static AsIn;
    using static Seed; 
    using static Memories;
    
    using BL = ByteLogic;
    
    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquare
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit testc<T>(in T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testc(in uint8(in a));
            else if(typeof(T) == typeof(ushort))
               return vtestc(w, a);
            else if(typeof(T) == typeof(uint))
               return testc(w, 4, 8, a);
            else if(typeof(T) == typeof(ulong))
                return testc(w, 16, 4, a);
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit testc<T>(in T A, in T B)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testc(in uint8(in A),in uint8(in B));
            else if(typeof(T) == typeof(ushort))
               return vtestc(w, in A,in B);
            else if(typeof(T) == typeof(uint))
               return testc(w, 4, 8, in A, in B);
            else if(typeof(T) == typeof(ulong))
                return testc(w, 16, 4, in A, in B);
            else
                throw Unsupported.define<T>();
        }
    }
}