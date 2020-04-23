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
        [MethodImpl(Inline), Impl, Closures(UnsignedInts)]
        public static void impl<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.impl(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                impl(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                impl(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                impl(n, 16, 4, in A, in B, ref Z);
            else
                throw Unsupported.define<T>();
        }
    }
}