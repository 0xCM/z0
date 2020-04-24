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
        [MethodImpl(Inline), Not, Closures(UnsignedInts)]
        public static void not<T>(in T A, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.not(in uint8(in A), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                not(n, in A, ref Z);
            else if(typeof(T) == typeof(uint))
                not(n, 4, 8, in A, ref Z);
            else if(typeof(T) == typeof(ulong))
                not(n, 16, 4, in A, ref Z);
            else
                throw Unsupported.define<T>();
        }
    }
}
