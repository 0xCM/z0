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
    partial class LSquare
    {
        [MethodImpl(Inline), Xor, Closures(UnsignedInts)]
        public static void xor<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.xor(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                xor(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                xor(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                xor(n, 16, 4, in A, in B, ref Z);
            else
                throw Unsupported.define<T>();
        }
    }
}