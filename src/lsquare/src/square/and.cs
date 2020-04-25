//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed; 
    using static Memories;
    using static AsIn;
    
    using BL = ByteLogic;

    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquare
    {
        [MethodImpl(Inline), And, Closures(UnsignedInts)]
        public static void and<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.and(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                and(w, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                and(w, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                and(w, 16, 4, in A, in B, ref Z);
            else
                throw Unsupported.define<T>();
        }

    }
}