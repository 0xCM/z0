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
    partial class LSquares
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void select<T>(in T A, in T B, in T C, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.select(in uint8(in A), in uint8(in B), in uint8(in C), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                select(n, in A, in B, in C, ref Z);
            else if(typeof(T) == typeof(uint))
                select(n, 4, 8, in A, in B, in C, ref Z);
            else if(typeof(T) == typeof(ulong))
                select(n, 16, 4, in A, in B, in C, ref Z);
            else
                throw Unsupported.define<T>();
        }
    }
}
